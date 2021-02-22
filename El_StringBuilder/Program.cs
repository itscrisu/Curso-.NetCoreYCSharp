using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace stringbuilderpa
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder("Hola, soy Crisu");

            sb.Append("Hola, soy Crisu");
            sb.Append("y vivo en Villa Crespo p4");

            // El AppendLine es lo mismo que el Append, solo que tocamos Enter en la consola para que se vea
            sb2.AppendLine("y vivo en Villa Crespo p4");
            sb2.AppendFormat("Actualmente la fecha es: {0: dd-MM-yyyy}", DateTime.Now);
            


        }
    }
}
