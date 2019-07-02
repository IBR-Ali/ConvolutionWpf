using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardioClinic.Hearts;

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

                IHeart heart = CreateHeart(ref type);
                if(type == null)
                    continue;
                rockfeller.InstalHeart(heart);
            }

            Console.ReadLine();
        }

        static IHeart CreateHeart(ref string type)
        {
            switch (type)
            {
                case "h":
                    return new HumanHeart();
                    break;
                case "p":
                    return new PlasticHeart();
                    break;
                case "t":
                    return new TubeHeart();
                    break;
                default:
                    Console.WriteLine(" This heart type is not ready. Do you want to choose another heart type? (y)es/(n)o");
                    string choose = Console.ReadLine();
                    if (choose == "y")
                    {
                        type = null;
                    }
                    return new EmptyHeart();
                    break;
            }
        }
    }
}
