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
        public double CastOnMasksCalculator(int masks)
        {
            //Index 0-9 in SockPerimeter correspond to the following shoe size:
            //[37, 38, 39, 40, 41, 42, 43, 44, 45, 46]
            double perimeter = double.Parse(Properties.Settings.Default.SockPerimeter.Split('-')[6]);
            double numberOfMasks = (perimeter / 10.0) * masks;

            //Perhaps a "Round off" by 4 is making the pattern to imprecise
            if (Math.Round(numberOfMasks) % 4.0 != 0.0)
            {
                double x = (double)Math.Round(numberOfMasks)/4.0;
                numberOfMasks= x*4.0;
            }

            return  numberOfMasks;
        }

        public double RoundsOfCuffCalculator(int rows, double cuffSizeInCentimeter)
        {
            rows = 32;
            cuffSizeInCentimeter = 2.5;
            double numberOfRounds = (cuffSizeInCentimeter/10) * rows;

            return numberOfRounds;
        }

        public double HeelInCentimetersCalculator(double rows, double masksOnHeel, int countOfMasksInTheMiddel) 
        {
            rows = 32;
            masksOnHeel = 30;
            countOfMasksInTheMiddel = 10;

            double heelInCentimeter = (10/rows) * (masksOnHeel-countOfMasksInTheMiddel);

            return heelInCentimeter;
        }

        public double ToeInCentimeterCalculator(int rows, int roundsForToe)
        {
            double container = (10.0 / rows) * roundsForToe;
            double toeInCentimeter = (double)Math.Round(container);

            return toeInCentimeter;
        }

        public double LengthOfSoleCalculator(double lengthOfFood)
        {
            double lengthOfSole = (lengthOfFood - (lengthOfFood * 0.1)) - (HeelInCentimetersCalculator(32,30,10) + ToeInCentimeterCalculator(32, 17));
            Debug.WriteLine("lengthOfSole: " + lengthOfSole);
            return lengthOfSole;
        }

        public double RoundsOfSoleCalculator(int rows)
        {
            double container = (LengthOfSoleCalculator(27.5)/10) * rows;
            double roundsOfSole = (double)Math.Round(container);
            return roundsOfSole;
        }
    }
}