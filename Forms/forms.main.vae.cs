using IE_MetodosEconomicos.Forms.FormsSucios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE_MetodosEconomicos.Forms
{
    public partial class formVAE : Form
    {
        public formVAE()
        {
            InitializeComponent();
        }

        public void btnCalcularVAE(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Formúla
            /*
             * V.A.E = vpn * tasa  -- #1
             *        ------------
             *        (1-(        1 -- #2
             *            -----------------))
             *            (1+tasa)#periodos
             * 
            */
            if (double.TryParse(txtTasaDescuento.Text, out double tasaDescuento))
            {
                if (double.TryParse(txtFE.Text, out double periodo))
                {

                    if (double.TryParse(txtInversionInicial.Text, out double vpn))
                    {
                        double primeraParte = vpn * tasaDescuento;
                        double potencia = periodo;
                        double segundaParte = (1 - (1 / Math.Pow((1 + tasaDescuento), potencia)));
                        double vae = primeraParte / segundaParte;

                        MessageBox.Show($"El Valor Anual Equivalente (V.A.E) es: {vae:C}");

                    }
                }
            }
        }

        public bool hola = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Puedes calcular el Valor Presente Neto (V.P.N) en otra ventana, ¿desea continua?", "A.M.E | Calcular el VPN", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                formsOtroVPN formOtroVPN = new formsOtroVPN();
                formOtroVPN.Show();
                hola = true;
            }
            else
            {
                //ok
            }
        }

        private void irAlRepositorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/erneto13",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
    }
}
