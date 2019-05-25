using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tarea3.BLL
{
    /*
     Crear una enumeración para los
     diferentes tipos de neumáticos.

        En este problema, al contrario de los otros, yo no voy a hacer que el usuario 
        ingrese datos, sino que solamente voy a mostrar algunos tipos de neumaticos
     */
    public class EnumeraciontipodeNeumaticos
    {
        enum tipoNeumaticos { runflat, recauchutados, verdes, radiales, diagonales }
      
        public static string imprimir()
        {
            return tipoNeumaticos.runflat + " , " + tipoNeumaticos.recauchutados + " . " + tipoNeumaticos.verdes +
                " , " + tipoNeumaticos.radiales + " , "+ tipoNeumaticos.diagonales;
        }

    }

}
