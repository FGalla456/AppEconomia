namespace Economica.Pantallas
{
    partial class Precio_Moneda_Extranjera
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
            this.wbME = new EO.WebBrowser.WebView();
            this.wbPME = new EO.WinForm.WebControl();
            this.SuspendLayout();
            // 
            // wbME
            // 
            this.wbME.InputMsgFilter = null;
            this.wbME.ObjectForScripting = null;
            this.wbME.Title = null;
            this.wbME.Url = "https://www.dolarhoy.com/";
            // 
            // wbPME
            // 
            this.wbPME.BackColor = System.Drawing.Color.White;
            this.wbPME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbPME.Location = new System.Drawing.Point(0, 0);
            this.wbPME.Name = "wbPME";
            this.wbPME.Size = new System.Drawing.Size(1051, 567);
            this.wbPME.TabIndex = 0;
            this.wbPME.Text = "webControl1";
            this.wbPME.WebView = this.wbME;
            // 
            // Precio_Moneda_Extranjera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 567);
            this.Controls.Add(this.wbPME);
            this.Name = "Precio_Moneda_Extranjera";
            this.Text = "Precio_Moneda_Extranjera";
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WebBrowser.WebView wbME;
        private EO.WinForm.WebControl wbPME;
    }
}