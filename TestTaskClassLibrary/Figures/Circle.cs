using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskClassLibrary.Figures
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Validate(radius);
            Radius = radius;
        }
        public double Radius { get; protected set; }
        /// <summary>
        /// Вычесление полощади круга по формуле π * R^2
        /// </summary>
        /// <returns>Площадь круга</returns>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        /// <summary>
        /// Проверка на возможность создания окружности
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        protected override bool Validate(params double[] data)
        {
            if (data.Length == 1)
            {
                if (data[0] <= 0)
                {
                    throw new Exception($"Радиус должен быть положительным");
                }

                return true;
            }
            else
            {
                throw new Exception($"Конструктор должен содержать в себе 1 значение");
            }
        }
    }
}
