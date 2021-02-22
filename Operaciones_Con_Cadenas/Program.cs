using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Operaciones_Con_Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string villano = "Gru";
            string esbirros = "Minions";
            string frase = $"Los minions ayudan a {villano} a conquistar el mundo";

            // Concatenar cadenas
            string concatenar = String.Concat(villano, " tiene ", esbirros);
            WriteLine(concatenar);
            ReadLine();

            // Encontrar cadenas
            if (villano.Contains("Gru"))
            {

            }
            if (esbirros.Contains("Mini"))
            {

            }

            // Obtener subcadena
            string subCadena = frase.Substring(4, 7);
            WriteLine(subCadena);
            ReadLine();

            // Una cadena acaba en..
            if (frase.EndsWith("mundo"))
            {

            }

            // Insertar una cadena en otra
            frase.Insert(3, " adorables");
            WriteLine(frase);
            ReadLine();

            // Encontrar posicion de una cadena
            var posicion = frase.LastIndexOf("mundo");
            frase.Insert(posicion, "enorme ");
            WriteLine(frase);
            ReadLine();

            // Borrar Cadena
            var posicionDos = frase.LastIndexOf("enorme");
            frase.Remove(posicionDos, 7);

            // Reemplazar Cadena
            frase.Replace("mundo", "luna");
            WriteLine(frase);
            ReadLine();

            // Dividir Cadena
            var palabras = frase.Split(' ');

            foreach (var palabra in palabras)
            {
                WriteLine(palabra);
            }

            ReadLine();

            //Pasar mayusculas y minusculas
            string GRU = villano.ToUpper();
            string esbirros2 = esbirros.ToLower();
            WriteLine(GRU);
            WriteLine(esbirros2);

            //Podar cadenas
            string espaciosDelanteros = "  palabra";
            string espaciosTraseros = "palabra   ";
            string espacios = "    palabras    ";

            WriteLine(espaciosDelanteros.TrimStart());
            WriteLine(espaciosTraseros.TrimEnd());
            WriteLine(espacios.Trim());

        }
    }
}
