using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
Al poner ":" significa "Point3d HEREDA DE Point" y se trae todo, lo publico y lo protegido de esa clase. Hacer esto se llama derivar de una clase a otra también.
Podríamos decir que Point es la "clase padre" o "clase madre"
Si ahora nos vamos a nuestro Programa inicial, y creamos un nuevo objeto de esta claes podemos ver que podemos ver todas las propiedades de la clase Point
y además las que creamos recién acá en Point3d. 
A esto lo llamamos HERENCIA SIMPLE - porque heredamos sólamente de una clase (Point)
Ahora viene lo importante: sólo podemos heredar en C# de una clase, es decir, no puedo heredar de Point y de otra clase que tenga. 
Y se puede entonces heredar de varias clases? SI, pero desde una interface (lo veremos más adelante en detalle)
*/
namespace Herencia
{
    public class Point3d : Point
    {
        public int Z { get; private set; }

        public void SetZ(int value)
        {
            if (value < 30)
                Z = value;
            else
                throw new ArgumentOutOfRangeException();
        }
        public int GetZ()
        {
            return Z;
        }
            
    }
}
