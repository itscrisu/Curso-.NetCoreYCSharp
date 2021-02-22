using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* Imaginamos la encapsulación como un envoltorio que rodea los datos de una clase.
Acá usamos como ejemplo la clase Point. Como vemos, las clases son publicas, lo que significa que desde cualquier parte del código se pueda acceder
Pero qué pasa si en realidad X no admite valores mayores a 100? En nuestro programa instanciamos un objeto point de la clase Point y le pusimos un valor de 5000 a X
Lo podemos resolver aplicando encapsulamiento en la otra clase que creamos
(la que se llama PointEncapsulado.cs) creando dos clases privadas. Esto significa que sólo podemos acceder 
 */ 
namespace Encapsulacion
{
    public class Point
    {
        public int X;
        public int Y;
        
    }
}
