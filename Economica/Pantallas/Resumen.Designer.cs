
namespace Economica.Pantallas
{
    partial class Resumen
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
            this.GraficoIngresos = new LiveCharts.WinForms.PieChart();
            this.gbTabla = new System.Windows.Forms.GroupBox();
            this.rbIngreso = new System.Windows.Forms.RadioButton();
            this.rbGasto = new System.Windows.Forms.RadioButton();
            this.gbTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraficoIngresos
            // 
            this.GraficoIngresos.Location = new System.Drawing.Point(99, 52);
            this.GraficoIngresos.Name = "GraficoIngresos";
            this.GraficoIngresos.Size = new System.Drawing.Size(963, 685);
            this.GraficoIngresos.TabIndex = 0;
            this.GraficoIngresos.Text = "pieChart1";
            // 
            // gbTabla
            // 
            this.gbTabla.Controls.Add(this.rbGasto);
            this.gbTabla.Controls.Add(this.rbIngreso);
            this.gbTabla.Location = new System.Drawing.Point(13, 13);
            this.gbTabla.Name = "gbTabla";
            this.gbTabla.Size = new System.Drawing.Size(191, 65);
            this.gbTabla.TabIndex = 1;
            this.gbTabla.TabStop = false;
            // 
            // rbIngreso
            // 
            this.rbIngreso.AutoSize = true;
            this.rbIngreso.Location = new System.Drawing.Point(17, 28);
            this.rbIngreso.Name = "rbIngreso";
            this.rbIngreso.Size = new System.Drawing.Size(60, 17);
            this.rbIngreso.TabIndex = 0;
            this.rbIngreso.TabStop = true;
            this.rbIngreso.Text = "Ingreso";
            this.rbIngreso.UseVisualStyleBackColor = true;
            this.rbIngreso.CheckedChanged += new System.EventHandler(this.rbIngreso_CheckedChanged);
            // 
            // rbGasto
            // 
            this.rbGasto.AutoSize = true;
            this.rbGasto.Location = new System.Drawing.Point(109, 28);
            this.rbGasto.Name = "rbGasto";
            this.rbGasto.Size = new System.Drawing.Size(53, 17);
            this.rbGasto.TabIndex = 1;
            this.rbGasto.TabStop = true;
            this.rbGasto.Text = "Gasto";
            this.rbGasto.UseVisualStyleBackColor = true;
            this.rbGasto.CheckedChanged += new System.EventHandler(this.rbGasto_CheckedChanged);
            // 
            // Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 761);
            this.Controls.Add(this.gbTabla);
            this.Controls.Add(this.GraficoIngresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resumen";
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.Resumen_Load);
            this.gbTabla.ResumeLayout(false);
            this.gbTabla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart GraficoIngresos;
        private System.Windows.Forms.GroupBox gbTabla;
        private System.Windows.Forms.RadioButton rbGasto;
        private System.Windows.Forms.RadioButton rbIngreso;
    }
}