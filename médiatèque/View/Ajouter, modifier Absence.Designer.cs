namespace médiatèque
{
    /// <summary>
    /// Formulaire permettant d'ajouter ou modifier une absence
    /// </summary>

    partial class Ajouter__modifier_Absence
    {
        /// <summary>
        /// Conteneurs des composants du formulaire
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libère les ressources libérés par le formulaire
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
            dtpdatedébut = new DateTimePicker();
            dtpdatefin = new DateTimePicker();
            comboBox1 = new ComboBox();
            btnannuler = new Button();
            btnenregistrer = new Button();
            lbldatefin = new Label();
            lbldatedébut = new Label();
            lblmotif = new Label();
            SuspendLayout();
            // 
            // dtpdatedébut
            // 
            dtpdatedébut.Format = DateTimePickerFormat.Custom;
            dtpdatedébut.Location = new Point(131, 17);
            dtpdatedébut.Name = "dtpdatedébut";
            dtpdatedébut.Size = new Size(154, 31);
            dtpdatedébut.TabIndex = 0;
            // 
            // dtpdatefin
            // 
            dtpdatefin.Format = DateTimePickerFormat.Custom;
            dtpdatefin.Location = new Point(131, 60);
            dtpdatefin.Name = "dtpdatefin";
            dtpdatefin.Size = new Size(150, 31);
            dtpdatefin.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 33);
            comboBox1.TabIndex = 2;
            // 
            // btnannuler
            // 
            btnannuler.Location = new Point(12, 163);
            btnannuler.Name = "btnannuler";
            btnannuler.Size = new Size(112, 34);
            btnannuler.TabIndex = 3;
            btnannuler.Text = "Annuler";
            btnannuler.UseVisualStyleBackColor = true;
            // 
            // btnenregistrer
            // 
            btnenregistrer.Location = new Point(169, 163);
            btnenregistrer.Name = "btnenregistrer";
            btnenregistrer.Size = new Size(112, 34);
            btnenregistrer.TabIndex = 4;
            btnenregistrer.Text = "Enregistrer";
            btnenregistrer.UseVisualStyleBackColor = true;
            // 
            // lbldatefin
            // 
            lbldatefin.AutoSize = true;
            lbldatefin.Location = new Point(12, 66);
            lbldatefin.Name = "lbldatefin";
            lbldatefin.Size = new Size(74, 25);
            lbldatefin.TabIndex = 5;
            lbldatefin.Text = "Date fin";
            // 
            // lbldatedébut
            // 
            lbldatedébut.AutoSize = true;
            lbldatedébut.Location = new Point(12, 23);
            lbldatedébut.Name = "lbldatedébut";
            lbldatedébut.Size = new Size(101, 25);
            lbldatedébut.TabIndex = 6;
            lbldatedébut.Text = "Date début";
            // 
            // lblmotif
            // 
            lblmotif.AutoSize = true;
            lblmotif.Location = new Point(12, 115);
            lblmotif.Name = "lblmotif";
            lblmotif.Size = new Size(55, 25);
            lblmotif.TabIndex = 7;
            lblmotif.Text = "Motif";
            // 
            // Ajouter__modifier_Absence
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 215);
            Controls.Add(lblmotif);
            Controls.Add(lbldatedébut);
            Controls.Add(lbldatefin);
            Controls.Add(btnenregistrer);
            Controls.Add(btnannuler);
            Controls.Add(comboBox1);
            Controls.Add(dtpdatefin);
            Controls.Add(dtpdatedébut);
            Name = "Ajouter__modifier_Absence";
            Text = "Ajouter__modifier_Absence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpdatedébut;
        private DateTimePicker dtpdatefin;
        private ComboBox comboBox1;
        private Button btnannuler;
        private Button btnenregistrer;
        private Label lbldatefin;
        private Label lbldatedébut;
        private Label lblmotif;
    }
}