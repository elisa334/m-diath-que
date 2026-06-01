namespace médiatèque
{
    /// <summary>
    /// Formulaire de gestion des absences du personnel
    /// </summary>
    partial class Absence
    {
        /// <summary>
        /// Conteneurs des composants du formulaire
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libère les ressources utilisés
        /// </summary>
        /// <param name="disposing">
        /// true si les ressources managées doivent être libérées, sinon false
        /// </param>
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
            dgvabsence = new DataGridView();
            btnajouter = new Button();
            btnmodifier = new Button();
            btnsupprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvabsence).BeginInit();
            SuspendLayout();
            // 
            // dgvabsence
            // 
            dgvabsence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvabsence.Location = new Point(12, 12);
            dgvabsence.Name = "dgvabsence";
            dgvabsence.RowHeadersWidth = 62;
            dgvabsence.Size = new Size(380, 225);
            dgvabsence.TabIndex = 0;
            // 
            // btnajouter
            // 
            btnajouter.Location = new Point(12, 259);
            btnajouter.Name = "btnajouter";
            btnajouter.Size = new Size(112, 34);
            btnajouter.TabIndex = 1;
            btnajouter.Text = "Ajouter";
            btnajouter.UseVisualStyleBackColor = true;
            // 
            // btnmodifier
            // 
            btnmodifier.Location = new Point(148, 259);
            btnmodifier.Name = "btnmodifier";
            btnmodifier.Size = new Size(112, 34);
            btnmodifier.TabIndex = 2;
            btnmodifier.Text = "Modifier";
            btnmodifier.UseVisualStyleBackColor = true;
            // 
            // btnsupprimer
            // 
            btnsupprimer.Location = new Point(280, 259);
            btnsupprimer.Name = "btnsupprimer";
            btnsupprimer.Size = new Size(112, 34);
            btnsupprimer.TabIndex = 3;
            btnsupprimer.Text = "Supprimer";
            btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // Absence
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 307);
            Controls.Add(btnsupprimer);
            Controls.Add(btnmodifier);
            Controls.Add(btnajouter);
            Controls.Add(dgvabsence);
            Name = "Absence";
            Text = "Absence";
            ((System.ComponentModel.ISupportInitialize)dgvabsence).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvabsence;
        private Button btnajouter;
        private Button btnmodifier;
        private Button btnsupprimer;
    }
}