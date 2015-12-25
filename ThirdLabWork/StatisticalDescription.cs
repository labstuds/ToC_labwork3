using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ThirdLabWork
{
    /// <summary>
    /// Статистическое описание и вычисление оценок параметров
    /// распределения двумерного случайного вектора
    /// </summary>
    public class StatisticalDescription
    {
        // Выборка
        private SortedList<Double, Double> selection = new SortedList<double, double>();
        public SortedList<Double, Double> Selection { get { return selection; } }
        public StatisticalDescription() { }
        public StatisticalDescription(SortedList<Double, Double> selection)
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
            Double numerator = selectiveCorrelationTime();
            Double denominator = rootMeanSquare(selection.Keys.ToArray()) * rootMeanSquare(selection.Values.ToArray());
            return numerator / denominator;
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
            Double xAverageSimple = countExpectedValue(selection.Keys.ToArray());
            Double yAverageSimple = countExpectedValue(selection.Values.ToArray());
            foreach (var pair in selection)
                sum += (pair.Key - xAverageSimple) * (pair.Value - yAverageSimple);
            return sum;
        }

        #endregion
    }
}
