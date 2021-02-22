using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* 
A veces algunas clases toman prestada su definición de otra clase, y eso es la herencia. Esto implica que en vez de escribir otra clase con todos los metodos
y hacer un copy paste, se pueden tomar el estado del comportamiento de una clase y usarlo en una nueva.
Está la herencia simple y la múltiple. 
Supongamos en este ejemplo que ya tenemos nuestra clase definida que toma dos puntos coom referencia, pero queremos que tome un punto mas para que sea en 3D
Para eso necesitaríamos el eje Z. Entonces creo una nueva clase llamada Point3d
 */
namespace Herencia
{
    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public void SetX(int value)
        {
            if (value < 100)
                X = value;
            else
                throw new ArgumentOutOfRangeException();
        }
        public void SetY(int value)
        {
            if (value > 50)
                Y = value;
            else
                throw new ArgumentOutOfRangeException();
        }
        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }
    }   
}
