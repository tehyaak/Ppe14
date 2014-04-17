namespace PPE14
{
    partial class form_prof
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid_liste_etu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_liste_comp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_liste_etu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_liste_comp)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_liste_etu
            // 
            this.grid_liste_etu.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_liste_etu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_liste_etu.Location = new System.Drawing.Point(138, 27);
            this.grid_liste_etu.Name = "grid_liste_etu";
            this.grid_liste_etu.Size = new System.Drawing.Size(452, 511);
            this.grid_liste_etu.TabIndex = 0;
            this.grid_liste_etu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des étudiants:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grid_liste_comp
            // 
            this.grid_liste_comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_liste_comp.Location = new System.Drawing.Point(671, 27);
            this.grid_liste_comp.Name = "grid_liste_comp";
            this.grid_liste_comp.Size = new System.Drawing.Size(515, 511);
            this.grid_liste_comp.TabIndex = 3;
            this.grid_liste_comp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(885, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Compétences ";
            // 
            // form_prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1262, 575);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_liste_comp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_liste_etu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "form_prof";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "PPE14";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_liste_etu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_liste_comp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_liste_etu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_liste_comp;
        private System.Windows.Forms.Label label2;

    }
}

