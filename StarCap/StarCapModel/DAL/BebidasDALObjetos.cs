using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public class BebidasDALObjetos : IBebidaDAL
    {
        public List<Bebida> ObtenerBebidas()
        {
            return new List<Bebida>()
            {
                new Bebida()
                {
                    Nombre = "Frapuccino",
                    Codigo = "FP-01"
                },
                new Bebida()
                {
                    Nombre = "Té Chai",
                    Codigo = "TE-01"
                },
                new Bebida()
                {
                    Nombre = "Trompo metro cuadrado",
                    Codigo= "ALEXIS-07"
                }

            };
        }
    }
}
