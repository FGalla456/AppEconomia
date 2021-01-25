
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
            this.SuspendLayout();
            // 
            // GraficoIngresos
            // 
            this.GraficoIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraficoIngresos.Location = new System.Drawing.Point(0, 0);
            this.GraficoIngresos.Name = "GraficoIngresos";
            this.GraficoIngresos.Size = new System.Drawing.Size(1091, 761);
            this.GraficoIngresos.TabIndex = 0;
            this.GraficoIngresos.Text = "pieChart1";
            // 
            // Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 761);
            this.Controls.Add(this.GraficoIngresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resumen";
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.Resumen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart GraficoIngresos;
    }
}