using System;

namespace AdminPersonas
{
    public partial class Program
    {
        
        static void MostrarPersonas()
        {}

        static void BuscarPersona() 
        { }

        static void IngresarPersona()
        {
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
                }while (nombre == string.Empty);

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

                Persona p = new Persona();
                p.Nombre = nombre;

                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Telefono: {0}", telefono);
                Console.WriteLine("Peso: {0}", peso);
                Console.WriteLine("Estatura: {0}", estatura);
                Console.WriteLine("IMC: {0}", peso / (estatura * estatura));
                Console.ReadKey();





            }
        }
    }
}
