using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int e;
            string r = null;
            do
            {
                double a = 0, b = 0, op;
               

                Console.WriteLine("MENÚ");
                Console.WriteLine("1. suma");
                Console.WriteLine("2. resta");
                Console.WriteLine("3. multiplicación");
                Console.WriteLine("4. división");
                Console.WriteLine("5. salir \n");

                Console.WriteLine("elija que operación desea realizar");

                e = Convert.ToInt32(Console.ReadLine());



                if (e <= 4)
                {
                    try
                    {
                        Console.Write("ingrese una cantidad: ");
                        a = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("dato invalido");
                        Console.Write("ingrese una cantidad: ");
                        a = Convert.ToDouble(Console.ReadLine());
                    }

                    try
                    {
                        Console.Write("ingrese una cantidad: ");
                        b = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("dato invalido");
                        Console.Write("ingrese una cantidad: ");
                        b = Convert.ToDouble(Console.ReadLine());
                    }

                    if (e == 1)
                    {
                        op = a + b;

                        Console.WriteLine("\n             total: " + op);

                    }

                    if (e == 2)
                    {
                        op = a - b;

                        Console.WriteLine("\n             total: " + op);
                    }

                    if (e == 3)
                    {
                        op = a * b;

                        Console.WriteLine("\n             producto: " + op);
                    }

                    if (e == 4)
                    {
                        op = a / b;

                        Console.WriteLine("\n             cociente: " + op);

                    }

                }
                else
                {
                    Console.Clear();
                }

                Console.WriteLine("¿desea continuar ejecutando la aplicación? (S/N)");
                r = Console.ReadLine();
            } while (r=="S" || r=="s");

            Console.ReadKey();
        }
    }
}
