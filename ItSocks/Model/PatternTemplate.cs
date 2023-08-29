using ItSocks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSocks.Model
{
    public class PatternTemplate
    {
        // responsible for holding the pattern.
        // One might argue that the should not be here and it might be in a txt file or something insted
        // that controller can call though the data layer
        public SockCalculator SockCalculator = new SockCalculator();

        public async Task<string> CuffTemplate(int masks, int shoeSize)
        {
            double startingNumberOfMasks = await SockCalculator.CastOnMasksCalculator(masks, shoeSize);
            string patternText = "bla bla " + startingNumberOfMasks + " bla bla";

            return patternText;
        }

        public async Task<string> ShaftTemplate()
        {
            string patternText = "Skaft: ";

            return patternText;
        }

        public async Task<string> HeelTemplate()
        {
            string patternText = "Hæl: ";

            return patternText;
        }

        public async Task<string> SoelTemplate()
        {
            string patternText = "Sål: ";

            return patternText;
        }

        public async Task<string> ToeTemplate()
        {
            string patternText = "Tå: ";

            return patternText;
        }
    }
}
