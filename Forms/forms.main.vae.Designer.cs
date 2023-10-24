namespace IE_MetodosEconomicos.Forms
{
    partial class formVAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVAE));
            menuStrip1 = new MenuStrip();
            documentaciónToolStripMenuItem = new ToolStripMenuItem();
            irAlRepositorioToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            txtFE = new TextBox();
            label2 = new Label();
            txtTasaDescuento = new TextBox();
            labelTasaD = new Label();
            txtInversionInicial = new TextBox();
            label1 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { documentaciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(462, 30);
            menuStrip1.TabIndex = 0;
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
            irAlRepositorioToolStripMenuItem.Size = new Size(180, 26);
            irAlRepositorioToolStripMenuItem.Text = "Ir al repositorio";
            irAlRepositorioToolStripMenuItem.Click += irAlRepositorioToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(327, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 60);
            label4.Name = "label4";
            label4.Size = new Size(265, 30);
            label4.TabIndex = 20;
            label4.Text = "Este programa te permite determinar si invertir \r\nen un proyecto es rentable a lo largo del tiempo. ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 31);
            label3.Name = "label3";
            label3.Size = new Size(242, 34);
            label3.TabIndex = 19;
            label3.Text = "Valor Anual Equivalente";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.ForeColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(-3, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 2);
            panel1.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtFE);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTasaDescuento);
            groupBox1.Controls.Add(labelTasaD);
            groupBox1.Controls.Add(txtInversionInicial);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 154);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Indica los siguientes datos";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(218, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtFE
            // 
            txtFE.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFE.Location = new Point(136, 96);
            txtFE.Name = "txtFE";
            txtFE.Size = new Size(64, 25);
            txtFE.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 96);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 15;
            label2.Text = "Periodo de tiempo:";
            // 
            // txtTasaDescuento
            // 
            txtTasaDescuento.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTasaDescuento.Location = new Point(146, 62);
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
            txtInversionInicial.Location = new Point(148, 31);
            txtInversionInicial.Name = "txtInversionInicial";
            txtInversionInicial.Size = new Size(64, 25);
            txtInversionInicial.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(127, 22);
            label1.TabIndex = 0;
            label1.Text = "Valor Presente Neto:";
            // 
            // button1
            // 
            button1.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(293, 127);
            button1.Name = "button1";
            button1.Size = new Size(157, 146);
            button1.TabIndex = 23;
            button1.Text = "Calcular V.A.E";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formVAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 298);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "formVAE";
            Text = "A.M.E | Método VAE";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem documentaciónToolStripMenuItem;
        private ToolStripMenuItem irAlRepositorioToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtFE;
        private Label label2;
        private TextBox txtTasaDescuento;
        private Label labelTasaD;
        private TextBox txtInversionInicial;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
    }
}