namespace médiatèque
{
    /// <summary>
    /// Gestion de la Connexion
    /// </summary>
    partial class Connexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtmdp = new TextBox();
            txtlogin = new TextBox();
            lblmdp = new Label();
            lbllogin = new Label();
            btnconnexion = new Button();
            SuspendLayout();
            // 
            // txtmdp
            // 
            txtmdp.Location = new Point(149, 64);
            txtmdp.Name = "txtmdp";
            txtmdp.Size = new Size(150, 31);
            txtmdp.TabIndex = 9;
            // 
            // txtlogin
            // 
            txtlogin.Location = new Point(149, 21);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(150, 31);
            txtlogin.TabIndex = 8;
            // 
            // lblmdp
            // 
            lblmdp.AutoSize = true;
            lblmdp.Location = new Point(12, 70);
            lblmdp.Name = "lblmdp";
            lblmdp.Size = new Size(120, 25);
            lblmdp.TabIndex = 7;
            lblmdp.Text = "Mot de passe";
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Location = new Point(12, 27);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(56, 25);
            lbllogin.TabIndex = 6;
            lbllogin.Text = "Login";
            // 
            // btnconnexion
            // 
            btnconnexion.Location = new Point(187, 114);
            btnconnexion.Name = "btnconnexion";
            btnconnexion.Size = new Size(112, 34);
            btnconnexion.TabIndex = 5;
            btnconnexion.Text = "Connexion";
            btnconnexion.UseVisualStyleBackColor = true;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 167);
            Controls.Add(txtmdp);
            Controls.Add(txtlogin);
            Controls.Add(lblmdp);
            Controls.Add(lbllogin);
            Controls.Add(btnconnexion);
            Name = "Connexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmdp;
        private TextBox txtlogin;
        private Label lblmdp;
        private Label lbllogin;
        private Button btnconnexion;
    }
}
