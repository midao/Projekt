namespace Projekt2016
{
    partial class Form1
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
            this.textBoxBenutzer = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxBenutzer
            // 
            this.textBoxBenutzer.Location = new System.Drawing.Point(166, 93);
            this.textBoxBenutzer.Name = "textBoxBenutzer";
            this.textBoxBenutzer.Size = new System.Drawing.Size(125, 20);
            this.textBoxBenutzer.TabIndex = 0;
            this.textBoxBenutzer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(178, 145);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Location = new System.Drawing.Point(166, 119);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.PasswordChar = '*';
            this.textBoxPasswort.Size = new System.Drawing.Size(125, 20);
            this.textBoxPasswort.TabIndex = 1;
            this.textBoxPasswort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 262);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.textBoxBenutzer);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBenutzer;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPasswort;
    }
}

