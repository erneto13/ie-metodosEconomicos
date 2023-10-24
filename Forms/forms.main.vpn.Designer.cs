namespace IE_MetodosEconomicos.Forms
{
    partial class formVPN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVPN));
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            documentaciónToolStripMenuItem = new ToolStripMenuItem();
            irAlRepositorioToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            txtFE = new TextBox();
            label2 = new Label();
            txtTasaDescuento = new TextBox();
            labelTasaD = new Label();
            txtInversionInicial = new TextBox();
            label1 = new Label();
            epMarcarError = new ErrorProvider(components);
            button1 = new Button();
            groupBox2 = new GroupBox();
            panelFE = new Panel();
            btnCrearFE = new Button();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epMarcarError).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { documentaciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(539, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // documentaciónToolStripMenuItem
            // 
            documentaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { irAlRepositorioToolStripMenuItem });
            documentaciónToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentaciónToolStripMenuItem.Name = "documentaciónToolStripMenuItem";
            documentaciónToolStripMenuItem.Size = new Size(118, 26);
            documentaciónToolStripMenuItem.Text = "Documentación";
            // 
            // irAlRepositorioToolStripMenuItem
            // 
            irAlRepositorioToolStripMenuItem.Name = "irAlRepositorioToolStripMenuItem";
            irAlRepositorioToolStripMenuItem.Size = new Size(167, 26);
            irAlRepositorioToolStripMenuItem.Text = "Ir al repositorio";
            irAlRepositorioToolStripMenuItem.Click += irAlRepositorioToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.ForeColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(0, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 2);
            panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFE);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTasaDescuento);
            groupBox1.Controls.Add(labelTasaD);
            groupBox1.Controls.Add(txtInversionInicial);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(15, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 154);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Indica los siguientes datos";
            // 
            // txtFE
            // 
            txtFE.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFE.Location = new Point(136, 93);
            txtFE.Name = "txtFE";
            txtFE.Size = new Size(64, 25);
            txtFE.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 96);
            label2.Name = "label2";
            label2.Size = new Size(115, 22);
            label2.TabIndex = 15;
            label2.Text = "Flujos de efectivo:";
            // 
            // txtTasaDescuento
            // 
            txtTasaDescuento.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTasaDescuento.Location = new Point(146, 59);
            txtTasaDescuento.Name = "txtTasaDescuento";
            txtTasaDescuento.Size = new Size(64, 25);
            txtTasaDescuento.TabIndex = 14;
            // 
            // labelTasaD
            // 
            labelTasaD.AutoSize = true;
            labelTasaD.Location = new Point(15, 62);
            labelTasaD.Name = "labelTasaD";
            labelTasaD.Size = new Size(125, 22);
            labelTasaD.TabIndex = 13;
            labelTasaD.Text = "Tasa de descuento:";
            // 
            // txtInversionInicial
            // 
            txtInversionInicial.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtInversionInicial.Location = new Point(126, 28);
            txtInversionInicial.Name = "txtInversionInicial";
            txtInversionInicial.Size = new Size(64, 25);
            txtInversionInicial.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(105, 22);
            label1.TabIndex = 0;
            label1.Text = "Inversión inicial:";
            // 
            // epMarcarError
            // 
            epMarcarError.ContainerControl = this;
            // 
            // button1
            // 
            button1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(259, 292);
            button1.Name = "button1";
            button1.Size = new Size(266, 39);
            button1.TabIndex = 11;
            button1.Text = "Calcular V.P.N";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelFE);
            groupBox2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(300, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(231, 152);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Flujos de efectivo";
            // 
            // panelFE
            // 
            panelFE.Location = new Point(7, 20);
            panelFE.Name = "panelFE";
            panelFE.Size = new Size(218, 126);
            panelFE.TabIndex = 0;
            // 
            // btnCrearFE
            // 
            btnCrearFE.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearFE.Location = new Point(13, 292);
            btnCrearFE.Name = "btnCrearFE";
            btnCrearFE.Size = new Size(240, 39);
            btnCrearFE.TabIndex = 13;
            btnCrearFE.Text = "Crear F.E";
            btnCrearFE.UseVisualStyleBackColor = true;
            btnCrearFE.Click += btnCrearFE_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 30);
            label3.Name = "label3";
            label3.Size = new Size(202, 34);
            label3.TabIndex = 15;
            label3.Text = "Valor Presente Neto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 55);
            label4.Name = "label4";
            label4.Size = new Size(345, 60);
            label4.TabIndex = 16;
            label4.Text = "Dentro de este programa se realizará el proceso para determinar \r\nsi el invertir en un proyecto sea rentable para uno, calculará si \r\nhabrá una margen de utilidad y si es factible o el proyecto.\r\n.\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.risita;
            pictureBox1.Location = new Point(366, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // formVPN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 339);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCrearFE);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "formVPN";
            Text = "A.M.E | Método VPN";
            Load += formVPN_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epMarcarError).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem documentaciónToolStripMenuItem;
        private ToolStripMenuItem irAlRepositorioToolStripMenuItem;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtTasaDescuento;
        private Label labelTasaD;
        private TextBox txtInversionInicial;
        private ErrorProvider epMarcarError;
        private Button button1;
        private TextBox txtFE;
        private Label label2;
        private GroupBox groupBox2;
        private Panel panelFE;
        private Button btnCrearFE;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}