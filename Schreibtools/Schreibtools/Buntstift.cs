using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schreibtools
{
    class Buntstift:Stift
    {
        public Buntstift(double Strichstärke, ConsoleColor Farbe)
        {
            this.Strichstärke = Strichstärke;
            this.Farbe = Farbe;
            this.Typ = "Buntstift";
        }
    }
}
