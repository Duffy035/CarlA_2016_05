//Carl Andersson

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarlA_MVC_2016_05.Models
{
    public class GetCurrentSpeed
    {
        public double Speed(string distanceCoveredValue, string timeValue) 
        {
            //double parsedValue;
            //string rightValue;

            var distance = int.Parse(distanceCoveredValue);
            var time = int.Parse(timeValue);

            var speed = distance/time;
            return speed;
        }

        private bool Speed(bool v)
        {
            throw new DivideByZeroException("Ett fel uppstod: Dividera inte med 0, prova igen");
        }
    }
}