using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Fecha

{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime();
            fecha = DateTime.Now;

            //WriteLine($"ToLocalTime: {fecha.ToLocalTime()}");
            //WriteLine($"ToLongDateString: {fecha.ToLongDateString()}");
            //WriteLine($"ToLongTimeString: {fecha.ToLongTimeString()}");
            //WriteLine($"ToOADate: {fecha.ToOADate()}");
            //WriteLine($"ToShortTimeString: {fecha.ToShortTimeString()}");
            //WriteLine($"ToShortDateString: {fecha.ToShortDateString()}");
            //WriteLine($"ToString: {fecha.ToString()}");
            //WriteLine($"ToUniversalTime: {fecha.ToUniversalTime()}");
            //ReadLine();

            string fechaString = String.Format("La fecha de hoy es: {0:dd/MM/yyyy hh:mm:ss}", DateTime.Now);
            WriteLine(fechaString);
            ReadLine();

        }
    }
}
