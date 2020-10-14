using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schreibtools
{
    class Kugelschreiber:Stift
    {
        public Kugelschreiber(double Strichstärke, ConsoleColor Farbe)
        {
            this.Strichstärke = Strichstärke;
            this.Farbe = Farbe;
            this.Typ = "Kugelschreiber";
        }
    }
}
