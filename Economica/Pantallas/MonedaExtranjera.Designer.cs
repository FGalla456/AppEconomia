namespace Economica.Pantallas
{
    partial class MonedaExtranjera
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
            this.txtVCO1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mcViejo = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVCOI1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVVB1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVCB1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVVO1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInternet = new System.Windows.Forms.Button();
            this.mcNuevo = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVCOI2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVVB2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVCB2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVVO2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVCO2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVCO1
            // 
            this.txtVCO1.Location = new System.Drawing.Point(274, 86);
            this.txtVCO1.Name = "txtVCO1";
            this.txtVCO1.ReadOnly = true;
            this.txtVCO1.Size = new System.Drawing.Size(115, 20);
            this.txtVCO1.TabIndex = 15;
            this.txtVCO1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ultima Cotizacion Cargada";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mcViejo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtVCOI1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVVB1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtVCB1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVVO1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVCO1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 233);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // mcViejo
            // 
            this.mcViejo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mcViejo.Location = new System.Drawing.Point(9, 44);
            this.mcViejo.Name = "mcViejo";
            this.mcViejo.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor Compra Oficial con Impuesto";
            // 
            // txtVCOI1
            // 
            this.txtVCOI1.Location = new System.Drawing.Point(620, 86);
            this.txtVCOI1.Name = "txtVCOI1";
            this.txtVCOI1.ReadOnly = true;
            this.txtVCOI1.Size = new System.Drawing.Size(115, 20);
            this.txtVCOI1.TabIndex = 17;
            this.txtVCOI1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor Venta Blue";
            // 
            // txtVVB1
            // 
            this.txtVVB1.Location = new System.Drawing.Point(457, 145);
            this.txtVVB1.Name = "txtVVB1";
            this.txtVVB1.ReadOnly = true;
            this.txtVVB1.Size = new System.Drawing.Size(115, 20);
            this.txtVVB1.TabIndex = 19;
            this.txtVVB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Compra Blue";
            // 
            // txtVCB1
            // 
            this.txtVCB1.Location = new System.Drawing.Point(274, 145);
            this.txtVCB1.Name = "txtVCB1";
            this.txtVCB1.ReadOnly = true;
            this.txtVCB1.Size = new System.Drawing.Size(115, 20);
            this.txtVCB1.TabIndex = 18;
            this.txtVCB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Venta Oficial";
            // 
            // txtVVO1
            // 
            this.txtVVO1.Location = new System.Drawing.Point(457, 86);
            this.txtVVO1.Name = "txtVVO1";
            this.txtVVO1.ReadOnly = true;
            this.txtVVO1.Size = new System.Drawing.Size(115, 20);
            this.txtVVO1.TabIndex = 16;
            this.txtVVO1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Compra Oficial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInternet);
            this.groupBox2.Controls.Add(this.mcNuevo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtVCOI2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtVVB2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtVCB2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtVVO2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtVCO2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(10, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 239);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btnInternet
            // 
            this.btnInternet.Location = new System.Drawing.Point(620, 150);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(150, 23);
            this.btnInternet.TabIndex = 6;
            this.btnInternet.Text = "Ver Valor en Internet";
            this.btnInternet.UseVisualStyleBackColor = true;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // mcNuevo
            // 
            this.mcNuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mcNuevo.Location = new System.Drawing.Point(9, 47);
            this.mcNuevo.Name = "mcNuevo";
            this.mcNuevo.ShowTodayCircle = false;
            this.mcNuevo.TabIndex = 0;
            this.mcNuevo.TrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.mcNuevo.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcNuevo_DateChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(617, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Valor Compra Oficial con Impuesto";
            // 
            // txtVCOI2
            // 
            this.txtVCOI2.Location = new System.Drawing.Point(620, 91);
            this.txtVCOI2.Name = "txtVCOI2";
            this.txtVCOI2.Size = new System.Drawing.Size(115, 20);
            this.txtVCOI2.TabIndex = 3;
            this.txtVCOI2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirDecimales);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Valor Venta Blue";
            // 
            // txtVVB2
            // 
            this.txtVVB2.Location = new System.Drawing.Point(457, 150);
            this.txtVVB2.Name = "txtVVB2";
            this.txtVVB2.Size = new System.Drawing.Size(115, 20);
            this.txtVVB2.TabIndex = 5;
            this.txtVVB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirDecimales);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Valor Compra Blue";
            // 
            // txtVCB2
            // 
            this.txtVCB2.Location = new System.Drawing.Point(274, 150);
            this.txtVCB2.Name = "txtVCB2";
            this.txtVCB2.Size = new System.Drawing.Size(115, 20);
            this.txtVCB2.TabIndex = 4;
            this.txtVCB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirDecimales);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Valor Venta Oficial";
            // 
            // txtVVO2
            // 
            this.txtVVO2.Location = new System.Drawing.Point(457, 91);
            this.txtVVO2.Name = "txtVVO2";
            this.txtVVO2.Size = new System.Drawing.Size(115, 20);
            this.txtVVO2.TabIndex = 2;
            this.txtVVO2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirDecimales);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Valor Compra Oficial";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Fecha:";
            // 
            // txtVCO2
            // 
            this.txtVCO2.Location = new System.Drawing.Point(274, 91);
            this.txtVCO2.Name = "txtVCO2";
            this.txtVCO2.Size = new System.Drawing.Size(115, 20);
            this.txtVCO2.TabIndex = 1;
            this.txtVCO2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirDecimales);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Nueva Cotizacion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(377, 516);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(97, 36);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // MonedaExtranjera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 761);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonedaExtranjera";
            this.Text = "Dolar";
            this.Load += new System.EventHandler(this.Dolar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtVCO1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVCOI1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVVB1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVCB1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVVO1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVCOI2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVVB2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVCB2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVVO2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVCO2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MonthCalendar mcViejo;
        private System.Windows.Forms.MonthCalendar mcNuevo;
        private System.Windows.Forms.Button btnInternet;
        private System.Windows.Forms.Button btnAceptar;
    }
}