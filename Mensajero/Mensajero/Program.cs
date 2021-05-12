using Mensajero.Comunicacion;
using MensajerosModel;
using MensajerosModel.DAL;
using ServidorSocketUtils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mensajero
{
    class Program
    {
        private static IMensajesDAL mensajesDAL = MensajeDALArchivos.GetInstancia();
        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("Bienvenido al Mensajero");
            Console.WriteLine("1. Ingresar \n 2. Mostrar \n 0. Salir");
            switch (Console.ReadLine().Trim())
            {
                case "1": Ingresar();
                    break;
                case "2": Mostrar();
                    break;
                case "0": continuar = false;
                    break;

                default: Console.WriteLine("Ingrese de nuevo");
                    break;
            }
            return continuar;

        }

     
        static void Main(string[] args)
        {
            //1. Iniciar el Servidor Socket en el puerto 3000
            //2. El puerto tiene que ser configurable en el App.Config
            //3. cuando reciba un cliente, tiene que solicitar a ese cliente el 
            //nombre y el texto, y agregar un nuevo mensaje con el tipo TCP.
            // IniciarServidor();

            HebraServidor hebra = new HebraServidor();
            //hebra.Ejecutar();
            Thread t = new Thread(new ThreadStart(hebra.Ejecutar));
            t.IsBackground = true;
            t.Start();
            while (Menu()) ;
            
            //proxima Clase;
            //1. ¿Ateder mas de un cliente a la vez?
            //2. ¿Evitar que dos clientes ingresen al archivo a la vez?
            //3. ¿evitar el bloqueo mutuo?

        }

        static void Ingresar()
        {
            Console.WriteLine("Ingrese nombre: ");
            string nombre = Console.ReadLine().Trim();
            Console.WriteLine("Ingrese texto: ");
            string texto = Console.ReadLine().Trim();
            Mensaje mensaje = new Mensaje()
            {
                Nombre = nombre,
                Texto = texto,
                Tipo= "Aplicacion"
            };
            mensajesDAL.AgregarMensaje(mensaje);

        }

        static void Mostrar()
        {
            List<Mensaje> mensajes = mensajesDAL.ObtenerMensajes();
            foreach(Mensaje mensaje in mensajes)
            {
                Console.WriteLine(mensaje);
            }
        }
    }
}
