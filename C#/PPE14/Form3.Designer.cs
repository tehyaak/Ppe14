namespace PPE14
{
    partial class form_base
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_etudiant = new System.Windows.Forms.ToolStripLabel();
            this.btn_admin = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_etudiant,
            this.btn_admin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1232, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_etudiant
            // 
            this.btn_etudiant.Name = "btn_etudiant";
            this.btn_etudiant.Size = new System.Drawing.Size(56, 22);
            this.btn_etudiant.Text = "Etudiants";
            this.btn_etudiant.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(86, 22);
            this.btn_admin.Text = "Administration";
            this.btn_admin.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // form_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 486);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "form_base";
            this.Text = "Accueil";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btn_etudiant;
        private System.Windows.Forms.ToolStripLabel btn_admin;
    }
}