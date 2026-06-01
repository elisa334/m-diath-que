namespace médiatèque
{
    /// <summary>
    /// Formulaire permettant d'ajouter ou modifier un Personnel
    /// </summary>
    partial class Ajouter_modifier_Personnel
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
            txtnom = new TextBox();
            txtmail = new TextBox();
            txttéléphone = new TextBox();
            txtprénom = new TextBox();
            lblnom = new Label();
            lblmail = new Label();
            lbltéléphone = new Label();
            lblprénom = new Label();
            lblservice = new Label();
            btnenregistrer = new Button();
            btnannuler = new Button();
            txtservice = new ComboBox();
            SuspendLayout();
            // 
            // txtnom
            // 
            txtnom.Location = new Point(122, 15);
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(150, 31);
            txtnom.TabIndex = 0;
            // 
            // txtmail
            // 
            txtmail.Location = new Point(122, 127);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(150, 31);
            txtmail.TabIndex = 2;
            // 
            // txttéléphone
            // 
            txttéléphone.Location = new Point(122, 89);
            txttéléphone.Name = "txttéléphone";
            txttéléphone.Size = new Size(150, 31);
            txttéléphone.TabIndex = 3;
            // 
            // txtprénom
            // 
            txtprénom.Location = new Point(122, 50);
            txtprénom.Name = "txtprénom";
            txtprénom.Size = new Size(150, 31);
            txtprénom.TabIndex = 4;
            // 
            // lblnom
            // 
            lblnom.AutoSize = true;
            lblnom.Location = new Point(12, 21);
            lblnom.Name = "lblnom";
            lblnom.Size = new Size(52, 25);
            lblnom.TabIndex = 5;
            lblnom.Text = "Nom";
            // 
            // lblmail
            // 
            lblmail.AutoSize = true;
            lblmail.Location = new Point(12, 133);
            lblmail.Name = "lblmail";
            lblmail.Size = new Size(45, 25);
            lblmail.TabIndex = 7;
            lblmail.Text = "Mail";
            // 
            // lbltéléphone
            // 
            lbltéléphone.AutoSize = true;
            lbltéléphone.Location = new Point(12, 95);
            lbltéléphone.Name = "lbltéléphone";
            lbltéléphone.Size = new Size(92, 25);
            lbltéléphone.TabIndex = 8;
            lbltéléphone.Text = "Téléphone";
            // 
            // lblprénom
            // 
            lblprénom.AutoSize = true;
            lblprénom.Location = new Point(12, 56);
            lblprénom.Name = "lblprénom";
            lblprénom.Size = new Size(74, 25);
            lblprénom.TabIndex = 9;
            lblprénom.Text = "Prénom";
            // 
            // lblservice
            // 
            lblservice.AutoSize = true;
            lblservice.Location = new Point(12, 177);
            lblservice.Name = "lblservice";
            lblservice.Size = new Size(67, 25);
            lblservice.TabIndex = 10;
            lblservice.Text = "Service";
            lblservice.Click += lblservice_Click;
            // 
            // btnenregistrer
            // 
            btnenregistrer.Location = new Point(12, 225);
            btnenregistrer.Name = "btnenregistrer";
            btnenregistrer.Size = new Size(112, 34);
            btnenregistrer.TabIndex = 11;
            btnenregistrer.Text = "Enregistrer";
            btnenregistrer.UseVisualStyleBackColor = true;
            // 
            // btnannuler
            // 
            btnannuler.Location = new Point(160, 225);
            btnannuler.Name = "btnannuler";
            btnannuler.Size = new Size(112, 34);
            btnannuler.TabIndex = 12;
            btnannuler.Text = "Annuler";
            btnannuler.UseVisualStyleBackColor = true;
            // 
            // txtservice
            // 
            txtservice.FormattingEnabled = true;
            txtservice.Location = new Point(122, 169);
            txtservice.Name = "txtservice";
            txtservice.Size = new Size(150, 33);
            txtservice.TabIndex = 13;
            // 
            // Ajouter_modifier_Personnel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 273);
            Controls.Add(txtservice);
            Controls.Add(btnannuler);
            Controls.Add(btnenregistrer);
            Controls.Add(lblservice);
            Controls.Add(lblprénom);
            Controls.Add(lbltéléphone);
            Controls.Add(lblmail);
            Controls.Add(lblnom);
            Controls.Add(txtprénom);
            Controls.Add(txttéléphone);
            Controls.Add(txtmail);
            Controls.Add(txtnom);
            Name = "Ajouter_modifier_Personnel";
            Text = "Ajouter_modifier_Personnel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnom;
        private TextBox txtmail;
        private TextBox txttéléphone;
        private TextBox txtprénom;
        private Label lblnom;
        private Label lblmail;
        private Label lbltéléphone;
        private Label lblprénom;
        private Label lblservice;
        private Button btnenregistrer;
        private Button btnannuler;
        private ComboBox txtservice;
    }
}