using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public interface IClientesDAL
    {
        List<Cliente> Obtener();
        void Agregar(Cliente cliente);

        //Eliminar TODO, debera de recibir el PK
        void Eliminar(string rut);

        List<Cliente> Filtrar(int nivel);
    }
}
