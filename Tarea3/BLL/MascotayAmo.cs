using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.BLL
{
     /*Crear estructuras enlazadas para guardar
     la información de una mascota y su
     dueño. */

    public class MascotayAmo
    {
        public struct Amo
        {
            public string nombre;
            public int edad;
            public string domicilio;

            public struct Mascota
            {
                public string nombreMacosta;
                public string especieMascota;
                public int edadMascota;

                public Mascota(string snombreMascota, string sespecieMascota, int sedadMascota)
                {
                    nombreMacosta = snombreMascota;
                    especieMascota = sespecieMascota;
                    edadMascota = sedadMascota;
                }

                public override string ToString()
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("Mascota: Nombre: {0} Especie {1} Edad {2}",
                        nombreMacosta,especieMascota,edadMascota);
                    return sb.ToString();
                }


            }

            public Amo(string snombre, int sedad, string sdomicilio)
            {
                nombre = snombre;
                edad = sedad;
                domicilio = sdomicilio;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Amo {0}, Domicilio {1}, edad {2} ",
                    nombre, domicilio, edad);
                return sb.ToString();
            }


        }
    }
}
