using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioClinic
{
    class PlasticHeart : IHeart
    {
        public void Connect()
        {
            Console.WriteLine("Plastic heart installed");
            Console.WriteLine(GetStatus());
        }

        public string GetStatus()
        {
            string status = "Heart rate is " + HeartRate + ", serial number is " + SerialNumber;
            return status;
        }

        public double HeartRate
        {
            set { }
            get { return 80; }
        }

        int SerialNumber
        {

            set { }
            get { return  97869325; }

        }
    }
}
