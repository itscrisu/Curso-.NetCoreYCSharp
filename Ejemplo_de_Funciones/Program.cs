using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Ejemplo_de_Funciones
{
    class Program
    {
        // Ejemplo de reutilización de código
        static void Main(string[] args)
        {
        // Acá estamos llamando a un método llamado PintaMenuah
            var opcion = PintaMenu();           

        // Dependiendo de la opción que elija el usuario va a ingresar a un while, porque va a estar haciendo esto hasta que salga (o le dé al 5)
            while (opcion != "5")               
            {
                EjecutarOpcion(opcion);
                opcion = PintaMenu();
            }
        }

        public static string PintaMenu()        // PintaMenu nos saca esto por consola y nos va a leer la opción que queremos seleccionar de la lista.
        {
            WriteLine("**** Menu ****");
            WriteLine("**** 1. Suma ****");
            WriteLine("**** 2. Resta ****");
            WriteLine("**** 3. Multiplicación ****");
            WriteLine("**** 4. Mi Operación ****");
            WriteLine("**** 5. Salir ****");
            return ReadLine();
        }

        public static void EjecutarOpcion(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    WriteLine(Suma(1, 7));
                    break;
                case "2":
                    WriteLine(Resta(15, 9));
                    break;
                case "3":
                    WriteLine(Multiplicacion(10, 3));
                    break;
                case "4":
                    WriteLine(MiOperacion(5, 2));
                    break;
                default:
                    break;
            }
        }
        public static int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public static int Resta(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        public static int Multiplicacion(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        // Es mucho mas simple haber hecho así las funciones y llamarlas en MiOperacion porque sino tendría que haber reescrito todo el código de nuevo.
        // Acá simplemente llamo a Suma, Resta y Multiplicación para utilizar sus operaciones.
        public static int MiOperacion(int numero1, int numero2)
        {
            var numeroSuma = Suma(numero1, numero2);
            var resta = Resta(numeroSuma, numero2);
            var multiplicacion = Multiplicacion(numeroSuma, resta);

            return resta;
        }
    }
}
