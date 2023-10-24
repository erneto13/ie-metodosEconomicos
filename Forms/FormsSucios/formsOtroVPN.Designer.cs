namespace IE_MetodosEconomicos.Forms.FormsSucios
{
    partial class formsOtroVPN
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
            btnCrearFE = new Button();
            groupBox2 = new GroupBox();
            panelFE = new Panel();
            button1 = new Button();
            groupBox1 = new GroupBox();
            txtFE = new TextBox();
            label2 = new Label();
            txtTasaDescuento = new TextBox();
            labelTasaD = new Label();
            txtInversionInicial = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrearFE
            // 
            btnCrearFE.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearFE.Location = new Point(10, 170);
            btnCrearFE.Name = "btnCrearFE";
            btnCrearFE.Size = new Size(240, 39);
            btnCrearFE.TabIndex = 17;
            btnCrearFE.Text = "Crear F.E";
            btnCrearFE.UseVisualStyleBackColor = true;
            btnCrearFE.Click += btnCrearFE_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelFE);
            groupBox2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(297, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(231, 152);
            groupBox2.TabIndex = 16;
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
            // button1
            // 
            button1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(256, 170);
            button1.Name = "button1";
            button1.Size = new Size(266, 39);
            button1.TabIndex = 15;
            button1.Text = "Calcular V.P.N";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 154);
            groupBox1.TabIndex = 14;
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
            // formsOtroVPN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 232);
            Controls.Add(btnCrearFE);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "formsOtroVPN";
            Text = "A.M.E | Calcular VPN Rápido";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearFE;
        private GroupBox groupBox2;
        private Panel panelFE;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox txtFE;
        private Label label2;
        private TextBox txtTasaDescuento;
        private Label labelTasaD;
        private TextBox txtInversionInicial;
        private Label label1;
    }
}