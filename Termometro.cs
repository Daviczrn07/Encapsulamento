using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    internal class Termometro
    {
        private double _temperaturaCelsius;

        public double Celsius
        {
            get { return _temperaturaCelsius; }

            set { _temperaturaCelsius = value; }
        }

        public double Fahrenheit
        {
            get { return _temperaturaCelsius * 9 / 5 + 32; }

            set { _temperaturaCelsius = (value - 32) * 5 / 9; }
        }

        public double Kelvin
        {
            get { return _temperaturaCelsius + 273.15; }

            set { _temperaturaCelsius = value - 273.15; }

        }

    }
}
