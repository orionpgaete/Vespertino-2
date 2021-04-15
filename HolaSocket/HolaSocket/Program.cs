using HolaSocket.Comunicacion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HolaSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            Console.WriteLine("Iniciando Servidor en puerto {0}", puerto);

            ServerSocket servidor = new ServerSocket(puerto);

            if (servidor.Iniciar())
            {
                //OK puede conectar
                Console.WriteLine("Servidor iniciado");
                while (true)
                {
                    Console.WriteLine("Esperando Cliente...");
                    Socket socketCliente = servidor.ObtenerCliente();
                    //Construir el mecanismo para escribirle y leerle
                    ClienteCom cliente = new ClienteCom(socketCliente);
                    //aqui ira el protocolo de comunicacion, para ambos luego conocerlo
                    cliente.Escribir("Hola Mundo cliente, dime tu nombre???");
                    string respuesta = cliente.Leer();
                    Console.WriteLine("El cliente dijo: {0} ", respuesta);
                    cliente.Escribir("Chaoo loco nos vemos otro dia" + respuesta);
                    cliente.Desconectar();
                }
                
            }
            else
            {
                Console.WriteLine("Error, el puerto {0} es en uso", puerto);
            }
        }
    }
}
