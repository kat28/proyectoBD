namespace ProyectoFinalG3
{
    partial class frmMuestra
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
            this.cbTablas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbTablas
            // 
            this.cbTablas.FormattingEnabled = true;
            this.cbTablas.Location = new System.Drawing.Point(39, 67);
            this.cbTablas.Name = "cbTablas";
            this.cbTablas.Size = new System.Drawing.Size(212, 21);
            this.cbTablas.TabIndex = 0;
            this.cbTablas.Click += new System.EventHandler(this.cbTablas_Click);
            // 
            // frmMuestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 183);
            this.Controls.Add(this.cbTablas);
            this.Name = "frmMuestra";
            this.Text = "frmMuestra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTablas;
    }
}