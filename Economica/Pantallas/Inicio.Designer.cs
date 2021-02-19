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
            System.Windows.Forms.Button btnCerrar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnPais = new System.Windows.Forms.Button();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            btnCerrar = new System.Windows.Forms.Button();
            this.PanelSuperior.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            resources.ApplyResources(btnCerrar, "btnCerrar");
            btnCerrar.Name = "btnCerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGastos
            // 
            resources.ApplyResources(this.btnGastos, "btnGastos");
            this.btnGastos.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.UseVisualStyleBackColor = false;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnIngresos
            // 
            resources.ApplyResources(this.btnIngresos, "btnIngresos");
            this.btnIngresos.BackColor = System.Drawing.Color.SpringGreen;
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.UseVisualStyleBackColor = false;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // btnResumen
            // 
            resources.ApplyResources(this.btnResumen, "btnResumen");
            this.btnResumen.BackColor = System.Drawing.Color.SpringGreen;
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // btnCategoria
            // 
            resources.ApplyResources(this.btnCategoria, "btnCategoria");
            this.btnCategoria.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnDolar
            // 
            resources.ApplyResources(this.btnDolar, "btnDolar");
            this.btnDolar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.UseVisualStyleBackColor = false;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnPais
            // 
            resources.ApplyResources(this.btnPais, "btnPais");
            this.btnPais.BackColor = System.Drawing.Color.SpringGreen;
            this.btnPais.Name = "btnPais";
            this.btnPais.UseVisualStyleBackColor = false;
            this.btnPais.Click += new System.EventHandler(this.btnPais_Click);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.Turquoise;
            this.PanelSuperior.Controls.Add(this.lblVersion);
            this.PanelSuperior.Controls.Add(this.lblNombre);
            this.PanelSuperior.Controls.Add(btnCerrar);
            this.PanelSuperior.Controls.Add(this.btnMinimizar);
            this.PanelSuperior.Controls.Add(this.btnConfiguracion);
            resources.ApplyResources(this.PanelSuperior, "PanelSuperior");
            this.PanelSuperior.Name = "PanelSuperior";
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            // 
            // btnMinimizar
            // 
            resources.ApplyResources(this.btnMinimizar, "btnMinimizar");
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnConfiguracion
            // 
            resources.ApplyResources(this.btnConfiguracion, "btnConfiguracion");
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Turquoise;
            this.PanelMenu.Controls.Add(this.btnPais);
            this.PanelMenu.Controls.Add(this.btnResumen);
            this.PanelMenu.Controls.Add(this.btnDolar);
            this.PanelMenu.Controls.Add(this.btnCategoria);
            this.PanelMenu.Controls.Add(this.btnIngresos);
            this.PanelMenu.Controls.Add(this.btnGastos);
            resources.ApplyResources(this.PanelMenu, "PanelMenu");
            this.PanelMenu.Name = "PanelMenu";
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.PanelContenedor, "PanelContenedor");
            this.PanelContenedor.Name = "PanelContenedor";
            // 
            // Inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.Button btnPais;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblVersion;
    }
}

