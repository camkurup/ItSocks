using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSocks.Model
{
    public class SockEventArgs : EventArgs
    {
        public Sock Sock { get; set; }

        public SockEventArgs(Sock sock) 
        {
            this.Sock = sock;
        }
    }
}
