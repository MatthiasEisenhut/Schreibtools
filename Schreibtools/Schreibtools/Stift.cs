using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Schreibtools
{
    abstract class Stift
    {
        public ConsoleColor Farbe { get; set; }
        public string Typ { get; set; }
        public double Strichstärke { get; set; }

        public Stift(double Strichstärke)
        {
            this.Farbe = 0;
            this.Typ = "unbekannt";
            this.Strichstärke = Strichstärke;
        }
        public Stift(double Strichstärke, ConsoleColor Farbe)
        {
            this.Strichstärke = Strichstärke;
        }
        public Stift() { }
        public string SchreibeText(string text)
        {
            return $"({Typ}, {Strichstärke}, {Farbe}){text}";
        }

    }
}
