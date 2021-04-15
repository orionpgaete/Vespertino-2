using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HolaSocket.Comunicacion
{
    public class ServerSocket
    {
        private int puerto;
        private Socket servidor;
        public ServerSocket(int puerto)
        {
            this.puerto = puerto;
        }

        //inicia la conexion del servidor, tomando posesion del puerto
        public bool Iniciar()
        {
            try
            {
                this.servidor = new Socket(AddressFamily.InterNetwork,
                                 SocketType.Stream, ProtocolType.Tcp);
                this.servidor.Bind(new IPEndPoint(IPAddress.Any, this.puerto));
                this.servidor.Listen(10);
                return true;
            }catch(SocketException ex)
            {
                return false;
            }
        }

        public void Cerrar()
        {
            try
            {
                this.servidor.Close();
            }catch(Exception ex)
            {

            }
        }

        public Socket ObtenerCliente()
        {
            return this.servidor.Accept();
        }
    }
}
