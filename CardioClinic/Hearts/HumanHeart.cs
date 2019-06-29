using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioClinic
{
    class HumanHeart : IHeart
    {
        public void Connect()
        {
            Console.WriteLine("Human heart installed");
            Console.WriteLine(GetStatus());
        }

        public string GetStatus()
        {
            string status = "Heart rate is " +  HeartRate.ToString() + ", previous owner name is " + PreviousOwnerName;
            return status;
        }

        public double HeartRate
        {
            set { }
            get { return 90; }
        }

        string PreviousOwnerName
        {

            set { }
            get { return "Jesus"; }

        }
    }
}
