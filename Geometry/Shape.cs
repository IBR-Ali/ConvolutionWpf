using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
   abstract class Shape
    {

        protected double[,] Coordinats { get; set; }
        public abstract void ShowCoordinats();
        public abstract void Move(double shiftX, double shiftY);

        public abstract double MeasureArea();


    }
}
