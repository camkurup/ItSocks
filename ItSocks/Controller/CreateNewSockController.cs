using ItSocks.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSocks.Controller
{
    public class CreateNewSockController
    {
        CreateNewSockPatternCalculator createNewSockPatternCalculator = new CreateNewSockPatternCalculator();
        public void CarryPattern(int masks, int rows, int shoeSize, double cuffSizeInCentimeters, int countOfMasksInTheMiddel, int roundsForToe, int masksOnHeel)
        {
            double startingNumberOfMasks = createNewSockPatternCalculator.CastOnMasksCalculator(masks, shoeSize);
            Debug.WriteLine("Antal masker der skal slåes op " + startingNumberOfMasks);

            double rounds = createNewSockPatternCalculator.RoundsOfCuffCalculator(rows, cuffSizeInCentimeters);
            Debug.WriteLine("Antal omgange der skal strikkes " + rounds);

            double heelInCentimeter = createNewSockPatternCalculator.HeelInCentimetersCalculator(rows, masksOnHeel, countOfMasksInTheMiddel);
            Debug.WriteLine("Hælen skal være " +  heelInCentimeter + " cm.");

            double toeInCentimeter = createNewSockPatternCalculator.ToeInCentimeterCalculator(rows, roundsForToe);
            Debug.WriteLine("Tå i Centimeter: " + toeInCentimeter);

            double roundsOfSole = createNewSockPatternCalculator.RoundsOfSoleCalculator(rows);
            Debug.WriteLine("omgange sål i centimeter: " + roundsOfSole);
        }
    }
}
