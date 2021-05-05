using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjercicioThreads.Hebra
{
    public class HebraEjercicios
    {
        private int numero;

        public HebraEjercicios(int n )
        {
            this.numero = n;

        }
        
        public void ejecutar()
        {
            Thread.Sleep(this.numero * 1000);
            Console.WriteLine("hola desde {0}", numero);

        }
    }
}
