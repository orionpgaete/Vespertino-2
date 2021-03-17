using System;


namespace Clase_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo 2021");
            Console.WriteLine("Ingrese su nombre");
            //esto es un scaner
            String nombre = Console.ReadLine();
            // print de pantalla con parametro
            Console.WriteLine("Su nombre es {0} ", nombre);
            Console.WriteLine("Ingrese la edad: ");
            string edadTx = Console.ReadLine().Trim();
            int edad = Int32.Parse(edadTx);
            //"      hola" .TrimStart()
            //"hola      " .TrimEnd()
            Console.WriteLine("Su edad es {0}", edad);

            Console.WriteLine("Maximo int: {0}", int.MaxValue);
            Console.WriteLine("Maximo uint: {0}", uint.MaxValue);
          

            Console.ReadKey();
        
        }
    }
}
