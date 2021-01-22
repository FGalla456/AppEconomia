
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
            this.Grilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // GraficoIngresos
            // 
            this.GraficoIngresos.Location = new System.Drawing.Point(34, 50);
            this.GraficoIngresos.Name = "GraficoIngresos";
            this.GraficoIngresos.Size = new System.Drawing.Size(395, 239);
            this.GraficoIngresos.TabIndex = 0;
            this.GraficoIngresos.Text = "pieChart1";
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(366, 12);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(422, 417);
            this.Grilla.TabIndex = 1;
            this.Grilla.Visible = false;
            // 
            // Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.GraficoIngresos);
            this.Name = "Resumen";
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.Resumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart GraficoIngresos;
        private System.Windows.Forms.DataGridView Grilla;
    }
}