using OpenAI.Managers;
using OpenAI;
using OpenAI_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
        } // Llave de fin del evento clic al boton de generar los F.E

        // Función para cargar los F.E a la lista
        public void cargarFE()
        {
            String cadenaII = txtInversionInicial.Text;
            if (double.TryParse(cadenaII, out double valorIIdouble))
            {
                inversionInicial = valorIIdouble;
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
            // Llamar a la función de cargar los flujos de efectivo
            cargarFE();

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
                int rowCount = 1; // Número de filas, sea 1 
                for (int row = 0; row < rowCount; row++)
                {
                    DataGridViewRow dataRow = new DataGridViewRow();

                    // Agregar el valor de inversión inicial en la primera celda
                    DataGridViewCell inversionInicialCell = new DataGridViewTextBoxCell();
                    inversionInicialCell.Value = inversionInicial.ToString("N2"); // Aquí se establece el formato a 2 decimales
                    dataRow.Cells.Add(inversionInicialCell);

                    // Agregar los valores de los flujos de efectivo en las celdas siguientes
                    for (int i = 0; i < flujosEfectivoList.Count; i++)
                    {
                        DataGridViewCell flujoCell = new DataGridViewTextBoxCell();
                        flujoCell.Value = flujosEfectivoList[i].ToString("N2"); // Aquí se establece el formato a 2 decimales
                        dataRow.Cells.Add(flujoCell);
                    }

                    datagvTabla.Rows.Add(dataRow);
                }


                // Agrego la tercera fila a la tabla
                DataGridViewRow terceraFila = new DataGridViewRow();
                for (int i = 0; i < datagvTabla.Columns.Count; i++)
                {
                    DataGridViewCell inversionInicial3 = new DataGridViewTextBoxCell();
                    inversionInicial3.Value = string.Empty;
                    terceraFila.Cells.Add(inversionInicial3);
                }
                datagvTabla.Rows.Add(terceraFila);


            }
            else
            {
                MessageBox.Show("La lista de flujos de efectivo está vacía o no contiene datos válidos.");
            }
            CalcularSegundaFila();
            CalcularTerceraFila();
            CalcularA_B_C_D();
        }

        private void CalcularSegundaFila()
        {
            // Verificar que la tabla tenga al menos una fila y al menos una columna
            if (datagvTabla.Rows.Count > 0 && datagvTabla.Columns.Count > 0)
            {
                // Obtener la inversión inicial de la primera celda
                double inversionInicial = Convert.ToDouble(datagvTabla.Rows[0].Cells[0].Value);

                // Establecer el valor de la celda "Año 0" en la segunda fila
                datagvTabla.Rows[1].Cells[0].Value = inversionInicial *= -1;

                // Calcular la segunda fila (Año 1 en adelante)
                for (int i = 1; i < datagvTabla.Columns.Count; i++)
                {
                    double flujoActual = Convert.ToDouble(datagvTabla.Rows[0].Cells[i].Value);
                    double resultado = inversionInicial + flujoActual;
                    datagvTabla.Rows[1].Cells[i].Value = resultado;

                    // Actualizar la inversión inicial para el próximo cálculo
                    inversionInicial = resultado;
                }
            }
            else
            {
                MessageBox.Show("La tabla está vacía o no contiene columnas.");
            }

        }

        private void CalcularTerceraFila()
        {
            // Verificar que la tabla tenga al menos dos filas y al menos una columna
            if (datagvTabla.Rows.Count >= 0 && datagvTabla.Columns.Count > 0)
            {
                // Obtener la inversión inicial de la primera celda
                double inversionInicial = 0;

                // Establecer el valor de la celda "Año 0" en la tercera fila
                datagvTabla.Rows[2].Cells[0].Value = 0;

                // Calcular la tercera fila (Año 1 en adelante)
                for (int i = 1; i < datagvTabla.Columns.Count; i++)
                {
                    double flujoActual = Convert.ToDouble(datagvTabla.Rows[0].Cells[i].Value);
                    double resultado = inversionInicial + flujoActual;
                    datagvTabla.Rows[2].Cells[i].Value = resultado;

                    // Actualizar la inversión inicial para el próximo cálculo
                    inversionInicial = resultado;
                }
            }
            else
            {
                MessageBox.Show("La tabla debe tener al menos dos filas y al menos una columna.");
            }
        }

        private async void CalcularA_B_C_D()
        {
            // Obtener el año anterior inmediato al que se recupera la inversión (a)
            double a = 0;
            for (int i = 1; i < datagvTabla.Columns.Count; i++)
            {
                double flujoActual = Convert.ToDouble(datagvTabla.Rows[1].Cells[i].Value);
                if (flujoActual >= 0)
                {
                    a = i;
                    break;
                }
            }

            // Obtener la inversión inicial del negocio (b)
            double b = inversionInicial;

            // Obtener el flujo de efectivo acumulado del año anterior inmediato al que se recupera la inversión (c)
            double c = 0;
            if (a > 1)
            {
                c = Convert.ToDouble(datagvTabla.Rows[2].Cells[Convert.ToInt32(a) - 1].Value);
            }

            // Obtener el flujo de efectivo del año exacto en el que se recupera la inversión (d)
            double d = 0;
            if (a > 0)
            {
                d = Convert.ToDouble(datagvTabla.Rows[0].Cells[Convert.ToInt32(a)].Value);
            }

            // Le resto 1 al valor de "a" por que jala en otras cosas
            // y en el que debería jalar sin problemas no jala y por eso le bajamos 1 punto
            double aFinal = a - 1;
            // Formula anti-corrupción
            double finalBoss = aFinal + (b - c) / d;

            // Separar la parte entera de la parte decimal
            int parteEntera = (int)finalBoss;
            double parteDecimal = finalBoss - parteEntera;

            // Calcular años, meses, días, horas, minutos y segundos
            int anos = parteEntera;
            int meses = (int)(parteDecimal * 12);
            double restoMeses = (parteDecimal * 12) - meses;
            int dias = (int)(restoMeses * 30.44);
            double restoDias = (restoMeses * 30.44) - dias;
            int horas = (int)(restoDias * 24);
            double restoHoras = (restoDias * 24) - horas;
            int minutos = (int)(restoHoras * 60);
            int segundos = (int)((restoHoras * 60 - minutos) * 60);

            // Mostrar el resultado ya final
            MessageBox.Show($"{anos} años, {meses} meses, {dias} días, {horas} horas, {minutos} minutos, {segundos} segundos");

        }

        private void datagvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
