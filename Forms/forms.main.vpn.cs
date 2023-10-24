using IE_MetodosEconomicos.Forms.FormsSucios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IE_MetodosEconomicos.Forms
{
    public partial class formVPN : Form
    {
        public formVPN()
        {
            InitializeComponent();

            labelTasaD.Cursor = Cursors.Hand;
            ToolTip ayuda = new ToolTip();
            ayuda.IsBalloon = true;
            ayuda.SetToolTip(labelTasaD, "Para la tasa se deben utilizar entradas \ncomo decimales (0.10).");
        }

        private void formVPN_Load(object sender, EventArgs e)
        {

        }
        private void irAlRepositorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/erneto13/ie-metodosEconomicos",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        // Evento para calcular el VPN
        private void button1_Click(object sender, EventArgs e)
        {
            cargarFlujosEfectivoLista();
            if (validarDatos())
            {

                // Obtener la tasa de descuento ingresada
                if (double.TryParse(txtTasaDescuento.Text, out double tasaDescuento))
                {
                    double vpn = CalcularVPN(tasaDescuento);

                    epMarcarError.Clear();
                    MessageBox.Show($"El Valor Presente Neto (VPN) es: {vpn:C}");


                    // Instancias globales de los "FormsSucios" para solo llamar y no volver a instanciar
                    formVPNIgual formIgual = new formVPNIgual();
                    formVPNPositivo formPositivo = new formVPNPositivo();
                    formVPNNegativo formNegativo = new formVPNNegativo();


                    if (vpn > 0)
                    {
                        formPositivo.Show();

                        // Proceso de pregunta para calcular el V.A.E
                        DialogResult dialogResult = MessageBox.Show("Puede calcular el Valor Anual Equivalente (V.A.E) con los datos obtenidos, ¿desea continua?", "A.M.E | Calcular el VAE", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            formPositivo.Hide();

                            // Formúla
                            /*
                             * V.A.E = vpn * tasa  -- #1
                             *        ------------
                             *        (1-(        1 -- #2
                             *            -----------------))
                             *            (1+tasa)#periodos
                             * 
                            */


                            double primeraParte = vpn * tasaDescuento;
                            double potencia = flujosEfectivoList.Count;
                            double segundaParte = (1 - (1 / Math.Pow((1 + tasaDescuento), potencia)));
                            double vae = primeraParte / segundaParte;

                            MessageBox.Show($"El Valor Anual Equivalente (V.A.E) es: {vae:C}");

                            // Sentencias por si el VAE es rentable o no tambor
                            if (vae > 0)
                            {
                                formPositivo.Show();
                            }
                            else if (vae < 0)
                            {
                                formNegativo.Show();
                            }
                            else if (vae == 0)
                            {
                                formIgual.Show();
                            }
                            else
                            {
                                //ok, chaval
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //no hago nada, hola
                        }


                    }
                    else if (vpn < 0)
                    {
                        formNegativo.Show();

                        // Proceso de pregunta para calcular el V.A.E
                        DialogResult dialogResult = MessageBox.Show("Puede calcular el Valor Anual Equivalente (V.A.E) con los datos obtenidos, ¿desea continua?", "¿Calcular el V.A.E?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            formNegativo.Hide();

                            // Formúla
                            /*
                             * V.A.E = vpn * tasa  -- #1
                             *        ------------
                             *        (1-(        1 -- #2
                             *            -----------------))
                             *            (1+tasa)#periodos
                             * 
                            */


                            double primeraParte = vpn * tasaDescuento;
                            double potencia = flujosEfectivoList.Count;
                            double segundaParte = (1 - (1 / Math.Pow((1 + tasaDescuento), potencia)));
                            double vae = primeraParte / segundaParte;

                            MessageBox.Show($"El Valor Anual Equivalente (V.A.E) es: {vae:C}");

                            // Sentencias por si el VAE es rentable o no tambor
                            if (vae > 0)
                            {
                                formPositivo.Show();
                            }
                            else if (vae < 0)
                            {
                                formNegativo.Show();
                            }
                            else if (vae == 0)
                            {
                                formIgual.Show();
                            }
                            else
                            {
                                //ok, chaval
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //no hago nada, hola
                        }

                    }
                    else
                    {
                        formIgual.Show();

                        // Proceso de pregunta para calcular el V.A.E
                        DialogResult dialogResult = MessageBox.Show("Puede calcular el Valor Anual Equivalente (V.A.E) con los datos obtenidos, ¿desea continua?", "¿Calcular el V.A.E?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            formIgual.Hide();

                            // Formúla
                            /*
                             * V.A.E = vpn * tasa  -- #1
                             *        ------------
                             *        (1-(        1 -- #2
                             *            -----------------))
                             *            (1+tasa)#periodos
                             * 
                            */


                            double primeraParte = vpn * tasaDescuento;
                            double potencia = flujosEfectivoList.Count;
                            double segundaParte = (1 - (1 / Math.Pow((1 + tasaDescuento), potencia)));
                            double vae = primeraParte / segundaParte;

                            MessageBox.Show($"El Valor Anual Equivalente (V.A.E) es: {vae:C}");
                            // Sentencias por si el VAE es rentable o no tambor
                            if (vae > 0)
                            {
                                formPositivo.Show();
                            } else if (vae < 0)
                            {
                                formNegativo.Show();
                            } else if (vae == 0)
                            {
                                formIgual.Show();
                            }
                            else
                            {
                                //ok, chaval
                            }

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //no hago nada, hola
                        }
                    }
                }
                else
                {
                    epMarcarError.Clear();
                    epMarcarError.SetError(txtTasaDescuento, "Tipo de dato inválido para la tasa de descuento");
                }
            }
        }

        // Función para validar los tipos de datos ingresados a los TextBox **opcional
        public bool validarDatos()
        {
            bool noError = true;
            if (string.IsNullOrWhiteSpace(txtInversionInicial.Text))
            {
                epMarcarError.SetError(txtInversionInicial, "Ingrese datos numéricos");
                noError = false;
            }
            else
            {
                if (!double.TryParse(txtTasaDescuento.Text, out double tasaDescuento))
                {
                    epMarcarError.Clear();
                    epMarcarError.SetError(txtTasaDescuento, "Tipo de dato inválido");
                    return false;
                }
            }
            return noError;
        }


        /*        
          ______                _                       
         |  ____|              (_)                      
         | |__ _   _ _ __   ___ _  ___  _ __   ___  ___ 
         |  __| | | | '_ \ / __| |/ _ \| '_ \ / _ \/ __|
         | |  | |_| | | | | (__| | (_) | | | |  __/\__ \
         |_|   \__,_|_| |_|\___|_|\___/|_| |_|\___||___/

        */

        // Lista para los flujos de efectivo dinámicos
        private List<double> flujosEfectivoList = new List<double>();
        // Variable double para la inversión inicial
        private double inversionInicial = 0.0;

        // Función para crear los flujos de efectivo dinámicos
        public void flujosEfectivoDinamicos()
        {
            if (int.TryParse(txtFE.Text, out int cantidadFlujos) && cantidadFlujos > 0)
            {
                panelFE.Controls.Clear();
                panelFE.AutoScroll = true;
                panelFE.AutoScrollMinSize = new Size(0, 100);

                int separacion = 30;
                int posicionInicial = 0;

                for (int i = 0; i < cantidadFlujos; i++)
                {
                    Label lbl = new Label();
                    lbl.Text = $"Flujo {i + 1}:";
                    lbl.Top = 20 + (i * 30);
                    lbl.Left = 10;

                    TextBox txt = new TextBox();
                    txt.Name = $"txtFlujo{i + 1}";
                    txt.Top = 20 + (i * 30);
                    txt.Left = 110;
                    txt.Height = 25;

                    panelFE.Controls.Add(lbl);
                    panelFE.Controls.Add(txt);

                    posicionInicial += separacion;
                }
            }
            else
            {
                MessageBox.Show("Ingresa un número de flujos de efectivo válido.");
            }
        }

        // Función para cargar los flujos de efectivo a la lista
        public void cargarFlujosEfectivoLista()
        {
            if (double.TryParse(txtInversionInicial.Text, out double valorIIdouble))
            {
                inversionInicial = valorIIdouble;
            }
            else
            {
                // Luego pongo otro coso acá
            }

            foreach (Control control in panelFE.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (double.TryParse(textBox.Text, out double flujo))
                    {
                        flujosEfectivoList.Add(flujo);
                    }
                    else
                    {
                        // hola
                        return;
                    }
                }
            }
        }

        // Función para calcular el Valor Presente Neto
        public double CalcularVPN(double tasaDescuento)
        {
            double vpn = -inversionInicial; // Se hace negativo

            for (int i = 0; i < flujosEfectivoList.Count; i++)
            {
                // Formúla:
                /*
                 * VPN = I.I +- Z F.E/(1+tasa)#periodo 
                */
                double flujo = flujosEfectivoList[i];
                vpn += flujo / Math.Pow(1 + tasaDescuento, i + 1);
            }

            return vpn;
        }

        // Función para crear los flujos de efectivo dinámicos
        private void btnCrearFE_Click(object sender, EventArgs e)
        {
            flujosEfectivoDinamicos();
        }
    }
}
