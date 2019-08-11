using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class GraphicEditor
    {
        private List<Shape> _shapes;

        public GraphicEditor()
        {
            _shapes = new List<Shape>();
        }
        public void Add(Shape shape)
        {
            _shapes.Add(shape);
        }
        public void Delete(int shapeNum)
        {
            _shapes.RemoveAt(shapeNum);
        }
        public void Move(int shapeNum, double shiftX, double shiftY)
        {
            _shapes[shapeNum].Move(shiftX,shiftY);
        }

        public double ShowAreaSum()
        {
            double area = 0;

            for (int i = 0; i < _shapes.Count; i++)
            {
                area += _shapes[i].MeasureArea();
            }

            return area;
        }

        public void ShowAllInfo()
        {
            for (int i = 0; i < _shapes.Count; i++)
            {
                Console.WriteLine("Фигура с порядковым номером: {0} имеет площадь равную: {1}, а также следуюющие координаты: ", i, _shapes[i].MeasureArea());
                _shapes[i].ShowCoordinats();
            }
        }
    }
}
