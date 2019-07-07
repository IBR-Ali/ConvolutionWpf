using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumCalc
{
    class Calculator
    {
        private ComplexNumber result;

        public void Addition(ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            int a = firstNumber.RealValue + secondNumber.RealValue;
            int b = firstNumber.ImaginaryValue + secondNumber.ImaginaryValue;

            result = new ComplexNumber(a,b);
            result.GetResult();
        }
        public void Subtraction(ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            int a = firstNumber.RealValue - secondNumber.RealValue;
            int b = firstNumber.ImaginaryValue - secondNumber.ImaginaryValue;

            result = new ComplexNumber(a, b);
            result.GetResult();
        }
        public void Multiplication(ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            int a = firstNumber.RealValue * secondNumber.RealValue;
            int b = firstNumber.ImaginaryValue * secondNumber.ImaginaryValue;

            int c = firstNumber.RealValue * secondNumber.ImaginaryValue;
            int d = firstNumber.ImaginaryValue * secondNumber.RealValue;

            result = new ComplexNumber(a-b, c+d);
            result.GetResult();
        }


    }
}
