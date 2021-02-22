using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;
// Es importante remarcar que tenemos que instansear primero a System.Collections para poder utilizar los distintos tipos de colecciones.

namespace Tipo_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList miLista = new ArrayList();

            //miLista.Add(1);
            //miLista.Add("Batman");

            //// Notese que no es fuertemente tipado el ArrayList, puede contener strings, ints, whatever
            //// Si queremos acceder a lo que abarca nuestra lista, simplemente hacemos un foreach como antes:

            //foreach (var item in miLista)
            //{
            //    WriteLine(item);
            //}

            //ReadLine();

            ////Si queremos recuperar el elemento o información en base a su posición, simplemente declaramos una variable (en este caso elemento) 
            ////Que alojará el elemento o información de la posición 0.

            //var elemento = miLista[0];
            //WriteLine(elemento);
            //ReadLine();

            ////Si queremos obtener la cantidad de elementos que tiene un ArrayList, utilizamos la propiedad (los metodos siempre se declaran con "()"):

            //int contador = miLista.Count;
            //WriteLine(contador);
            //ReadLine();

            ////Si queremos insertar elementos en una posición deseada:
            //miLista.Insert(0, "Superman");

            //foreach (var item in miLista)
            //{
            //    WriteLine(item);
            //}
            //ReadLine();

            ////Lo podemos ver en consola igual, pero si queremos corroborarlo de nuevo, vamos a ver que en la posición 0 ahora va a aparecer Superman:
            //var superheroe = miLista[0];
            //WriteLine(superheroe);
            //ReadLine();

            ////Ahora si queremos eliminar a Superman, simplemente utilizamos el metodo:
            //miLista.RemoveAt(0);
            //foreach (var item1 in miLista)
            //{
            //    WriteLine(item1);
            //}
            //ReadLine();

            // De todas formas se recomienda crear listas de esta forma: List<T> en donde la T es el tipo de objeto 
            // Más que nada porque de esta forma siempre se mantiene "un orden" y en este caso seria una lista HOMOGENEA de un mismo objeto, 
            // En cambio declarando el ArrayList se vuelve una lista heterogenea (como el ejemplo anterior, que podiamos sumar tanto strings como ints)

            // En este ejemplo vamos a ver como crear una lista de numeros enteros 

            List<int> enteros = new List<int>();

            enteros.Add(1);
            enteros.Add(14);
            enteros.Add(13);
            enteros.Add(28);

            // Si queremos agregar otro tipo de objetos, deberiamos primero declarar una variable:

            var ciudades = new List<string>();
            ciudades.Add("Buenos Aires");
            ciudades.Add("Cordoba");
            ciudades.Add("Villa Crespo");
            ciudades.Add(null);         // se nos permite agregar un valor null como referencia también, esto está re piola

            // Otra forma de agregar sería de esta manera (más rápida):
           var paises = new List<string>()
            {
                "Argentina",
                "Bolivia",
                "Chile"
            };

            foreach (var item in enteros)
            {
                WriteLine(item);
            }
            ReadLine();

        }
    }
}
