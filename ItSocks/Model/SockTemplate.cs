using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSocks.Model
{
    public class SockTemplate
    {
        public async Task<string> CuffTemplate()
        {
            return "Manchet: ";
        }

        public async Task<string> ShaftTemplate()
        {
            return "Skaft: ";
        }

        public async Task<string> HeelTemplate()
        {
            return "Hæl: ";
        }

        public async Task<string> SoelTemplate()
        {
            return "Sål: ";
        }

        public async Task<string> ToeTemplate()
        {
            return "Tå: ";
        }
    }
}
