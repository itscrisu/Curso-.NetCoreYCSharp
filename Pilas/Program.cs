using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;


namespace Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();

            pila.Push(1);
            pila.Push(5);
            pila.Push(10);
            pila.Push(15);
            pila.Push(20);

            // Al igual que vimos en List, podemos crear un Stack de esta forma:

            Stack<int> pilas = new Stack<int>();
            
            pilas.Push(25);
            pilas.Push(30);
            pilas.Push(35);
            pilas.Push(40);
            pilas.Push(45);

            // La pila es un tipo de estructura LIFO (Last In First Out) O sea, primero que entra, ultimo que sale. 
            // Pensemos en una pila de platos, el primero de todos no lo podríamos sacar porque sino toda la pila se derrumbaría

            // El metodo Pop nos devuelve el último elemento de nuestro Stack y lo quita del mismo. Si el Stack estuviese vacío, nos tiraría: InvalidOperationException
            // Lo recomendable siempre es utilizar la propiedad Count para saber cuántos elementos tiene mi Stack antes de tirar un Pop:

            WriteLine("Numero de elementos en mi Stack: {0}", pila.Count);
            ReadLine();

            while (pila.Count > 0)
            {
                WriteLine(pila.Pop() + ",");
                ReadLine();
            }

            WriteLine("Numero de elementos en mi Stack: {0}", pila.Count);
            ReadLine();

            // Y si queremos recorrer los elementos de nuestra pila, simplemente hacemos un foreach

            //foreach (var item in pila)
            //{
            //    WriteLine(item);
            //    ReadLine();
            //}
                
            // Si queremos 
        }
    }
}
