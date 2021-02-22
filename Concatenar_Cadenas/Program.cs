using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Concatenar_Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string superHeroe = "Superman";
            string procedencia = "Kripton";
            string superPoder = "Super Fuerza";

            string SuperMan = $"{superHeroe} procede de {procedencia} y tiene {superPoder}";
            WriteLine(SuperMan);
            ReadLine();

            //Otra forma de hacer esto:

            string SuperMan0 = string.Concat(superHeroe, " procede de ", procedencia, " y tiene ", superPoder);
            WriteLine(SuperMan0);
            ReadLine();

            //String interpolation (la que siempre uso):

            string SuperMan1 = $"{superHeroe} procede de {procedencia} y tiene {superPoder}";
            WriteLine(SuperMan1);
            ReadLine();

        }
    }
}
