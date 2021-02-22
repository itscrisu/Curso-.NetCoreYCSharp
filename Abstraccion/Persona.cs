using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// Es importante saber que el objetivo de la programación no es reproducir todos los aspectos posibles de un concepto dado por ejemplo, persona en este caso.
// No se intenta modelar TODO lo que pasa dentro de una Persona, simplemente se aborda el concepto que trata el programa especifico. 

namespace Abstraccion
{
    class Persona
    {
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Ciudad { get; set; }
        public DateTime ColorPelo { get; set; }
    }
}
