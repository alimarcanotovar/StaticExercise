using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConveter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var result = (fahrenheit - 32) / 1.8;

            return result;
        }
        public static double CelsiusToFahrenhiet(double celcius)
        {
            var results = (celcius * 9) / 5 + 32;
            return results;
        }
    }
}

