using AdminPersonasModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdminPersonas
{
    public partial class Program
    {
        //static PersonasDAL personasDAL = new PersonasDAL();
        static IPersonasDAL personasDAL = new PersonasDALArchivo();
        static void MostrarPersonas()
        {
            List<Persona> personas = personasDAL.ObtenerPersonas();
            for (int i=0; i< personas.Count(); ++i)
            {
                Persona actual = personas[i];
                Console.WriteLine("{0}: Nombre:{1} Peso:{2}", i+1, actual.Nombre, actual.Peso);
            }

        }

        static void BuscarPersona() 
        {
            //FORMA 1
            //Console.WriteLine("Ingrese nombre");
            //List<Persona> filtrada = new PersonasDAL().FiltrarPersonas(Console.ReadLine().Trim());
            //filtrada.ForEach(p => Console.WriteLine("Nombre: {0} Peso:{1}", p.Nombre, p.Peso));

            //FORMA 2
            Console.WriteLine("Ingrese nombre");
            personasDAL
                .FiltrarPersonas(Console.ReadLine().Trim())
                .ForEach(p => Console.WriteLine("Nombre: {0} Peso:{1}", p.Nombre, p.Peso));



        }

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

                //Persona p = new Persona();
                //p.Nombre = nombre;
                //p.Estatura = estatura;
                //p.Peso = peso;
                //p.Telefono = telefono;

                Persona p = new Persona()
                {
                    Nombre = nombre,
                    Estatura = estatura,
                    Telefono = telefono,
                    Peso = peso
                };
                personasDAL.AgregarPersona(p);

                p.calcularIMC();
                Console.WriteLine("Nombre: {0}", p.Nombre);
                Console.WriteLine("Telefono: {0}", p.Telefono);
                Console.WriteLine("Peso: {0}", p.Peso);
                Console.WriteLine("Estatura: {0}", p.Estatura);
                Console.WriteLine("IMC: {0}", p.IMC.Texto);
                Console.ReadKey();

            }
        }
    }
}
