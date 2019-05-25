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
    public partial class Capitulo9 : Form
    {
        public Capitulo9()
        {
            InitializeComponent();
        }

        private void NumericUpDownCantidadArticulo_ValueChanged(object sender, EventArgs e)
        {
            string articuloingresado = textBoxArticuloIngresado.Text;
            int cantArticuloingresado = Convert.ToInt32(Math.Round(numericUpDownCantidadArticulo.Value, 0));
            TiendaClase.Articulos articulos = new TiendaClase.Articulos(articuloingresado,cantArticuloingresado);
            TiendaClase tiendaClase = new TiendaClase();
            labelMostrarArticulo.Text = articulos.ToString();
        }

        private void TextBoxEspecieMascota_TextChanged(object sender, EventArgs e)
        {
            string nombreAmo = textBoxNombre.Text;
            int EdadAmo = Convert.ToInt32(Math.Round(numericUpDownEdad.Value, 0));
            string especie = textBoxEspecieMascota.Text;
            string nombreMascota = textBoxNombreMascota.Text;
            int edadMascota = Convert.ToInt32(Math.Round(numericUpDownEdadMascota.Value,0));
            string domicilio = textBoxDomicilio.Text;
            MascotayAmo.Amo amo = new MascotayAmo.Amo(nombreAmo,EdadAmo,domicilio);
            MascotayAmo.Amo.Mascota mascota = new MascotayAmo.Amo.Mascota(nombreMascota,especie,edadMascota);


            labelMostrarAmoyMascota.Text = amo.ToString() + " " + mascota.ToString();


        }

      

        private void Capitulo9_Load(object sender, EventArgs e)
        {
            labelNeumaticos.Text = EnumeraciontipodeNeumaticos.imprimir();
        }
    }
}
