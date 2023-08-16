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
        public double CastOnMasksCalculator(int masks, int shoeSize)
        {
            //Index 0-9 in SockPerimeter correspond to the following shoe size:
            //[37, 38, 39, 40, 41, 42, 43, 44, 45, 46]
            switch (shoeSize)
            {
                case 37:
                    shoeSize = 0;
                    break;
                case 38:
                    shoeSize = 1;
                    break;
                case 39:
                    shoeSize = 2;
                    break;
                case 40:
                    shoeSize = 3;
                    break;
                case 41:
                    shoeSize = 4;
                    break;
                case 42:
                    shoeSize = 5;
                    break;
                case 43:
                    shoeSize = 6;
                    break;
                case 44:
                    shoeSize = 7;
                    break;
                case 45:
                    shoeSize = 8;
                    break;
                case 46:
                    shoeSize = 9;
                    break;
                default:
                    Debug.WriteLine("Noget gik galt: det valgte tal er ikke i arrayet");
                    break;
            }

            if (shoeSize == 37)
            {
                shoeSize = 0;
            }
            double perimeter = double.Parse(Properties.Settings.Default.SockPerimeter.Split('-')[shoeSize]);
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
            double numberOfRounds = (cuffSizeInCentimeter/10) * rows;

            return numberOfRounds;
        }

        public double HeelInCentimetersCalculator(double rows, double masksOnHeel, int countOfMasksInTheMiddel) 
        {
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