namespace IE_MetodosEconomicos.Forms
{
    partial class formTIR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTIR));
            menuStrip1 = new MenuStrip();
            documentaciónToolStripMenuItem = new ToolStripMenuItem();
            irAlRepositorioToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            txtFE = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            panelFE = new Panel();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
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
            menuStrip1.Size = new Size(359, 30);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 50);
            label4.Name = "label4";
            label4.Size = new Size(345, 60);
            label4.TabIndex = 24;
            label4.Text = "Dentro de este programa se realizará el proceso para determinar \r\nsi el invertir en un proyecto sea rentable para uno, calculará si \r\nhabrá una margen de utilidad y si es factible o el proyecto\r\n.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 25);
            label3.Name = "label3";
            label3.Size = new Size(291, 34);
            label3.TabIndex = 23;
            label3.Text = "Tasa Interna de Rendimiento";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.ForeColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(-3, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 2);
            panel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFE);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 61);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Indica los siguientes datos";
            // 
            // txtFE
            // 
            txtFE.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFE.Location = new Point(133, 21);
            txtFE.Name = "txtFE";
            txtFE.Size = new Size(64, 25);
            txtFE.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 21);
            label2.Name = "label2";
            label2.Size = new Size(115, 22);
            label2.TabIndex = 15;
            label2.Text = "Flujos de efectivo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelFE);
            groupBox2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 153);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Flujos de efectivo";
            // 
            // panelFE
            // 
            panelFE.Location = new Point(7, 25);
            panelFE.Name = "panelFE";
            panelFE.Size = new Size(322, 122);
            panelFE.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 347);
            button1.Name = "button1";
            button1.Size = new Size(108, 32);
            button1.TabIndex = 28;
            button1.Text = "Crear F.E";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(231, 350);
            button2.Name = "button2";
            button2.Size = new Size(110, 29);
            button2.TabIndex = 29;
            button2.Text = "Calcular T.I.R";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(241, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // formTIR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 398);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "formTIR";
            Text = "A.M.E | Método de la TIR";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Label label4;
        private Label label3;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtFE;
        private Label label2;
        private GroupBox groupBox2;
        private Panel panelFE;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}