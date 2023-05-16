using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskClassLibrary.Figures
{
    public class Triangle : Shape
    {
        public Triangle(double sideFirst, double sideSecond, double sideThird)
        {
            Validate(sideFirst, sideSecond, sideThird);
            SideFirst = sideFirst;
            SideSecond = sideSecond;
            SideThird = sideThird;
        }

        public double SideFirst { get; protected set; }
        public double SideSecond { get; protected set; }
        public double SideThird { get; protected set; }

        /// <summary>
        /// Вычесление площади треугольника по трём сторонам <br/>
        /// √p(p - a)(p - b)(p - c) <br/>
        /// где p - полупериметр (a+b+c) * (1/2) <br/>
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double GetArea()
        {
            // √p(p - a)(p - b)(p - c) 
            //p - полупериметр (a+b+c) * (1/2)
            double p = (SideFirst + SideSecond + SideThird) * 0.5;
            return Math.Sqrt(p*((p-SideFirst)*(p - SideSecond)*(p - SideThird)));
        }

        /// <summary>
        /// Проврека являеться ли данные трегульник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool GetTriangleRectangular()
        {
            if (Math.Pow(SideFirst, 2) + Math.Pow(SideSecond, 2) == Math.Pow(SideThird, 2) ||
                Math.Pow(SideFirst, 2) + Math.Pow(SideThird, 2) == Math.Pow(SideSecond, 2)|| 
                Math.Pow(SideThird, 2) + Math.Pow(SideSecond, 2) == Math.Pow(SideFirst, 2))
                return true;
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверка на возможность создания треугольника <br/>
        /// вырожденные треугольники мы тоже признаем невалидными
        /// </summary>
        /// <param name="data">Стороны треугольника</param>
        /// <returns></returns>
        protected override bool Validate(params double[] data)
        {
            if (data.Length == 3)
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (data[i] <= 0)
                    {
                        throw new Exception($"Аргумент {i + 1} должен быть положительным");
                    }
                }

                if (data[0] + data[1] <= data[2]) throw new Exception($"Такого треугольника не может существовать"); ;
                if (data[0] + data[2] <= data[1]) throw new Exception($"Такого треугольника не может существовать"); ;
                if (data[1] + data[2] <= data[0]) throw new Exception($"Такого треугольника не может существовать"); ;

                return true;
            }
            else
            {
                throw new Exception($"Конструктор должен содержать в себе 3 значения");
            }
        }
    }
}
