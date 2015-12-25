using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using LoggerEvsLib;
namespace ThirdLabWork
{
    public partial class DispersionDiagramForm : Form
    {
        StatisticalDescription statDescr;
        GraphPane grPane;
        public DispersionDiagramForm()
        {           
            InitializeComponent();            
        }

        public DispersionDiagramForm(StatisticalDescription statDescr)
        {
            this.statDescr = statDescr;
            InitializeComponent();                      
            installGraphSettings();            
            drawSelectionPoints(statDescr);             
            drawLineX();
            drawLineY();                        
            drawAverageCoordsPoint(statDescr);           
            zgDispersionDiagram.AxisChange();
            zgDispersionDiagram.Invalidate();            
        }

        private void drawAverageCoordsPoint(StatisticalDescription statDescr)
        {
            PointPairList lonelyPoint = new PointPairList();
            lonelyPoint.Add(statDescr.countExpectedValue(statDescr.Selection.Keys.ToArray()), statDescr.countExpectedValue(statDescr.Selection.Values.ToArray()));
            LineItem averageCoordsPoint = grPane.AddCurve("AverageCoordsPoint", lonelyPoint, Color.Red, SymbolType.Circle);
            averageCoordsPoint.Symbol.Size = 10;
            averageCoordsPoint.Label.IsVisible = false;
        }

        private void installGraphSettings()
        {
            LoggerEvs.writeLog("Настройка графика...");
            grPane = zgDispersionDiagram.GraphPane;
            grPane.Title.Text = "";
            //grPane.XAxis.Title.Text = "Ось X";
            //grPane.YAxis.Title.Text = "Ось Y";
            grPane.YAxis.Cross = 0.0;
            grPane.XAxis.Cross = 0.0;
            grPane.XAxis.Title.IsVisible = false;
            grPane.YAxis.Title.IsVisible = false;
            grPane.CurveList.Clear();
        }

        private void drawSelectionPoints(StatisticalDescription statDescr)
        {
            LoggerEvs.writeLog("Нанесение точек по координатам из выборки на график");
            PointPairList pointsList = new PointPairList(statDescr.Selection.Keys.ToArray(), statDescr.Selection.Values.ToArray());            
            foreach (var pair in statDescr.Selection)
                LoggerEvs.writeLog(String.Format("({0:N4}; {1:N4})", pair.Key, pair.Value));
            LineItem currentCurve = grPane.AddCurve("SelectionPoints", pointsList, Color.Blue, SymbolType.Circle);
            currentCurve.Line.IsVisible = false;
            currentCurve.Symbol.Fill.Color = Color.Blue;
            currentCurve.Symbol.Fill.Type = FillType.Solid;
            currentCurve.Symbol.Size = 7;
            currentCurve.Label.IsVisible = false;
        }

        private void drawLineX()
        {
            LoggerEvs.writeLog("Построение линии регрессии с зависимостью от y");
            PointPairList linePointsList = new PointPairList();
            Double xAverageValue = statDescr.countExpectedValue(statDescr.Selection.Keys.ToArray());
            Double yAverageValue = statDescr.countExpectedValue(statDescr.Selection.Values.ToArray());            
            Double betaOne = statDescr.countBetaOne(statDescr.Selection.Values.ToArray());
            Double betaZero = statDescr.countBetaZero(xAverageValue, yAverageValue, betaOne);
            Double funcValue;
            foreach (var value in statDescr.Selection.Keys.ToArray())
            {
                funcValue = f(value, betaZero, betaOne);
                linePointsList.Add(funcValue, value);
                LoggerEvs.writeLog(String.Format("Добавление точки ({0:N4}; {1:N4})", value, funcValue));
            }
            LineItem lineCurve = grPane.AddCurve("LineX", linePointsList, Color.Green, SymbolType.None);
            lineCurve.Label.IsVisible = false;
        }

        private void drawLineY()
        {
            LoggerEvs.writeLog("Построение линии регрессии с зависимостью от x");
            PointPairList linePointsList = new PointPairList();
            Double xAverageValue = statDescr.countExpectedValue(statDescr.Selection.Keys.ToArray());
            Double yAverageValue = statDescr.countExpectedValue(statDescr.Selection.Values.ToArray());
            Double betaOne = statDescr.countBetaOne(statDescr.Selection.Values.ToArray());
            Double betaZero = statDescr.countBetaZero(yAverageValue, xAverageValue, betaOne);
            Double funcValue;
            foreach (var value in statDescr.Selection.Values.ToArray())
            {
                funcValue = f(value, betaZero, betaOne);
                linePointsList.Add(value, funcValue);
                LoggerEvs.writeLog(String.Format("Добавление точки ({0:N4}; {1:N4})", value, funcValue));
            }
            LineItem lineCurve = grPane.AddCurve("LineY", linePointsList, Color.Green, SymbolType.None);
            lineCurve.Label.IsVisible = false;
        }

        private Double f(Double arg, Double betaZero, Double betaOne)
        {
            Double result = betaZero + betaOne * arg;
            LoggerEvs.writeLog(String.Format("f = {0:N4} = {1:N4} + {2:N4} * {3:N4}", result, betaZero, betaOne, arg));
            return result;
        }

        private void zgDispersionDiagram_Load(object sender, EventArgs e)
        {

        }

        private void saveGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zgDispersionDiagram.SaveAsBitmap();
        }
    }
}
