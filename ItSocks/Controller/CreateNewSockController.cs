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
        public void CarryPattern(int masks, int rows, int shoeSize, double ribbingSizeInCentimeters)
        {
            double startingNumberOfMasks = createNewSockPatternCalculator.CastOnMasksCalculator(masks);
            Debug.WriteLine("Antal masker der skal slåes op " + startingNumberOfMasks);

            double rounds = createNewSockPatternCalculator.RoundsCalculator(rows, ribbingSizeInCentimeters);
            Debug.WriteLine("Antal omgange der skal strikkes " + rounds);
        }
    }
}
