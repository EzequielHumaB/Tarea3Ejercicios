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
    public partial class PoligonoForm : Form
    {
        ClasePoligono poligono;
        public PoligonoForm()
        {
            InitializeComponent();
        }

        private void ButtonArea_Click(object sender, EventArgs e)
        {
            int lado = Convert.ToInt32(Math.Round(numericUpDownLadoIngresado.Value, 0));
            poligono = new ClasePoligono(lado);
            labelArea.Text = "Area: " + poligono.CalcularArea(lado).ToString();
        }

        private void ButtonVolumen_Click(object sender, EventArgs e)
        {
            int lado = Convert.ToInt32(Math.Round(numericUpDownLadoIngresado.Value));
            poligono = new ClasePoligono(lado);
            labelVolumen.Text = "Volumen: " + poligono.CalcularVolumen(lado).ToString();
        }
    }
}
