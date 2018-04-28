using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos_por_tortuga
{
    public partial class Form1 : Form
    {
        Tortuga Tablero = new Tortuga();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            Tablero._pluma1 = -1;
        }

        private void btnArriva_Click(object sender, EventArgs e)
        {
            Tablero._pluma1 = 1;
        }

        private void btnGiraDerecha_Click(object sender, EventArgs e)
        {
            Tablero.GirarDerecha();
        }

        private void btnGiraIzquierda_Click(object sender, EventArgs e)
        {
            Tablero.GirarIzquierda();
        }

        private void btnAvanza_Click(object sender, EventArgs e)
        {
            Tablero.Avanza(Convert.ToInt32(txtAvanzar.Text));
        }

        private void btnMostrarArreglo_Click(object sender, EventArgs e)
        {
            txtTablero.Clear();
            Tablero.Imprime();
            txtTablero.Text = Tablero.ToString();
        }
    }
}
