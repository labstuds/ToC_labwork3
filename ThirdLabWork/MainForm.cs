using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using LoggerEvsLib;
namespace ThirdLabWork
{
    public partial class MainForm : Form
    {
        StatisticalDescription statDescr;
        SortedList<Double, Double> selection = new SortedList<double, double>();
        public MainForm()
        {
            LoggerEvs.messageCame += writeLogNoteToWidget;            
            InitializeComponent();
        }

        private void writeLogNoteToWidget(String logNote)
        {
            rtbLog.AppendText(logNote);
            rtbLog.ScrollToCaret();
        }

        private void открытьВыборкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdReadSelection.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (ofdReadSelection.ShowDialog() != DialogResult.OK)
                return;
            if (ofdReadSelection.FileName != null)
            {
                selection = readSelectionFromFile(ofdReadSelection.FileName);
                statDescr = new StatisticalDescription(selection); fillSelectionGrid();
                enableWidgs();
                LoggerEvs.writeLog(String.Format("Выборка из файла {0} загружена", ofdReadSelection.FileName));                
                countSelectionCharacteristics();
            }
            else
            {
                String error = "Не был выбран файл с выборкой";
                LoggerEvs.writeLog(error);
                MessageBox.Show(error);
            }
        }

        /// <summary>
        /// Рассчитать характеристики выборки
        /// </summary>
        private void countSelectionCharacteristics()
        {
            LoggerEvs.writeLog("Расчет характеристик выборки");
            tbDispersionX.Text = statDescr.countSampleVariance(selection.Keys.ToArray()).ToString("N5");
            LoggerEvs.writeLog("Дисперсия x = " + tbDispersionX.Text);
            tbDispersionY.Text = statDescr.countSampleVariance(selection.Values.ToArray()).ToString("N5");
            LoggerEvs.writeLog("Дисперсия y = " + tbDispersionY.Text);
            tbExpectedValueX.Text = statDescr.countExpectedValue(selection.Keys.ToArray()).ToString("N5");
            LoggerEvs.writeLog("Мат. ожидание x = " + tbExpectedValueX.Text);
            tbExpectedValueY.Text = statDescr.countExpectedValue(selection.Values.ToArray()).ToString("N5");
            LoggerEvs.writeLog("Мат. ожидание y = " + tbExpectedValueY.Text);
            tbRootMeanSqX.Text = statDescr.rootMeanSquare(selection.Keys.ToArray()).ToString("N5");
            LoggerEvs.writeLog("Среднее квадратическое x = " + tbRootMeanSqX.Text);
            tbRootMeanSqY.Text = statDescr.rootMeanSquare(selection.Values.ToArray()).ToString("N5");
            LoggerEvs.writeLog("Среднее квадратическое y = " + tbRootMeanSqY.Text);
            tbKxy.Text = statDescr.selectiveCorrelationTime().ToString("N5");
            LoggerEvs.writeLog("Выборочный корреляционный момент Kxy = " + tbKxy.Text);
            tbRo.Text = statDescr.selectiveCorrelationCoeff().ToString("N5");
            LoggerEvs.writeLog("Выборочный коэффициент корреляции = " + tbRo.Text);
        }

        private void enableWidgs()
        {            
            gbCounting.Enabled = true;
            gbLog.Enabled = true;
        }

        private void fillSelectionGrid()
        {
            LoggerEvs.writeLog("Заполнить таблицу выборки");
            dgvSelection.Rows.Add(selection.Count);
            var i = 0;
            foreach (var pair in selection)
            {
                dgvSelection.Rows[i].Cells[0].Value = pair.Key;
                dgvSelection.Rows[i].Cells[1].Value = pair.Value;
                i++;
            }
        }

        private SortedList<Double, Double> readSelectionFromFile(String path)
        {
            SortedList<Double, Double> selection = new SortedList<double, double>();            
            StreamReader srSelection = new StreamReader(path);
            KeyValuePair<Double, Double> kvPair;
            while(!srSelection.EndOfStream)
            {
                kvPair = parseStr(srSelection.ReadLine());
                selection.Add(kvPair.Key, kvPair.Value);
            }
            return selection;            
        }       

        private KeyValuePair<Double, Double> parseStr(String toParse)
        {            
            string[] values = toParse.Split(';');
            Double key = Double.Parse(values[0]);
            Double value = Double.Parse(values[1]);
            KeyValuePair<Double, Double> kvPair = new KeyValuePair<double,double>(key, value);            
            return kvPair;
        }

        private void btnBuildDiagram_Click(object sender, EventArgs e)
        {
            LoggerEvs.writeLog("\r\n================================\r\nПостроение диаграммы рассеивания\r\n================================");
            DispersionDiagramForm ddForm = new DispersionDiagramForm(statDescr);
            ddForm.Show();
        }

        private void построитьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statDescr == null)
            {
                String error = "Загрузите выборку!";
                LoggerEvs.writeLog(error);
                MessageBox.Show(error);                
            }
            else
            {
                StringBuilder report = new StringBuilder();
                // Сохранить выборку
                saveSelectionElements(report);
                // Сохранить математические характеристики
                saveSelectionMathChars(report);
                // Сохранить отчет
                String filename = saveReportToFile(report);
                MessageBox.Show("Отчет по выборке был сохранен в файл " + filename);
            }
        }

        private String saveReportToFile(StringBuilder report)
        {
            String filename = String.Format("Report_{0:dd.MM.yyyy HH_mm_ss}.report", DateTime.Now);
            StreamWriter swReport = new StreamWriter(filename);
            swReport.Write(report.ToString());
            swReport.Close();
            return filename;
        }

        private void saveSelectionMathChars(StringBuilder report)
        {
            report.Append("Математические характеристики выборки\r\n");
            report.Append("Дисперсия по x = " + tbDispersionX.Text + "\r\n");
            report.Append("Дисперсия по y = " + tbDispersionY.Text + "\r\n");
            report.Append("Среднее квадратическое по x = " + tbRootMeanSqX.Text + "\r\n");
            report.Append("Среднее квадратическое по y = " + tbRootMeanSqY.Text + "\r\n");
            report.Append("Мат. ожидание по x = " + tbExpectedValueX.Text + "\r\n");
            report.Append("Мат. ожидание по y = " + tbExpectedValueY.Text + "\r\n");
            report.Append("Выборочный корреляционный момент Kxy = " + tbKxy.Text + "\r\n");
            report.Append("Выборочный коэффицеинт корреляции = " + tbRo.Text + "\r\n");
        }

        private void saveSelectionElements(StringBuilder report)
        {
            report.Append("ОТЧЕТ ПО ВЫБОРКЕ\r\n");
            report.Append("Объем выборки (x; y): " + statDescr.Selection.Count + "\r\n");
            foreach (var pair in statDescr.Selection)
                report.Append(String.Format("({0}; {1})\r\n", pair.Key, pair.Value));
        }
    }
}
