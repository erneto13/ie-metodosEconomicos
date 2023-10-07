using IE_MetodosEconomicos.Forms;
using System;
using System.Drawing.Text;
using System.Media;
using System.Windows.Forms;

namespace IE_MetodosEconomicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool verificarDFormulario = false;

        private void btnEntrarPRI_Click(object sender, EventArgs e)
        {

            if (!verificarDFormulario)
            {
                //Creamos la instancia del formulario de P.R.I
                formPRI formularioPRI = new formPRI();

                // Mostramos el formulario de P.R.I
                formularioPRI.Show();

                // Actualizamos el estado del formulario
                verificarDFormulario = true;
            } 
            else
            {
                // Mostrar mensaje de error
                mensajeError();
            }
        }

        public void mensajeError()
        {
            MessageBox.Show("Esta ventana ya se encuentra actvida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}