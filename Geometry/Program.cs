using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry.Shapes;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicEditor graphicEditor = new GraphicEditor();

            graphicEditor.Add(new Line(25,30));
            graphicEditor.Add(new Triangle(12, 16,45));
            graphicEditor.Add(new Circle(50));
            graphicEditor.Add(new Triangle(50, 5, 60));

            Console.WriteLine("Сумма площадей всех фигур: {0}",graphicEditor.ShowAreaSum());
            graphicEditor.ShowAllInfo();

            graphicEditor.Delete(1);
            graphicEditor.Move(2, 50, 30);

            Console.WriteLine("Сумма площадей всех фигур: {0}", graphicEditor.ShowAreaSum());
            graphicEditor.ShowAllInfo();

            Console.ReadLine();
        }
    }
}
