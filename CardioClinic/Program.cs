using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Mr. Rockfeller ");
            Client rockfeller = new Client();
            string type = null;

            while (type == null)
            {
                Console.WriteLine("There are (h)uman, (p)lastic, and (t)ube hearts in our clinic. \nWhat kind of heart do you want to install?");
                type = Console.ReadLine();

                rockfeller.InstalHeart(ref type);
            }
        }
    }
}
