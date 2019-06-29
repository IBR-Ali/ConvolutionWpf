using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioClinic
{
    class TubeHeart : IHeart
    {
        public void Connect()
        {
            Console.WriteLine("Tube heart installed");
            Console.WriteLine(GetStatus());
        }

        public string GetStatus()
        {
            string status = "Heart rate is " + HeartRate + ", price of heart is " + Price;
            return status;
        }

        public double HeartRate
        {
            set { }
            get { return 80; }
        }

        string Price
        {

            set { }
            get { return "999 999 999$"; }

        }
    }
}
