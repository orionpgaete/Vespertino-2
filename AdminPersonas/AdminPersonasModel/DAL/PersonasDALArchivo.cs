using AdminPersonas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdminPersonasModel.DAL
{
    public class PersonasDALArchivo : IPersonasDAL
    {
        private static string archivo = "adminpersonas.txt";
        private static string ruta = Directory.GetCurrentDirectory() + "/" + archivo;
        public void AgregarPersona(Persona persona)
        {
            //1. Crear el StreamWriter
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    //2. Agregar una linea al archivo
                    string texto = persona.Nombre + ";"     // CSV; 
                                  + persona.Estatura + ";"
                                  + persona.Telefono + ";"
                                  + persona.Peso + ";";
                    writer.WriteLine(texto);
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir archivo" + ex.Message);
            }


            //3. Cerrar el StreamWriter StreamRead
        }

        public List<Persona> FiltrarPersonas(string nombre)
        {
            return ObtenerPersonas().FindAll(p => p.Nombre == nombre);
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();
            using (StreamReader read = new StreamReader(ruta))
            {
                string texto;
                do
                {
                    //Leer datos del archivo hasta que no haya nada
                    texto = read.ReadLine().Trim();
                    if (texto != null)
                    {

                        //nombre, estatura, telefono, peso
                        string[] textoArr = texto.Split(';');
                        string nombre = textoArr[0];
                        double estatura = Convert.ToDouble(textoArr[1]);
                        uint telefono = Convert.ToUInt32(textoArr[2]);
                        double peso = Convert.ToDouble(textoArr[3]);

                        Persona p = new Persona()
                        {
                            Nombre = nombre,
                            Estatura = estatura,
                            Telefono = telefono,
                            Peso = peso
                        };
                        // calcular el IMC
                        p.calcularIMC();
                        personas.Add(p);
                    }
                } while (texto != null);
            }
            return personas;
        }
    }
}
