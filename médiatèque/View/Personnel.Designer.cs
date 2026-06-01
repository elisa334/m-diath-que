namespace médiatèque
{
    partial class Personnel
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
            dgvpersonnel = new DataGridView();
            btnajouter = new Button();
            btnmodifier = new Button();
            btnsupprimer = new Button();
            btngérer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvpersonnel).BeginInit();
            SuspendLayout();
            // 
            // dgvpersonnel
            // 
            dgvpersonnel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpersonnel.Location = new Point(12, 12);
            dgvpersonnel.Name = "dgvpersonnel";
            dgvpersonnel.RowHeadersWidth = 62;
            dgvpersonnel.Size = new Size(374, 225);
            dgvpersonnel.TabIndex = 0;
            // 
            // btnajouter
            // 
            btnajouter.Location = new Point(12, 266);
            btnajouter.Name = "btnajouter";
            btnajouter.Size = new Size(112, 34);
            btnajouter.TabIndex = 1;
            btnajouter.Text = "Ajouter";
            btnajouter.UseVisualStyleBackColor = true;
            // 
            // btnmodifier
            // 
            btnmodifier.Location = new Point(142, 266);
            btnmodifier.Name = "btnmodifier";
            btnmodifier.Size = new Size(112, 34);
            btnmodifier.TabIndex = 2;
            btnmodifier.Text = "Modifier";
            btnmodifier.UseVisualStyleBackColor = true;
            // 
            // btnsupprimer
            // 
            btnsupprimer.Location = new Point(274, 266);
            btnsupprimer.Name = "btnsupprimer";
            btnsupprimer.Size = new Size(112, 34);
            btnsupprimer.TabIndex = 3;
            btnsupprimer.Text = "Supprimer";
            btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // btngérer
            // 
            btngérer.Location = new Point(108, 306);
            btngérer.Name = "btngérer";
            btngérer.Size = new Size(175, 34);
            btngérer.TabIndex = 4;
            btngérer.Text = "Gérer les absences";
            btngérer.UseVisualStyleBackColor = true;
            // 
            // Personnel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 347);
            Controls.Add(btngérer);
            Controls.Add(btnsupprimer);
            Controls.Add(btnmodifier);
            Controls.Add(btnajouter);
            Controls.Add(dgvpersonnel);
            Name = "Personnel";
            Text = "Personnel";
            ((System.ComponentModel.ISupportInitialize)dgvpersonnel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvpersonnel;
        private Button btnajouter;
        private Button btnmodifier;
        private Button btnsupprimer;
        private Button btngérer;
    }
}