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
            this.pPais = new System.Windows.Forms.Panel();
            this.pMoneda = new System.Windows.Forms.Panel();
            this.pResumen = new System.Windows.Forms.Panel();
            this.pCategoria = new System.Windows.Forms.Panel();
            this.pIngreso = new System.Windows.Forms.Panel();
            this.pGasto = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            btnCerrar = new System.Windows.Forms.Button();
            this.PanelSuperior.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.pPais.SuspendLayout();
            this.pMoneda.SuspendLayout();
            this.pResumen.SuspendLayout();
            this.pCategoria.SuspendLayout();
            this.pIngreso.SuspendLayout();
            this.pGasto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(btnCerrar, "btnCerrar");
            btnCerrar.Name = "btnCerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGastos
            // 
            resources.ApplyResources(this.btnGastos, "btnGastos");
            this.btnGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnGastos.FlatAppearance.BorderSize = 0;
            this.btnGastos.ForeColor = System.Drawing.Color.White;
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.UseVisualStyleBackColor = false;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnIngresos
            // 
            resources.ApplyResources(this.btnIngresos, "btnIngresos");
            this.btnIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnIngresos.FlatAppearance.BorderSize = 0;
            this.btnIngresos.ForeColor = System.Drawing.Color.White;
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.UseVisualStyleBackColor = false;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // btnResumen
            // 
            resources.ApplyResources(this.btnResumen, "btnResumen");
            this.btnResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnResumen.FlatAppearance.BorderSize = 0;
            this.btnResumen.ForeColor = System.Drawing.Color.White;
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // btnCategoria
            // 
            resources.ApplyResources(this.btnCategoria, "btnCategoria");
            this.btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnDolar
            // 
            resources.ApplyResources(this.btnDolar, "btnDolar");
            this.btnDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDolar.FlatAppearance.BorderSize = 0;
            this.btnDolar.ForeColor = System.Drawing.Color.White;
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.UseVisualStyleBackColor = false;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnPais
            // 
            resources.ApplyResources(this.btnPais, "btnPais");
            this.btnPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnPais.FlatAppearance.BorderSize = 0;
            this.btnPais.ForeColor = System.Drawing.Color.White;
            this.btnPais.Name = "btnPais";
            this.btnPais.UseVisualStyleBackColor = false;
            this.btnPais.Click += new System.EventHandler(this.btnPais_Click);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(7)))));
            this.PanelSuperior.Controls.Add(this.lblVersion);
            this.PanelSuperior.Controls.Add(this.lblNombre);
            this.PanelSuperior.Controls.Add(btnCerrar);
            this.PanelSuperior.Controls.Add(this.btnMinimizar);
            this.PanelSuperior.Controls.Add(this.btnConfiguracion);
            resources.ApplyResources(this.PanelSuperior, "PanelSuperior");
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSuperior_Paint);
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Name = "lblVersion";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Name = "lblNombre";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnMinimizar, "btnMinimizar");
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnConfiguracion, "btnConfiguracion");
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(7)))));
            this.PanelMenu.Controls.Add(this.pPais);
            this.PanelMenu.Controls.Add(this.pMoneda);
            this.PanelMenu.Controls.Add(this.pResumen);
            this.PanelMenu.Controls.Add(this.pCategoria);
            this.PanelMenu.Controls.Add(this.pIngreso);
            this.PanelMenu.Controls.Add(this.pGasto);
            resources.ApplyResources(this.PanelMenu, "PanelMenu");
            this.PanelMenu.Name = "PanelMenu";
            // 
            // pPais
            // 
            this.pPais.Controls.Add(this.btnPais);
            resources.ApplyResources(this.pPais, "pPais");
            this.pPais.Name = "pPais";
            // 
            // pMoneda
            // 
            this.pMoneda.Controls.Add(this.btnDolar);
            resources.ApplyResources(this.pMoneda, "pMoneda");
            this.pMoneda.Name = "pMoneda";
            // 
            // pResumen
            // 
            this.pResumen.Controls.Add(this.btnResumen);
            resources.ApplyResources(this.pResumen, "pResumen");
            this.pResumen.Name = "pResumen";
            // 
            // pCategoria
            // 
            this.pCategoria.Controls.Add(this.btnCategoria);
            resources.ApplyResources(this.pCategoria, "pCategoria");
            this.pCategoria.Name = "pCategoria";
            // 
            // pIngreso
            // 
            this.pIngreso.Controls.Add(this.btnIngresos);
            resources.ApplyResources(this.pIngreso, "pIngreso");
            this.pIngreso.Name = "pIngreso";
            // 
            // pGasto
            // 
            this.pGasto.Controls.Add(this.btnGastos);
            resources.ApplyResources(this.pGasto, "pGasto");
            this.pGasto.Name = "pGasto";
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(7)))));
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
            this.pPais.ResumeLayout(false);
            this.pMoneda.ResumeLayout(false);
            this.pResumen.ResumeLayout(false);
            this.pCategoria.ResumeLayout(false);
            this.pIngreso.ResumeLayout(false);
            this.pGasto.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pPais;
        private System.Windows.Forms.Panel pMoneda;
        private System.Windows.Forms.Panel pResumen;
        private System.Windows.Forms.Panel pCategoria;
        private System.Windows.Forms.Panel pIngreso;
        private System.Windows.Forms.Panel pGasto;
    }
}

