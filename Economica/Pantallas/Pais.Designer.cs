
namespace Economica.Pantallas
{
    partial class Pais
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePais = new System.Windows.Forms.TextBox();
            this.txtNombreMoneda = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Pais:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la Moneda:";
            // 
            // txtNombrePais
            // 
            this.txtNombrePais.Location = new System.Drawing.Point(190, 48);
            this.txtNombrePais.Name = "txtNombrePais";
            this.txtNombrePais.Size = new System.Drawing.Size(256, 20);
            this.txtNombrePais.TabIndex = 2;
            // 
            // txtNombreMoneda
            // 
            this.txtNombreMoneda.Location = new System.Drawing.Point(190, 97);
            this.txtNombreMoneda.Name = "txtNombreMoneda";
            this.txtNombreMoneda.Size = new System.Drawing.Size(256, 20);
            this.txtNombreMoneda.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(203, 166);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(157, 42);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 241);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombreMoneda);
            this.Controls.Add(this.txtNombrePais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pais";
            this.Text = "Pais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrePais;
        private System.Windows.Forms.TextBox txtNombreMoneda;
        private System.Windows.Forms.Button btnAceptar;
    }
}