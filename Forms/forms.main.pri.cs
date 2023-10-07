using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE_MetodosEconomicos.Forms
{
    public partial class formPRI : Form
    {
        public formPRI()
        {
            InitializeComponent();
        }

        private void formPRI_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Actualizar el estado del formulario en el main
            Form1 formMain = Application.OpenForms["formMain"] as Form1;
            if (formMain != null)
            {
                formMain.verificarDFormulario = false;
            }
        }

        // Una variable tipo lista donde se almacenana los valores de los F.E
        // Una variable tipo double donde se almacena el valor de la I.I
        private List<double> flujosEfectivoList = new List<double>();
        private double inversionInicial = 0.0;

        // Evento para crear los F.E Dinámicos
        private void btnCrearFE_Click(object sender, EventArgs e)
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
                    txt.Left = 100;
                    txt.Height = 25;

                    panelFE.Controls.Add(lbl);
                    panelFE.Controls.Add(txt);

                    /*
                     * Se ajusta la posición iniciar y la  
                     * separación para cada Label y TextBox de los FE
                    */
                    posicionInicial += separacion;
                }

            } // Llave de fin del evento clic al boton de generar los F.E
        }

        // Evento donde se cargan los F.E en la lista
        private void btnGuardarFE_Click_1(object sender, EventArgs e)
        {
            String cadenaII = txtInversionInicial.Text;
            if (double.TryParse(cadenaII, out double valorIIdouble))
            {
                inversionInicial = valorIIdouble *= -1;
            }
            else
            {
                //aca un messagebox pero al rato lo pongo voy a comer;
            }

            // Lee los valores de los TextBox y los almacena en una lista
            foreach (Control control in panelFE.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (double.TryParse(textBox.Text, out double flujo))
                    {
                        MessageBox.Show("Error");
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

        // Evento donde se toman los valores de los F.E y los coloca en la tabla
        private void btnfPRI_Click(object sender, EventArgs e)
        {
            if (flujosEfectivoList.Count > 0)
            {
                // Limpiar las columnas y flas existentes en el DataGridView
                datagvTabla.Columns.Clear();
                datagvTabla.Rows.Clear();

                // Agregar la columna de inversión inicial
                DataGridViewColumn inversionInicialColumn = new DataGridViewTextBoxColumn();
                inversionInicialColumn.HeaderText = "Año 0";
                datagvTabla.Columns.Add(inversionInicialColumn);

                // Agregar columnas para los flujos de efectivo
                for (int i = 0; i < flujosEfectivoList.Count; i++)
                {
                    DataGridViewColumn flujoColumn = new DataGridViewTextBoxColumn();
                    flujoColumn.HeaderText = $"Año {i + 1}";
                    datagvTabla.Columns.Add(flujoColumn);
                }

                // Agregar filas para los datos
                int rowCount = 1; // Número de filas, asumiendo 1 por defecto
                for (int row = 0; row < rowCount; row++)
                {
                    DataGridViewRow dataRow = new DataGridViewRow();

                    // Agregar el valor de inversión inicial en la primera celda
                    DataGridViewCell inversionInicialCell = new DataGridViewTextBoxCell();
                    inversionInicialCell.Value = inversionInicial;
                    dataRow.Cells.Add(inversionInicialCell);

                    // Agregar los valores de los flujos de efectivo en las celdas siguientes
                    for (int i = 0; i < flujosEfectivoList.Count; i++)
                    {
                        DataGridViewCell flujoCell = new DataGridViewTextBoxCell();
                        flujoCell.Value = flujosEfectivoList[i];
                        dataRow.Cells.Add(flujoCell);
                    }

                    datagvTabla.Rows.Add(dataRow);
                }

            }
            else
            {
                MessageBox.Show("La lista de flujos de efectivo está vacía o no contiene datos válidos.");
            }


            /* Método para hacer el proceso de la segunda fila que es
             * restar la inversión inicial con el flujo de efectivo de
             * la columna n
           */


        }
    }
}
