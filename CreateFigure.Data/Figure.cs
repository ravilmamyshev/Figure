using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFigure.Data
{
    public abstract class Figure
    {
        protected double _square;
        public double Square => _square;

        public void GetSquare()
        {
            Console.WriteLine($"Type: {this.GetType().Name}; Square: {this.Square}");
        }
    }

    public class Circle : Figure
    {
        /// <summary>
        /// Получает площадь круга
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Значение радиуса составляет неположительное число", nameof(radius));
            }
            this._square = Math.Pow(radius, 2) * Math.PI;
        }
    }

    public class Triangle : Figure
    {
        private double[] array;
        /// <summary>
        /// Получает площадь треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double a, double b, double c)
        {
            array = new[] { a, b, c };
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Одно или несколько значений сторон треугольника составляет неположительное число", nameof(array));
            }
            else if (a + b < c || b + c < a || c + a < b)
            {
                throw new ArgumentException("Сумма двух сторон треугольника меньше третьей стороны", nameof(array));
            }
            this._square = GetTriangleSquare(a, b, c);

        }
        /// <summary>
        /// Вычисляет площадь треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public double GetTriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        /// <summary>
        /// Проверяет на то, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            Array.Sort(array);
            return Math.Round(Math.Pow(array[0], 2) + Math.Pow(array[1], 2), 5) == Math.Round(Math.Pow(array[2], 2), 5);
        }
    }
}