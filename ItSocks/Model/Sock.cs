using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSocks.Model
{
    public class Sock
    {
        public double Cuff { get; set; }
        public double Shaft { get; set; }
        public double Heel { get; set; }
        public double Soel { get; set; }
        public double Toe { get; set; }

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
