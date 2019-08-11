using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Shapes
{
    class Triangle : Shape

    {
        private double _sideFirst;
        private double _sideSecond;
        private double _angle;
        private double _area;

        protected double[,] Coordinats { set; get; }

        public Triangle(double sideFirst, double sideSecond, double angle)
        {
            _sideFirst = sideFirst;
            _sideSecond = sideSecond;
            _angle = angle;

            Random rnd = new Random();
            double[,] _coordinats = new double[3, 2]; // Три угла.

            double firstX = rnd.Next(1000);
            double firstY = rnd.Next(1000);

            if (_angle % 90 == 0)
            {
                _coordinats[1, 0] = firstX + _sideFirst;
            }
            if (_angle == 0)
            {
                _coordinats[1, 1] = firstY + _sideSecond;
            }

            _coordinats[0, 0] = firstX; // Левый нижний угол Х.
            _coordinats[0, 1] = firstY; // Левый нижний угол Y.

            _coordinats[1, 0] = firstX + _sideFirst / Math.Cos(_angle); // Верхний угол Х.
            _coordinats[1, 1] = firstY + _sideSecond / Math.Sin(_angle); // Верхний  угол Y.

            _coordinats[2, 0] = firstX + _sideSecond; // Правый нижний угол Х.
            _coordinats[2, 1] = firstY ; // Правый нижний угол Y.

            Coordinats = _coordinats;
        }
        public override void ShowCoordinats()
        {
            Console.WriteLine("Первый угол имеет координаты по X = {0}, по Y = {1}.", Coordinats[0, 0], Coordinats[0, 1]);
            Console.WriteLine("Второй угол имеет координаты по X = {0}, по Y = {1}.", Coordinats[1, 0], Coordinats[1, 1]);
            Console.WriteLine("Третий угол имеет координаты по X = {0}, по Y = {1}.", Coordinats[2, 0], Coordinats[2, 1]);
        }

        public override void Move(double shiftX, double shiftY)
        {
            for (int i = 0; i < 1; i++) // Выполняем смещение по Х для всех пар точек
            {
                for (int j = 0; j < 3; j++)
                {
                    Coordinats[j, i] += shiftX;
                }
            }

            for (int i = 1; i < 2; i++) // Выполняем смещение по Y для всех пар точек
            {
                for (int j = 0; j < 3; j++)
                {
                    Coordinats[j, i] += shiftY;
                }
            }
        }

        public override double MeasureArea()
        {
            _area = 0.5 * _sideFirst * _sideSecond * Math.Sin(_angle);
            return _area;
        }

    }
}
