namespace IE_MetodosEconomicos.Forms
{
    partial class formPRI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPRI));
            menuStrip1 = new MenuStrip();
            documentaciónToolStripMenuItem = new ToolStripMenuItem();
            irAlRepositorioToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            txtInversionInicial = new TextBox();
            label5 = new Label();
            txtFE = new TextBox();
            panelFE = new Panel();
            btnCrearFE = new Button();
            datagvTabla = new DataGridView();
            btnfPRI = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagvTabla).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { documentaciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(529, 30);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(400, 34);
            label1.TabIndex = 3;
            label1.Text = "Periodo de Recuperación de la Inversión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(394, 30);
            label2.TabIndex = 4;
            label2.Text = "Dentro de este programa se realizará el tiempo que tarda una empresa en \r\nrecuperar el importe original invertido en un proyecto.\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.ForeColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(0, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 2);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 22);
            label4.Name = "label4";
            label4.Size = new Size(105, 22);
            label4.TabIndex = 10;
            label4.Text = "Inversión Inicial:";
            // 
            // txtInversionInicial
            // 
            txtInversionInicial.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtInversionInicial.Location = new Point(117, 22);
            txtInversionInicial.Name = "txtInversionInicial";
            txtInversionInicial.Size = new Size(64, 25);
            txtInversionInicial.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 61);
            label5.Name = "label5";
            label5.Size = new Size(115, 22);
            label5.TabIndex = 12;
            label5.Text = "Flujos de efectivo:";
            // 
            // txtFE
            // 
            txtFE.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFE.Location = new Point(127, 58);
            txtFE.Name = "txtFE";
            txtFE.Size = new Size(64, 25);
            txtFE.TabIndex = 13;
            // 
            // panelFE
            // 
            panelFE.Location = new Point(7, 24);
            panelFE.Name = "panelFE";
            panelFE.Size = new Size(248, 121);
            panelFE.TabIndex = 14;
            // 
            // btnCrearFE
            // 
            btnCrearFE.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearFE.Location = new Point(291, 259);
            btnCrearFE.Name = "btnCrearFE";
            btnCrearFE.Size = new Size(225, 67);
            btnCrearFE.TabIndex = 15;
            btnCrearFE.Text = "Crear FE";
            btnCrearFE.UseVisualStyleBackColor = true;
            btnCrearFE.Click += btnCrearFE_Click;
            // 
            // datagvTabla
            // 
            datagvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagvTabla.Location = new Point(243, 121);
            datagvTabla.Name = "datagvTabla";
            datagvTabla.ReadOnly = true;
            datagvTabla.RowTemplate.Height = 25;
            datagvTabla.Size = new Size(273, 120);
            datagvTabla.TabIndex = 17;
            datagvTabla.CellContentClick += datagvTabla_CellContentClick;
            // 
            // btnfPRI
            // 
            btnfPRI.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnfPRI.Location = new Point(291, 332);
            btnfPRI.Name = "btnfPRI";
            btnfPRI.Size = new Size(225, 66);
            btnfPRI.TabIndex = 19;
            btnfPRI.Text = "Calcular P.R.I";
            btnfPRI.UseVisualStyleBackColor = true;
            btnfPRI.Click += btnfPRI_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtInversionInicial);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFE);
            groupBox1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(15, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 101);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Indica los siguiente datos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelFE);
            groupBox2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 151);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Flujos de efectivo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descarga;
            pictureBox1.Location = new Point(416, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // formPRI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 416);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnfPRI);
            Controls.Add(datagvTabla);
            Controls.Add(btnCrearFE);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "formPRI";
            Text = "A.M.E | Método PRI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagvTabla).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem documentaciónToolStripMenuItem;
        private ToolStripMenuItem irAlRepositorioToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private TextBox txtInversionInicial;
        private Label label5;
        private TextBox txtFE;
        private Panel panelFE;
        private Button btnCrearFE;
        private DataGridView datagvTabla;
        private Button btnfPRI;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
    }
}