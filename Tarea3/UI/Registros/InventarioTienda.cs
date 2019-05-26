using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea3.BLL;

namespace Tarea3.UI.Registros
{
    public partial class InventarioTienda : Form
    {
        public InventarioTienda()
        {
            InitializeComponent();
        }

      

        private void Button1_Click(object sender, EventArgs e)
        {
            string nombre = " ";
            int cantidad = 0;
            nombre = textBoxNombre.Text;
            cantidad = Convert.ToInt32(Math.Round(numericUpDownCantidad.Value, 0));
            InventarioTiendaCapitulo10 inventario = new InventarioTiendaCapitulo10(nombre,cantidad);
            textBoxNombre.Text = inventario.getNombre(nombre);
            numericUpDownCantidad.Value = inventario.getCantidad(cantidad);
        }

        private void InventarioTienda_Load(object sender, EventArgs e)
        {

        }
    }
}
