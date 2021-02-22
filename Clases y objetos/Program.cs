using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// Una clase es una plantilla para la creación de objetos. Cada clase define un conjunto de variables
// Cada objeto creado a partir de una clase o de una plantilla/template se denomina INSTANCIA DE UNA CLASE
// Acá en este ejemplo creo dos objetos distintos. Uno lo llamo cuenta y el otro cuenta1

namespace Clases_y_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bienvenido al Banco");

            CuentaBancaria cuenta = new CuentaBancaria();
            cuenta.Saldo = 15000;

            CuentaBancaria cuenta1 = new CuentaBancaria();
            cuenta1.Saldo = 30000;

            int suma = cuenta1.Saldo + cuenta.Saldo;
            
        }
    }
}
