using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tarea3.BLL
{

    /*\
     Crear el diseño de una clase para llevar el inventario de una tienda.
     */
    public class InventarioTiendaCapitulo10
    {

        private string nombre;
        private int cantidad;

        public InventarioTiendaCapitulo10(string snombre, int scantidad)
        {
            snombre = nombre;
            scantidad = cantidad;
        }
        
        public void setNombre(string snombre)
        {
            snombre = nombre;
        }

        public string getNombre(string nombre)
        {
            return nombre;
        }

        public void setCantidad(int scantidad)
        {
            scantidad = cantidad;
        }

        public int getCantidad(int cantidad)
        {
            return cantidad;
        }

    }
}
