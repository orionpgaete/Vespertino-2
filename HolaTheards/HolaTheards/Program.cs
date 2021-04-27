using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HolaTheards
{
    class Program
    {
        static void ejecutar()
        {
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("Hola desde hebra {0} rep {1}", i, Thread.CurrentThread.Name);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Esto esta antes de la hebra");
            Thread t1 = new Thread(new ThreadStart(ejecutar));
            t1.Name = "hebra de Profe";
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(ejecutar));
            t2.Name = "hebra de alumnos";
            t2.Start();

            Console.WriteLine("Esto se esta ejecutando despues de la hebra");
            Console.ReadKey();
        }
    }
}
