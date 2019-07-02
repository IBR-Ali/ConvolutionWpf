using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioClinic.Hearts
{
    class EmptyHeart : IHeart

    {
        public void Connect()
        {
            
        }

        public string GetStatus()
        {
            return 0.ToString();
        }

        public double HeartRate
        {
            set { }
            get { return 0; }
        }
    }
}
