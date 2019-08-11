using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Shapes
{
    class Line : Shape

    {
        private double _length;
        private double _angle;
        private int _area;

        public Line(double length, double angle)
        {
            _length = length;
            _angle = angle;

            Random rnd = new Random();
            double[,] _coordinats = new double[2, 2];

            double firstX = rnd.Next(1000);
            double firstY = rnd.Next(1000);

            if (_angle % 90 == 0)
            {
                _coordinats[1, 0] = firstX + _length;
            }
            if (_angle == 0)
            {
                _coordinats[1, 1] = firstY + _length;
            }

            _coordinats[0, 0] = firstX; // Начало линии
            _coordinats[0, 1] = firstY; 

            _coordinats[1, 0] = firstX + _length / Math.Cos(_angle); // Конец линии
            _coordinats[1, 1] = firstY + _length / Math.Sin(_angle); 

            Coordinats = _coordinats;
        }

      

        protected double[,] Coordinats { set;get;}

        public  override void ShowCoordinats()
        {
            Console.WriteLine("Начало линии имеет координаты по X = {0}, по Y = {1}.",Coordinats[0, 0], Coordinats[0, 1]);
            Console.WriteLine("Конец линии имеет координаты по X = {0}, по Y = {1}.", Coordinats[1, 0], Coordinats[1, 1]);
        }
        public override void Move(double shiftX, double shiftY)
        {
            Coordinats[0, 0] += shiftX;
            Coordinats[0, 1] += shiftY;

            Coordinats[1, 0] += shiftX;
            Coordinats[1, 1] += shiftY;
        }

        public override double MeasureArea()
        {
            _area = 0;
            return _area;
        }


        
    }
}
