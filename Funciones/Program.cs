using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Modulo4_funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ya de por si static void Main es una funcion, asi que ya dentro de acá podemos escribir la lógica de nuestra app, y si necesitamos
            // podemos llamarla mas adelante como veremos después para reutilizar el código. Lo importante es que tenga una función en especifico mi función
            // Por ejemplo, que multiplique O divida O suma (no todas a la vez)
            // Dentro de la Programacion Orientada a Objetos, las clases tienen código, y este código se encuentra dentro de las funciones que se pueden llamar Metodos
            // si no devuelven nada, o funciones si devuelven resultados. Como ejemplo: 

            string saludo = Saludo("Cristian","Dominguez"); // acá le agrego los parámetros, y ya que estoy creo una variable y le asigno esta función
        }

        public static string Saludo(string nombre, string apellidos)       //Acá por ejemplo la funcion es Saludo, que si le pasamos dos parametros: nombre y apellidos
                                                                           //nos devuelve una cadena que dice Mi nombre es nombre y apellidos
        {
            return $"Mi nombre es {nombre} {apellidos}";
        }

        // Tipos de funciones:
        // Que solo ejecutan código (mejor conocidos como metodos):
        public static void metodo()
        {
            WriteLine("Valor");
        }

        // Devuelve un valor pero no recibe valores:
        public static int funcionSinParametros()
        {
            return 7 + 9;
        }

        // Se le pasan parametros y devuelve un valor (el ejemplo del nombre y apellido que está más arriba)

        // Metodo que no devuelve valor y recibe parametros

        public static void metodoConParametro(string nombre, string apellido)
        {
            WriteLine($"{nombre} {apellido}");
        }
         
        

        

    }
}
