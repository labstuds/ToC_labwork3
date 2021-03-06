﻿using System;
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
            Double[] xVals = new Double[statDescr.Selection.Count];
            Double[] yVals = new Double[statDescr.Selection.Count];
            StatisticalDescription.extractCoordsToArray(xVals, yVals, statDescr.Selection); 
            PointPairList lonelyPoint = new PointPairList();
            lonelyPoint.Add(statDescr.countExpectedValue(xVals), statDescr.countExpectedValue(yVals));
            LineItem averageCoordsPoint = grPane.AddCurve("AverageCoordsPoint", lonelyPoint, Color.Red, SymbolType.Circle);
            averageCoordsPoint.Symbol.Size = 10;
            //averageCoordsPoint.Line.Width = 10;
            averageCoordsPoint.Label.IsVisible = false;
        }

        private void installGraphSettings()
        {
            LoggerEvs.writeLog("Настройка графика...");
            grPane = zgDispersionDiagram.GraphPane;
            grPane.Title.Text = "";
            //zgDispersionDiagram.IsShowCursorValues = true;
            zgDispersionDiagram.IsShowPointValues = true; 
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
            Double[] xVals = new Double[statDescr.Selection.Count];
            Double[] yVals = new Double[statDescr.Selection.Count];
            StatisticalDescription.extractCoordsToArray(xVals, yVals, statDescr.Selection); 
            LoggerEvs.writeLog("Нанесение точек по координатам из выборки на график");
            PointPairList pointsList = new PointPairList(xVals, yVals);            
            foreach (var pair in statDescr.Selection)
                LoggerEvs.writeLog(String.Format("({0:N4}; {1:N4})", pair.x, pair.y));
            LineItem currentCurve = grPane.AddCurve("SelectionPoints", pointsList, Color.Blue, SymbolType.Circle);
            currentCurve.Line.IsVisible = false;
            currentCurve.Symbol.Fill.Color = Color.Blue;
            currentCurve.Symbol.Fill.Type = FillType.Solid;            
            currentCurve.Symbol.Size = 7;
            currentCurve.Label.IsVisible = false;
        }

        private void drawLineX()
        {
            Double[] xVals = new Double[statDescr.Selection.Count];
            Double[] yVals = new Double[statDescr.Selection.Count];
            StatisticalDescription.extractCoordsToArray(xVals, yVals, statDescr.Selection); 
            LoggerEvs.writeLog("Построение линии регрессии с зависимостью от y");
            PointPairList linePointsList = new PointPairList();
            Double xAverageValue = statDescr.countExpectedValue(xVals);
            Double yAverageValue = statDescr.countExpectedValue(yVals);
            Double betaOne = statDescr.countBetaOne(yVals);
            Double betaZero = statDescr.countBetaZero(xAverageValue, yAverageValue, betaOne);
            Double funcValue;
            funcValue = f("x", "y", yVals.Max(), betaZero, betaOne);
            linePointsList.Add(funcValue, yVals.Max());
            LoggerEvs.writeLog(String.Format("Добавление точки ({0:N4}; {1:N4})", funcValue, yVals.Max()));
            funcValue = f("x", "y", 0 - yVals.Min(), betaZero, betaOne);
            linePointsList.Add(funcValue, 0 - yVals.Min());
            LoggerEvs.writeLog(String.Format("Добавление точки ({0:N4}; {1:N4})", funcValue, 0 - yVals.Min()));
            String curveName = String.Format("x(y) = {0:N3} + {1:N3} * y", betaZero, betaOne);
            LineItem lineCurve = grPane.AddCurve(curveName, linePointsList, Color.Red, SymbolType.None);
            lineCurve.Line.Width = 3;
            lineCurve.Line.IsAntiAlias = true;
            //lineCurve.Label.IsVisible = false;
        }

        private void drawLineY()
        {
            Double[] xVals = new Double[statDescr.Selection.Count];
            Double[] yVals = new Double[statDescr.Selection.Count];
            StatisticalDescription.extractCoordsToArray(xVals, yVals, statDescr.Selection); 
            LoggerEvs.writeLog("Построение линии регрессии с зависимостью от x");
            PointPairList linePointsList = new PointPairList();
            Double xAverageValue = statDescr.countExpectedValue(xVals);
            Double yAverageValue = statDescr.countExpectedValue(yVals);
            Double betaOne = statDescr.countBetaOne(xVals);
            Double betaZero = statDescr.countBetaZero(yAverageValue, xAverageValue, betaOne);
            Double funcValue;
            funcValue = f("y", "x", xVals.Max(), betaZero, betaOne);
            linePointsList.Add(xVals.Max(), funcValue);
            LoggerEvs.writeLog(String.Format("Добавление точки ({0:N4}; {1:N4})", xVals.Max(), funcValue));
            funcValue = f("y", "x", 0 - xVals.Min(), betaZero, betaOne);
            linePointsList.Add(0 - xVals.Min(), funcValue);
            LoggerEvs.writeLog(String.Format("Добавление точки ({0:N4}; {1:N4})", 0 - xVals.Min(), funcValue));
            String curveName = String.Format("y(x) = {0:N3} + {1:N3} * x", betaZero, betaOne);
            LineItem lineCurve = grPane.AddCurve(curveName, linePointsList, Color.DarkGreen, SymbolType.None);
            lineCurve.Line.IsAntiAlias = true;
            lineCurve.Line.Width = 3;            
            //lineCurve.Label.IsVisible = false;
        }

        public static Double f(String functionName, String argumentName, Double arg, Double betaZero, Double betaOne)
        {
            Double result = StatisticalDescription.f(arg, betaZero, betaOne);
            LoggerEvs.writeLog(String.Format("{0} = {1:N4} = {2:N4} + {3:N4} * {4}", functionName, result, betaZero, betaOne, argumentName));
            return result;
        }       

        private void saveGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zgDispersionDiagram.SaveAsBitmap();
        }
    }
}
