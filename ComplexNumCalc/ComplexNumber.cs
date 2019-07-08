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
        private string _compNumber;

        public  ComplexNumber(int realPart, int imaginaryPart)
        {
            _realPart = realPart;
            _imaginaryPart = imaginaryPart;
        }

        public ComplexNumber()
        {

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

        public string GetResult()
        {
           _compNumber = $"{_realPart} + {_imaginaryPart}*i ";

           return _compNumber;
        }
        public void Add(ComplexNumber firstNumber, ComplexNumber secondNumber, ref ComplexNumber resultNumber)
        {
            int a = firstNumber.RealValue + secondNumber.RealValue;
            int b = firstNumber.ImaginaryValue + secondNumber.ImaginaryValue;

            resultNumber = new ComplexNumber(a, b);
           
        }
        public void Substract(ComplexNumber firstNumber, ComplexNumber secondNumber, ref ComplexNumber resultNumber)
        {
            int a = firstNumber.RealValue - secondNumber.RealValue;
            int b = firstNumber.ImaginaryValue - secondNumber.ImaginaryValue;

            resultNumber = new ComplexNumber(a, b);
        }
        public void Multiply(ComplexNumber firstNumber, ComplexNumber secondNumber, ref ComplexNumber resultNumber)
        {
            int a = firstNumber.RealValue * secondNumber.RealValue;
            int b = firstNumber.ImaginaryValue * secondNumber.ImaginaryValue;

            int c = firstNumber.RealValue * secondNumber.ImaginaryValue;
            int d = firstNumber.ImaginaryValue * secondNumber.RealValue;

            resultNumber = new ComplexNumber(a - b, c + d);

        }

    }
}
