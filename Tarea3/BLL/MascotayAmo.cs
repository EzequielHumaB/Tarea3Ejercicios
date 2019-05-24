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

            public struct Macosta
            {
                public string nombreMacosta;
                public string especieMascota;
                public int edadMascota;
            }

            

        }
    }
}
