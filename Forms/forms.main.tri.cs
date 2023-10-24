using Microsoft.VisualBasic;
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
    public partial class formTIR : Form
    {
        public formTIR()
        {
            InitializeComponent();
        }

        // Variable global de lista para los flujos de efectivo
        public List<double> flujosEfectivoList = new List<double>();

        // Evento para crear los flujos de efectivo dinámicos
        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si se ingresó un número válido
            if (int.TryParse(txtFE.Text, out int cantidadFlujos) && cantidadFlujos > 0)
            {
                // Limpiar el panel si ya contiene controles
                panelFE.Controls.Clear();
                // Ajustes al panel para el scroll y sea dinámico
                panelFE.AutoScroll = true;
                panelFE.AutoScrollMinSize = new Size(0, 100); // Ajusta el valor en función de tu diseño

                // Variables para que los FE Dinámicos y se vean bien
                int separacion = 30; // Espacio vertical
                int posicionInicial = 0; // Posición vertical inicial
                // Crear y agregar cuadros de texto para los flujos de efectivo
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

                    /*
                     * Se ajusta la posición iniciar y la  
                     * separación para cada Label y TextBox de los FE
                    */
                    posicionInicial += separacion;
                }
            }
            else
            {
                MessageBox.Show("Ingresa un número de flujos de efectivo válido.");
            }
        }

        // Función para cargar los flujos de efectivo en los TextBox a la lista
        public void cargarFlujosEfectivo()
        {
            // Limpiar la lista para nuevos F.E
            flujosEfectivoList.Clear();

            // Lee los valores de los TextBox y los almacena en una lista
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
                        //MessageBox.Show("Ingrese flujos de efectivo válidos.");
                        return;
                    }
                }
            }
        }

        // Función para calcular la Tasa Interna de Rendimiento
        public void calcularTIR()
        {
            // Definir los flujos de efectivo en un array
            double[] cashFlows = flujosEfectivoList.ToArray();

            // Calcular la TIR
            double irr = Financial.IRR(ref cashFlows, 0.1);

            // Var para que solo aparezcan 4 cifras despúes del . ej. 4.3242%
            string tirString = irr.ToString("F4");
            MessageBox.Show("La Tasa Interna de Rendimiento (TIR) es: " + irr);

            // Calcular el porcentaje de TIR y mostrarlo con 4 cifras decimales
            double tirPorcentaje = irr * 100;
            string tirPorcentajeString = tirPorcentaje.ToString("F4");
            MessageBox.Show("Porcentaje TIR: " + tirPorcentajeString + "%");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarFlujosEfectivo();
            calcularTIR();
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
