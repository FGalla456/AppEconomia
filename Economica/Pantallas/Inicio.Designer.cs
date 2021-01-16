namespace Economica
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnPais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGastos
            // 
            this.btnGastos.Location = new System.Drawing.Point(214, 93);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(75, 23);
            this.btnGastos.TabIndex = 0;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnIngresos
            // 
            this.btnIngresos.Location = new System.Drawing.Point(468, 93);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(75, 23);
            this.btnIngresos.TabIndex = 1;
            this.btnIngresos.Text = "Ingresos";
            this.btnIngresos.UseVisualStyleBackColor = true;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(705, 93);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(84, 23);
            this.btnResumen.TabIndex = 2;
            this.btnResumen.Text = "Resumen";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(214, 276);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnCategoria.TabIndex = 3;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnDolar
            // 
            this.btnDolar.Location = new System.Drawing.Point(468, 276);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(75, 23);
            this.btnDolar.TabIndex = 4;
            this.btnDolar.Text = "Dolar";
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(705, 276);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(84, 23);
            this.btnConfiguracion.TabIndex = 5;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnPais
            // 
            this.btnPais.Location = new System.Drawing.Point(468, 409);
            this.btnPais.Name = "btnPais";
            this.btnPais.Size = new System.Drawing.Size(75, 23);
            this.btnPais.TabIndex = 6;
            this.btnPais.Text = "Pais";
            this.btnPais.UseVisualStyleBackColor = true;
            this.btnPais.Click += new System.EventHandler(this.btnPais_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 509);
            this.Controls.Add(this.btnPais);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.btnIngresos);
            this.Controls.Add(this.btnGastos);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnPais;
    }
}

