using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L034_Methods
{
    struct Fahrenheit
    {
        public double Temperature;

        public Celsius Convert()
        {
            Celsius celsius;
            celsius.Temperature = (Temperature -32) / 1.8;
            return celsius;
        }
    }
}
