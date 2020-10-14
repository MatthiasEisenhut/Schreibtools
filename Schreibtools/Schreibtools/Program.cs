using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schreibtools
{
    class Program
    {
        static void Main(string[] args)
        {
            Buntstift b1 = new Buntstift(1.0, ConsoleColor.Cyan);
            Buntstift b2 = new Buntstift(2.3, ConsoleColor.Black);
            Kugelschreiber k1 = new Kugelschreiber(1.3, ConsoleColor.DarkRed);
            Kugelschreiber k2 = new Kugelschreiber(1.6, ConsoleColor.Magenta);
            List<Stift> l1 = new List<Stift>();
            l1.Add(b1);
            l1.Add(b2);
            l1.Add(k1);
            l1.Add(k2);
            Console.WriteLine(b1.SchreibeText("Hallo"));
            Console.WriteLine(b2.SchreibeText("Hallo"));
            Console.WriteLine(k1.SchreibeText("Hallo"));
            Console.WriteLine(k2.SchreibeText("Hallo"));
            Console.ReadKey();
        }
    }
}
