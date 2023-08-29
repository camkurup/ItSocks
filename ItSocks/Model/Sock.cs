using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSocks.Model
{
    public class Sock
    {
        // This is a pattern on a sock. It holds everything a sock needs to be designed
        // A sock is becoming to live by the calculator

        public double Cuff { get; set; }
        public double Shaft { get; set; }
        public double Heel { get; set; }
        public double Soel { get; set; }
        public double Toe { get; set; }

        public Sock() { }

        public Sock(double cuff, double shaft, double heel, double soel, double toe) 
        {
            this.Cuff = cuff;
            this.Shaft = shaft;
            this.Heel = heel;
            this.Soel = soel;
            this.Toe = toe;
        }
    }
}
