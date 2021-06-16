using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public class ClientesDALObjetos : IClientesDAL
    {
        private static List<Cliente> clientes = new List<Cliente>();
        public void Agregar(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void Eliminar(string rut)
        {
            Cliente eliminado = clientes.Find(c => c.Rut == rut);
            clientes.Remove(eliminado);

        }

        public List<Cliente> Filtrar(int nivel)
        {
            return clientes.FindAll(c => c.Nivel == nivel);
        }

        public List<Cliente> Obtener()
        {
            return clientes;
        }

 
    }
}
