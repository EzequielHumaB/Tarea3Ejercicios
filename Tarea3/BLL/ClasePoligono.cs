using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.BLL
{
    /*
     Crear una clase para polígonos con
     sobrecarga del constructor. (En este caso un cubo)
     */
    public class ClasePoligono
    {
        private int lado;
        private int area;
        private int volumen;

        public ClasePoligono(int slado)
        {
            lado = slado;
        }
        public ClasePoligono(int slado, int sarea, int svolumen)
        {
            lado = slado;
            area = sarea;
            volumen = svolumen;
        }

        /*
         Crear propiedades para la clase polígono
         que solamente permitan colocar valores
         válidos
         */
        public int Lado
        {
            get
            {
                return lado;
            }

            set
            {
                if (value <= 0)
                    lado = 1;
                else
                    lado = value;
            }
        }

        public int CalcularArea(int lado)
        {
            area = (lado * lado) * 6;
            return area;
        }

        public int CalcularVolumen(int lado)
        {
            volumen = lado * lado * lado;
            return volumen;
        }
        /*
         Programar el método ToString() para la
         clase polígono.
         */



    }
}
