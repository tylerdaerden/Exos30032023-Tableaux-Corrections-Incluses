using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L034_Methods
{
    struct Celsius
    {
        public double Temperature;

        public Fahrenheit Convert()
        {
            Fahrenheit fahrenheit;
            fahrenheit.Temperature = (Temperature * 1.8) + 32;
            return fahrenheit;
        }
    }
}
