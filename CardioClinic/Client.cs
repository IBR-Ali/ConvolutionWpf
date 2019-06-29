using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioClinic
{
    class Client
    {
        public void InstalHeart(ref string heartType)
        {
            switch(heartType)
            {
              case "h":
                  new HumanHeart().Connect();
                  break;
              case "p":
                  new PlasticHeart().Connect();
                  break;
              case "t":
                  new PlasticHeart().Connect();
                  break;
              default:
                  Console.WriteLine(" This heart type is not ready. Do you want to choose another heart type? (y)es/(n)o");
                  string choose = Console.ReadLine();
                  if (choose == "y")
                  {
                      heartType = null;
                  }
                  break;
            }
        }
    }
}
