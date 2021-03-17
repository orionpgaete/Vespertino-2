using System;


namespace Clase_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Hola Mundo 2021");
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Su nombre es {0} ", nombre);

            Console.ReadKey();
        
        }
    }
}
