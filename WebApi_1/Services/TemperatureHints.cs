using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_1.Services
{
    public class TemperatureHints
    {
        public string GetHintDependOnTemperature(float temperature)
        {
            if (temperature < 0)
                return "cold";
            else if (temperature >= 0 && temperature < 30)
                return "warm";
            else if (temperature >= 30 && temperature < 50)
                return "hot";
            else
                return "fire";
        }
    }
}
