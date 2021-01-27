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
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnIngresos
            // 
            resources.ApplyResources(this.btnIngresos, "btnIngresos");
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.UseVisualStyleBackColor = true;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // btnResumen
            // 
            resources.ApplyResources(this.btnResumen, "btnResumen");
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // btnCategoria
            // 
            resources.ApplyResources(this.btnCategoria, "btnCategoria");
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnDolar
            // 
            resources.ApplyResources(this.btnDolar, "btnDolar");
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnPais
            // 
            resources.ApplyResources(this.btnPais, "btnPais");
            this.btnPais.Name = "btnPais";
            this.btnPais.UseVisualStyleBackColor = true;
            this.btnPais.Click += new System.EventHandler(this.btnPais_Click);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.Controls.Add(btnCerrar);
            this.PanelSuperior.Controls.Add(this.btnMinimizar);
            this.PanelSuperior.Controls.Add(this.btnConfiguracion);
            resources.ApplyResources(this.PanelSuperior, "PanelSuperior");
            this.PanelSuperior.Name = "PanelSuperior";
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
    }
}

