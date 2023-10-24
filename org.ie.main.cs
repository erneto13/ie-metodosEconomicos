using IE_MetodosEconomicos.Forms;
using System;
using System.Drawing.Text;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace IE_MetodosEconomicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrarPRI_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario principal
            this.Hide();

            // Crear la instancia del formulario de P.R.I
            formPRI formularioPRI = new formPRI();

            // Mostrar el formulario de P.R.I
            formularioPRI.FormClosed += (s, args) => this.Show();
            formularioPRI.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_metodoPRI_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnMetodoVPN_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario principal
            this.Hide();

            // Crear la instancia del formulario de P.R.I
            formVPN formularioVPN = new formVPN();

            // Mostrar el formulario de P.R.I
            formularioVPN.FormClosed += (s, args) => this.Show();
            formularioVPN.Show();
        }

        private void btnMetodoVAE_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario principal
            this.Hide();

            // Crear la instancia del formulario de P.R.I
            formVAE formularioVAE = new formVAE();

            // Mostrar el formulario de P.R.I
            formularioVAE.FormClosed += (s, args) => this.Show();
            formularioVAE.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario principal
            this.Hide();

            // Crear la instancia del formulario de P.R.I
            formTIR formulariuTIR = new formTIR();

            // Mostrar el formulario de T.I.R
            formulariuTIR.FormClosed += (s, args) => this.Show();
            formulariuTIR.Show();

        }
    }

}