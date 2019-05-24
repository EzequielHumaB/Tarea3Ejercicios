using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.BLL
{
    /*Crear una estructura para guardar los
    productos de una tienda. */

    public class TiendaClase
    {
        public struct  Articulos
        {
            public string articulo;
            public int cantidadArticulo;
               
            public Articulos(string sarticulo, int scantidadArticulo)
            {
                articulo = sarticulo;
                cantidadArticulo = scantidadArticulo;
            }

            public static string devolverArticulo(string articulo, int cantArticulo)
            {
                return articulo + " " + cantArticulo;
            }
        }
    }
}
