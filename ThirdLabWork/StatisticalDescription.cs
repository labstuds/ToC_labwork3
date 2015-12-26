using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ThirdLabWork
{
    public struct Pair
    {
        public Double x;
        public Double y;
        public Pair(Double x, Double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    /// <summary>
    /// Статистическое описание и вычисление оценок параметров
    /// распределения двумерного случайного вектора
    /// </summary>
    public class StatisticalDescription
    {
        // Выборка
        private List<Pair> selection = new List<Pair>();
        public List<Pair> Selection { get { return selection; } }
        public StatisticalDescription() { }
        public StatisticalDescription(List<Pair> selection)
        {
            this.selection = selection;
        }

        #region MathCharacteristics
        // Математическое ожидание
        public Double countExpectedValue(Double[] values)
        {
            return values.Sum() / values.Length;
        }

        // Выборочная дисперсия
        public Double countSampleVariance(Double[] values)
        {
            Double numerator = countQ(values);
            return numerator / (values.Length - 1);
        }
       
        // Среднее квадратическое
        public Double rootMeanSquare(Double[] values)
        {
            return Math.Sqrt(countSampleVariance(values));
        }
                
        // Выборочный корреляционный момент 
        public Double selectiveCorrelationTime()
        {
            Double numerator = countQxy();
            return numerator / selection.Count;
        }

        // Выборочный коэффициент корреляции
        public Double selectiveCorrelationCoeff()
        {
            Double[] xValues = new Double[selection.Count];
            Double[] yValues = new Double[selection.Count];
            Double numerator = selectiveCorrelationTime();
            extractCoordsToArray(xValues, yValues, selection);
            Double denominator = rootMeanSquare(xValues) * rootMeanSquare(yValues);
            return numerator / denominator;
        }

        public static void extractCoordsToArray(Double[] xValues, Double[] yValues, List<Pair> selection)
        {
            for (var i = 0; i < selection.Count; i++)
            {
                xValues[i] = selection[i].x;
                yValues[i] = selection[i].y;
            }
        }
        #endregion

        #region CountingCoeffsForGraph

        public Double countBetaZero(Double averageValue, Double betaOneCoeff, Double betaOne)
        {
            return averageValue - betaOne * betaOneCoeff;
        }

        public Double countBetaOne(Double[] values)
        {
            return countQxy() / countQ(values);
        }

        public Double countQ(Double[] values)
        {
            Double sum = 0;
            Double averageSimple = countExpectedValue(values);
            foreach (var value in values)
                sum += Math.Pow(value - averageSimple, 2);
            return sum;
        }

        public Double countQxy()
        {
            Double sum = 0;
            Double[] xVals = new Double[selection.Count];
            Double[] yVals = new Double[selection.Count];
            extractCoordsToArray(xVals, yVals, selection); 
            Double xAverageSimple = countExpectedValue(xVals);
            Double yAverageSimple = countExpectedValue(yVals);
            foreach (var pair in selection)
                sum += (pair.x - xAverageSimple) * (pair.y - yAverageSimple);
            return sum;
        }

        #endregion
    }
}
