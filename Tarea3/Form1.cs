using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea3.UI.Registros;

namespace Tarea3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Capitulo9ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Capitulo9 capitulo9 = new Capitulo9();
            capitulo9.StartPosition = FormStartPosition.CenterScreen;
            capitulo9.Show();
        }

        private void InventarioTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioTienda inventario = new InventarioTienda();
            inventario.StartPosition = FormStartPosition.CenterScreen;
            inventario.Show();
        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstudianteForm estudiante = new EstudianteForm();
            estudiante.StartPosition = FormStartPosition.CenterScreen;
            estudiante.Show();
        }

        private void PoligonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoligonoForm poligono = new PoligonoForm();
            poligono.StartPosition = FormStartPosition.CenterScreen;
            poligono.Show();
        }
    }
}
