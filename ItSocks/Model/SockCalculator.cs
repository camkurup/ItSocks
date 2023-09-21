using ItSocks.Controller;
using ItSocks.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSocks.Data
{
    /// <summary>
    ///  responsible for calculating and bulding all the nessesaury values for a Sock Pattern
    ///  One Calculator can calculat One pattern = sock
    /// </summary>
    public class SockCalculator
    {

        //Perhaps it would be smart to create a chek on there is used a minimum count of masks.
        //It should not be posilbe to create soks with at knittingGauge on only a few masks
        public async Task<double> CastOnMasksCalculator(int masks, int shoeSize)
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

            return numberOfMasks;
        }

        public async Task<double> RoundsOfCuffCalculator(int rows, double cuffSizeInCentimeter)
        {
            double container = (cuffSizeInCentimeter/10) * rows;

            double numberOfRounds = (double)Math.Round(container);

            return numberOfRounds;
        }

        public async Task<double> MasksInMiddelHeelCalculator()
        {
            int totalNumberOfMasks = (int)await CastOnMasksCalculator(24, 43) / 2;
            int masksOnHeel = totalNumberOfMasks;
            int modulusOffHeel = masksOnHeel % 3;

            int container = (int)masksOnHeel / 3;
            
            double countOfMasksInTheMiddel = 0;

            if (modulusOffHeel == 0)
            {
                countOfMasksInTheMiddel = container;
            }
            if (modulusOffHeel == 1)
            {
                countOfMasksInTheMiddel = container + 1;
            }
            if (modulusOffHeel == 2)
            {
                countOfMasksInTheMiddel = container - 2;
            }
            return countOfMasksInTheMiddel;
        }

        public async Task<double> HeelInCentimetersCalculator(double rows) 
        {
            double masksOnHeel = await CastOnMasksCalculator(24,43) / 2;
            double container = (10/rows) * (masksOnHeel-(double)await MasksInMiddelHeelCalculator());

            double heelInCentimeter = (double)Math.Round(container);

            return heelInCentimeter;
        }

        //this is static for now. I'll get back to making this dynamic at a later point
        public async Task<int> RoundsForToeCalculator()
        {
            int roundsForToe = 17;
            return roundsForToe;
        }

        public async Task<double> ToeInCentimeterCalculator(int rows)
        {
            int roundsForToe = await RoundsForToeCalculator();
            double container = (10.0 / rows) * roundsForToe;
            double toeInCentimeter = (double)Math.Round(container);

            return toeInCentimeter;
        }

        public async Task<double> LengthOfSoelCalculator(double lengthOfFood)
        {
            double lengthOfSole = (lengthOfFood - (lengthOfFood * 0.1)) - (await HeelInCentimetersCalculator(32) + await ToeInCentimeterCalculator(32));
            Debug.WriteLine("lengthOfSole: " + lengthOfSole);
            return lengthOfSole;
        }

        public async Task<double> RoundsOfSoelCalculator(int rows)
        {
            double container = (await LengthOfSoelCalculator(27.5)/10) * rows;
            double roundsOfSole = (double)Math.Round(container);
            return roundsOfSole;
        }

        //Okey this is bad code, because it was just made on a hurry. 
        //Ill badly need to come back here, very soon
        public async Task<double> RoundsOfShaftCalculator(int rows, double lengthOShaft)
        {
            double container = lengthOShaft / 10 * rows;
            double roundsOfSole = (double)Math.Round(container);
            return roundsOfSole;
        }
    }
}