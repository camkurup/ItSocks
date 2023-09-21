using ItSocks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSocks.Model
{
    /// <summary>
    /// responsible for holding the pattern.
    /// One might argue that the should not be here and it might be in a txt file or something insted
    /// that controller can call though the data layer
    /// </summary>
    public class PatternTemplate
    {
        private SockCalculator SockCalculator = new SockCalculator();

        public async Task<string> CuffTemplate(int masks, int shoeSize)
        {
            double startingNumberOfMasks = await SockCalculator.CastOnMasksCalculator(masks, shoeSize);
            string patternText = "Hvis jeg var nået langt nok ville du kunne læse din opskrift her";

            return patternText;
        }

        public async Task<string> ShaftTemplate()
        {
            string patternText = "Men den er desværre ikke færdig designet endnu";

            return patternText;
        }

        public async Task<string> HeelTemplate()
        {
            string patternText = "Jeg har desuden fået øje på nogle små magler";

            return patternText;
        }

        public async Task<string> SoelTemplate()
        {
            string patternText = "Som jeg tænker at arbejde vidre på efterfølgende ";

            return patternText;
        }

        public async Task<string> ToeTemplate()
        {
            string patternText = "Tak for en god opgave, jeg har været glad for at arbejde med den. ";

            return patternText;
        }
    }
}
