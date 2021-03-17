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
           // Console.WriteLine("Su nombre es {0} ", nombre);
            Console.WriteLine("Ingrese la edad: ");
            string edadTx = Console.ReadLine().Trim();
            int edad = -1;
            bool esValido = Int32.TryParse(edadTx, out edad);
            if (!esValido)
            {
                Console.WriteLine("ingrese bien la edad");
            }
            else
            {
                Console.WriteLine("Su nombre es {0} y su edad es {1}", nombre, edad);
            }
            Console.ReadKey();

             
          

            Console.ReadKey();
        
        }
    }
}
