using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Funciones_Locales
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionPrincipal(12);
        }
        public static void FuncionPrincipal(int numero)
        {
            WriteLine($"Estamos dentro de la Función Principal {numero}");

            numero = numero + 10;
            FuncionLocal(numero);

            void FuncionLocal(int numeroLocal) // Esta funcion solo se puede llamar únicamente desde el ámbito donde fue declarada (o sea, sobre FuncionPrincipal)
            {
                numeroLocal = numeroLocal * 15;
                WriteLine(numeroLocal);
            }
        }
        public static void EjemploFuncionLocal()
        {
            int total = 0;
            List<int> lista = new List<int>();
            lista.Add(4);
            lista.Add(5);
            lista.Add(17);

            foreach (var numero in lista)
            {
                total = Suma(numero, total);
                WriteLine(total);
            }

            int Suma(int numero, int totalSuma)
            {
                return numero + totalSuma;
            }
        }
    }
}
