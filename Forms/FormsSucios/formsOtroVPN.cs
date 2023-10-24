using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE_MetodosEconomicos.Forms.FormsSucios
{
    public partial class formsOtroVPN : Form
    {
        public formsOtroVPN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                        MessageBox.Show("Se cargó correctamente el flujo de efectivo");
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

        // Evento para calcular el VPN
        private void button1_Click_1(object sender, EventArgs e)
        {
            cargarFlujosEfectivoLista();

            // Obtener la tasa de descuento ingresada
            if (double.TryParse(txtTasaDescuento.Text, out double tasaDescuento))
            {
                double vpn = CalcularVPN(tasaDescuento);
                string vpnString = vpn.ToString("F2");
                Clipboard.SetText(vpnString);
                MessageBox.Show($"El Valor Presente Neto (VPN) es: {vpn:C}. El valor ha sido copiado en el portapapeles.");
            }
        }
    }
}
