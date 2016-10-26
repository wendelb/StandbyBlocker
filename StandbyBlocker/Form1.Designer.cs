namespace StandbyBlocker
{
    partial class FrmStandby
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStandby));
            this.BtnStandby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStandby
            // 
            resources.ApplyResources(this.BtnStandby, "BtnStandby");
            this.BtnStandby.Name = "BtnStandby";
            this.BtnStandby.UseVisualStyleBackColor = true;
            this.BtnStandby.Click += new System.EventHandler(this.BtnStandby_Click);
            // 
            // FrmStandby
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnStandby);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStandby";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStandby;
    }
}

