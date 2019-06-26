using System;
using System.Diagnostics;
using System.IO;

namespace Proxy
{
    public class FileLogWeatherStateCalculator : ICalculator
    {
        private readonly ICalculator _calculator;

        public FileLogWeatherStateCalculator(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public double CalcClouds()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            double result = _calculator.CalcClouds();
            sw.Stop();

            File.AppendAllText("log.txt", " CalcClouds elapsed: " + sw.ElapsedMilliseconds + " ");

            return result;
        }

        public double CalcWind()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            double result = _calculator.CalcWind();
            sw.Stop();

            File.AppendAllText("log.txt", "CalcWind elapsed: " + sw.ElapsedMilliseconds + " ");

            return result;
        }
    }
}