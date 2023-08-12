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
            Debug.WriteLine(Properties.Settings.Default.SockPerimeter.Split(',')[1]);
            var container = Properties.Settings.Default.SockPerimeter.Split(',')[0];
            double omkreds = 25.0;
            double calculator = (double.Parse(container) / 10.0) * a;

            //Perhaps a "Round off" by 4 is making the pattern to imprecise
            if (Math.Round(calculator) % 4 != 0)
            {
                int x = (int)Math.Round(calculator)/4;
                calculator= x*4;
            }

            return  calculator;
        }
    }
}