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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.documentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAlRepositorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInversionInicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFE = new System.Windows.Forms.TextBox();
            this.panelFE = new System.Windows.Forms.Panel();
            this.btnCrearFE = new System.Windows.Forms.Button();
            this.datagvTabla = new System.Windows.Forms.DataGridView();
            this.btnGuardarFE = new System.Windows.Forms.Button();
            this.btnfPRI = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvTabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // documentaciónToolStripMenuItem
            // 
            this.documentaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irAlRepositorioToolStripMenuItem});
            this.documentaciónToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.documentaciónToolStripMenuItem.Name = "documentaciónToolStripMenuItem";
            this.documentaciónToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.documentaciónToolStripMenuItem.Text = "Documentación";
            // 
            // irAlRepositorioToolStripMenuItem
            // 
            this.irAlRepositorioToolStripMenuItem.Name = "irAlRepositorioToolStripMenuItem";
            this.irAlRepositorioToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.irAlRepositorioToolStripMenuItem.Text = "Ir al repositorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Periodo de Recuperación de la Inversión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dentro de este programa se realizará el tiempo que tarda una empresa en \r\nrecuper" +
    "ar el importe original invertido en un proyecto, cuando el flujo \r\nfijo neto es " +
    "igual a cero.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 10);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inversión Inicial:";
            // 
            // txtInversionInicial
            // 
            this.txtInversionInicial.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInversionInicial.Location = new System.Drawing.Point(117, 22);
            this.txtInversionInicial.Name = "txtInversionInicial";
            this.txtInversionInicial.Size = new System.Drawing.Size(64, 25);
            this.txtInversionInicial.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Flujos de efectivo:";
            // 
            // txtFE
            // 
            this.txtFE.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFE.Location = new System.Drawing.Point(127, 58);
            this.txtFE.Name = "txtFE";
            this.txtFE.Size = new System.Drawing.Size(64, 25);
            this.txtFE.TabIndex = 13;
            // 
            // panelFE
            // 
            this.panelFE.Location = new System.Drawing.Point(7, 24);
            this.panelFE.Name = "panelFE";
            this.panelFE.Size = new System.Drawing.Size(211, 121);
            this.panelFE.TabIndex = 14;
            // 
            // btnCrearFE
            // 
            this.btnCrearFE.Location = new System.Drawing.Point(15, 415);
            this.btnCrearFE.Name = "btnCrearFE";
            this.btnCrearFE.Size = new System.Drawing.Size(108, 23);
            this.btnCrearFE.TabIndex = 15;
            this.btnCrearFE.Text = "Crear FE";
            this.btnCrearFE.UseVisualStyleBackColor = true;
            this.btnCrearFE.Click += new System.EventHandler(this.btnCrearFE_Click);
            // 
            // datagvTabla
            // 
            this.datagvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvTabla.Location = new System.Drawing.Point(15, 290);
            this.datagvTabla.Name = "datagvTabla";
            this.datagvTabla.ReadOnly = true;
            this.datagvTabla.RowTemplate.Height = 25;
            this.datagvTabla.Size = new System.Drawing.Size(461, 120);
            this.datagvTabla.TabIndex = 17;
            // 
            // btnGuardarFE
            // 
            this.btnGuardarFE.Location = new System.Drawing.Point(129, 416);
            this.btnGuardarFE.Name = "btnGuardarFE";
            this.btnGuardarFE.Size = new System.Drawing.Size(108, 23);
            this.btnGuardarFE.TabIndex = 18;
            this.btnGuardarFE.Text = "Guardar FE";
            this.btnGuardarFE.UseVisualStyleBackColor = true;
            this.btnGuardarFE.Click += new System.EventHandler(this.btnGuardarFE_Click_1);
            // 
            // btnfPRI
            // 
            this.btnfPRI.Location = new System.Drawing.Point(251, 416);
            this.btnfPRI.Name = "btnfPRI";
            this.btnfPRI.Size = new System.Drawing.Size(108, 23);
            this.btnfPRI.TabIndex = 19;
            this.btnfPRI.Text = "Calcular P.R.I";
            this.btnfPRI.UseVisualStyleBackColor = true;
            this.btnfPRI.Click += new System.EventHandler(this.btnfPRI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtInversionInicial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFE);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(15, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 101);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indica los siguiente datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelFE);
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(252, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 151);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flujos de efectivo";
            // 
            // formPRI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnfPRI);
            this.Controls.Add(this.btnGuardarFE);
            this.Controls.Add(this.datagvTabla);
            this.Controls.Add(this.btnCrearFE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formPRI";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvTabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button btnGuardarFE;
        private Button btnfPRI;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}