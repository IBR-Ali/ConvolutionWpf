using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperaturePredictor predictor = new TemperaturePredictor();
            predictor.Calculator = new WeatherStateCalculator();

            var temperature = predictor.PredictTemperature();
            Console.WriteLine(temperature);

            string[] config = File.ReadAllLines("config.txt", Encoding.Default);
            foreach (string logType in config)
            {
                switch (logType)
                {
                    case "file":
                        predictor.Calculator = new FileLogWeatherStateCalculator(new WeatherStateCalculator());
                        predictor.PredictTemperature();
                        break;

                    case "console":
                        predictor.Calculator = new ConsoleLogWeatherStateCalculator(new WeatherStateCalculator());
                        predictor.PredictTemperature();
                        break;

                    default:
                        break;
                }
            }

            Console.ReadLine();
        }

    }
}
