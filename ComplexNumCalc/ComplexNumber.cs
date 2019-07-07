using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumCalc
{
    class ComplexNumber
    {
        private int _realPart;
        private int _imaginaryPart;
        private string compNumber;
        public  ComplexNumber(int realPart, int imaginaryPart)
        {
            _realPart = realPart;
            _imaginaryPart = imaginaryPart;
            compNumber = $"{_realPart} + {_imaginaryPart}*i ";
        }

        public int RealValue
        {
            get { return _realPart; }
            set { _realPart = value; }
        }
        public int ImaginaryValue
        {
            get { return _imaginaryPart; }
            set { _imaginaryPart = value; }
        }

        public void GetResult()
        {
            Console.WriteLine(compNumber);
        }
    }
}
