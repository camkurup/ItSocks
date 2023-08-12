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
        public void CarryPattern(int m, int p, int shoeSize)
        {
            double startingNumberOfMasks = createNewSockPatternCalculator.StartingNumberOfMasksCalculator(m);
            Debug.WriteLine("antal masker der skal slåes op " + startingNumberOfMasks);
        }


    }
}
