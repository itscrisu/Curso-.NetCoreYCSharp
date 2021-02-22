using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Abstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();            
            // Acá nos deja crear un nuevo objeto haciendo referencia a una clase externa porque está dentro del mismo programa que estamos trabajando
            // Esto significa que es un dato "primitivo". En caso de que no estuviese de esta forma, y Persona estuviera en otro programita, tendriamos que
            // importar arriba el mismo. Por ejemplo, si estuviera en "Clases_y_Objetos" tendríamos que poner using Clases_y_Objetos;
        }
    }
}
