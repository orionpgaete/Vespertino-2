using System;

namespace CalculoIMC
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            uint telefono;
            double peso;
            double estatura;

            Console.WriteLine("Bienvenido, al calculo del IMC");

            do
            {
                Console.WriteLine("Ingrese nombre");
                nombre = Console.ReadLine().Trim();
            } // java -> while (nombre.Equals(""));
            while (nombre == string.Empty);

            bool esValido;
            do
            {
                Console.WriteLine("Ingrese el Telefono");
                esValido = UInt32.TryParse(Console.ReadLine(), out telefono);
            } while (!esValido);

    
            do
            {
                Console.WriteLine("Ingrese el peso");
                esValido = double.TryParse(Console.ReadLine(), out peso);
            } while (!esValido);

  
            do
            {
                Console.WriteLine("Ingrese el estatura");
                esValido = double.TryParse(Console.ReadLine(), out estatura);
            } while (!esValido);

            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Telefono: {0}", telefono);
            Console.WriteLine("Peso: {0}", peso);
            Console.WriteLine("Estatura: {0}", estatura);
            Console.WriteLine("IMC: {0}", peso/(estatura*estatura));
            Console.ReadKey();





        }
    }
}
