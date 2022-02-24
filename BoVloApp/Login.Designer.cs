
namespace BoVloApp
{
    partial class Login
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
            this.user_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.Login_box = new System.Windows.Forms.GroupBox();
            this.login_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Utilisateur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Titel = new System.Windows.Forms.Label();
            this.Login_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_input
            // 
            this.user_input.Location = new System.Drawing.Point(143, 87);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(427, 34);
            this.user_input.TabIndex = 1;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(143, 168);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(427, 34);
            this.password_input.TabIndex = 2;
            // 
            // Login_box
            // 
            this.Login_box.Controls.Add(this.login_button);
            this.Login_box.Controls.Add(this.label2);
            this.Login_box.Controls.Add(this.Utilisateur);
            this.Login_box.Controls.Add(this.label1);
            this.Login_box.Controls.Add(this.user_input);
            this.Login_box.Controls.Add(this.password_input);
            this.Login_box.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_box.Location = new System.Drawing.Point(537, 340);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(714, 333);
            this.Login_box.TabIndex = 3;
            this.Login_box.TabStop = false;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(250, 218);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(214, 67);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "Se connecter";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, -270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // Utilisateur
            // 
            this.Utilisateur.AutoSize = true;
            this.Utilisateur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Utilisateur.Location = new System.Drawing.Point(143, 50);
            this.Utilisateur.Margin = new System.Windows.Forms.Padding(0);
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.Size = new System.Drawing.Size(114, 30);
            this.Utilisateur.TabIndex = 4;
            this.Utilisateur.Text = "Utilisateur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mot de passe:";
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titel.Location = new System.Drawing.Point(761, 132);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(294, 106);
            this.Titel.TabIndex = 6;
            this.Titel.Text = "BOVLO";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1410);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.Login_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Login_box.ResumeLayout(false);
            this.Login_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox user_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.GroupBox Login_box;
        private System.Windows.Forms.Label Utilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Button login_button;
    }
}