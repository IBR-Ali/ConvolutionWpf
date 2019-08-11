using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Shapes
{
    class Circle : Shape
    {
        private double _radius;
        private double _area;
        protected double[,] Coordinats { set; get; }

        public Circle(double radius)
        {
            _radius = radius;

            Random rnd = new Random();
            double[,] _coordinats = new double[5, 2]; // Центр и 4 угловых точки

            double firstX = rnd.Next(1000);
            double firstY = rnd.Next(1000);
   
            _coordinats[0, 0] = firstX;
            _coordinats[0, 1] = firstY;

            _coordinats[1, 0] = firstX - radius;
            _coordinats[1, 1] = firstY;

            _coordinats[2, 0] = firstX;
            _coordinats[2, 1] = firstY + radius;

            _coordinats[3, 0] = firstX + radius;
            _coordinats[3, 1] = firstY;

            _coordinats[4, 0] = firstX;
            _coordinats[4, 1] = firstY - radius;

            Coordinats = _coordinats;
        }
        public override void ShowCoordinats()
        {
            Console.WriteLine("Центр круга находится в точке с координатами по X = {0}, по Y = {1}.", Coordinats[0, 0], Coordinats[0, 1]);
        }

        public override void Move(double shiftX, double shiftY)
        {
            for (int i = 0; i < 1; i++) // Выполняем смещение по Х для всех пар точек
            {
                for (int j = 0; j < 5; j++)
                {
                    Coordinats[j, i] += shiftX;
                }
            }

            for (int i = 1; i < 2; i++) // Выполняем смещение по Y для всех пар точек
            {
                for (int j = 0; j < 5; j++)
                {
                    Coordinats[j, i] += shiftY;
                }
            }
        }

        public override double MeasureArea()
        {
            _area = Math.PI * _radius * _radius;
            return _area;
        }
        
    }
}
