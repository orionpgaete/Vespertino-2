using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModel.DAL
{
    public class AsistenteDALDB : IAsistentesDAL
    {
        private EventosDBEntities eventosDB = new EventosDBEntities();
        public void AgregarAsistente(Asistente asistente)
        {
            this.eventosDB.Asistentes.Add(asistente);
            this.eventosDB.SaveChanges();
        }

        public void EliminarAsistente(int id)
        {
            //buscar asistente a eliminar asociado al ID
            Asistente asistente = this.eventosDB.Asistentes.Find(id);
            //destruir el asistente
            this.eventosDB.Asistentes.Remove(asistente);
            this.eventosDB.SaveChanges();
        }

        public Asistente Obtener(int id)
        {
            return this.eventosDB.Asistentes.Find(id);
        }

        public List<Asistente> ObtenerAsistentes()
        {
            return this.eventosDB.Asistentes.ToList();
        }
        public void Actualizar(Asistente a)
        {
            Asistente aOriginal = this.eventosDB.Asistentes.Find(a.Id);
            aOriginal.Estado = a.Estado;
            aOriginal.Nombre = a.Nombre;
            // todos los atributos
            this.eventosDB.SaveChanges();
        }
        public List<Asistente> ObtenerAsistentes(string estado)
        {
            //LINQ
            var query = from a in this.eventosDB.Asistentes
                        where a.Estado == estado
                        select a;
            return query.ToList();

        }
    }
}
