using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.BLL
{
    /*
     Crear una clase para llevar la
      información de los estudiantes de una
       escuela.
       Como en las otros problemas de este capitulo, las funciones no van a ser estaticas para los set y los gets
         */
    public class Estudiante
    {
        private string nombre;
        private int edad;
        private string curso;
        private DateTime fechaIngreso;

        public Estudiante(string snombre, int sedad, string scurso, DateTime fecha)
        {
            snombre = nombre;
            sedad = edad;
            scurso = curso;
            fecha = fechaIngreso;
        }

        public static string getNombre(string nombre)
        {
            return nombre;
        }
  
        public static int getEdad(int edad)
        {
            return edad;
        }

     
        public static string getCurso(string curso)
        {
            return curso;
        }

         public static DateTime getFechaIngreso(DateTime fechaIngreso)
        {
            return fechaIngreso;
        }


    }
}
