using MensajerosModel;
using MensajerosModel.DAL;
using ServidorSocketUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajero.Comunicacion
{
    class HebraCliente
    {
        private ClienteCom clienteCom;
        private IMensajesDAL mensajesDAL = MensajeDALArchivos.GetInstancia();


        public HebraCliente(ClienteCom clienteCom)
        {
            this.clienteCom = clienteCom;
        }

        public void Ejecutar()
        {
            clienteCom.Escribir("Ingrese nombre: ");
            string nombre = clienteCom.Leer();
            clienteCom.Escribir("Ingrese texto: ");
            string texto = clienteCom.Leer();
            Mensaje mensaje = new Mensaje()
            {
                Nombre = nombre,
                Texto = texto,
                Tipo = "TCP"
            };

            lock (mensajesDAL)
            {
                mensajesDAL.AgregarMensaje(mensaje);
            }

            clienteCom.Desconectar();
        }
    }
}
