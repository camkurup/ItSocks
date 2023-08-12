using ItSocks.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSocks.Data
{
    public class CreateNewSockPatternCalculator
    {
        public double StartingNumberOfMasksCalculator(int a)
        {
            //Index 0-9 in SockPerimeter correspond to the following shoe size:
            //[37, 38, 39, 40, 41, 42, 43, 44, 45, 46]
            double container = double.Parse(Properties.Settings.Default.SockPerimeter.Split('-')[1]);
            double numberOfMasks = (container / 10.0) * a;

            //Perhaps a "Round off" by 4 is making the pattern to imprecise
            if (Math.Round(numberOfMasks) % 4.0 != 0.0)
            {
                double x = (double)Math.Round(numberOfMasks)/4.0;
                numberOfMasks= x*4.0;
            }

            return  numberOfMasks;
        }
    }
}