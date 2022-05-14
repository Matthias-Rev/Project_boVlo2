namespace BoVloApp
{
    partial class Main
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
            this.Topbar_panel = new System.Windows.Forms.Panel();
            this.Username_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Menu_button = new System.Windows.Forms.Button();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.Titel = new System.Windows.Forms.Label();
            this.Orders = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.Button();
            this.Catalog = new System.Windows.Forms.Button();
            this.STOCK = new System.Windows.Forms.Button();
            this.Topbar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Topbar_panel
            // 
            this.Topbar_panel.AutoSize = true;
            this.Topbar_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Topbar_panel.Controls.Add(this.Username_label);
            this.Topbar_panel.Controls.Add(this.pictureBox1);
            this.Topbar_panel.Controls.Add(this.Logout_button);
            this.Topbar_panel.Controls.Add(this.Menu_button);
            this.Topbar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topbar_panel.Location = new System.Drawing.Point(0, 0);
            this.Topbar_panel.Name = "Topbar_panel";
            this.Topbar_panel.Size = new System.Drawing.Size(1904, 63);
            this.Topbar_panel.TabIndex = 0;
            // 
            // Username_label
            // 
            this.Username_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username_label.AutoSize = true;
            this.Username_label.BackColor = System.Drawing.Color.DimGray;
            this.Username_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Username_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username_label.ForeColor = System.Drawing.Color.White;
            this.Username_label.Location = new System.Drawing.Point(1618, 16);
            this.Username_label.Name = "Username_label";
            this.Username_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Username_label.Size = new System.Drawing.Size(0, 30);
            this.Username_label.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BoVloApp.Properties.Resources.Login_icon;
            this.pictureBox1.Location = new System.Drawing.Point(1624, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Logout_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Logout_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Logout_button.Location = new System.Drawing.Point(1713, 9);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(178, 45);
            this.Logout_button.TabIndex = 2;
            this.Logout_button.Text = "Se déconnecter";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Menu_button
            // 
            this.Menu_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Menu_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Menu_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Menu_button.Location = new System.Drawing.Point(13, 9);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(114, 45);
            this.Menu_button.TabIndex = 1;
            this.Menu_button.Text = "MENU";
            this.Menu_button.UseVisualStyleBackColor = false;
            this.Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // Main_panel
            // 
            this.Main_panel.BackColor = System.Drawing.Color.Transparent;
            this.Main_panel.Controls.Add(this.Titel);
            this.Main_panel.Controls.Add(this.Orders);
            this.Main_panel.Controls.Add(this.Calendar);
            this.Main_panel.Controls.Add(this.Catalog);
            this.Main_panel.Controls.Add(this.STOCK);
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel.Location = new System.Drawing.Point(0, 63);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(1904, 733);
            this.Main_panel.TabIndex = 1;
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titel.Location = new System.Drawing.Point(833, 117);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(199, 72);
            this.Titel.TabIndex = 7;
            this.Titel.Text = "BOVLO";
            // 
            // Orders
            // 
            this.Orders.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Orders.Location = new System.Drawing.Point(1069, 579);
            this.Orders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(350, 112);
            this.Orders.TabIndex = 4;
            this.Orders.Text = "ORDERS";
            this.Orders.UseVisualStyleBackColor = true;
            this.Orders.Click += new System.EventHandler(this.COMMANDES_Click);
            // 
            // Calendar
            // 
            this.Calendar.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calendar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Calendar.Location = new System.Drawing.Point(552, 579);
            this.Calendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(350, 112);
            this.Calendar.TabIndex = 6;
            this.Calendar.Text = "CALENDAR";
            this.Calendar.UseVisualStyleBackColor = true;
            this.Calendar.Click += new System.EventHandler(this.CALENDRIER_Click);
            // 
            // Catalog
            // 
            this.Catalog.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Catalog.Location = new System.Drawing.Point(552, 374);
            this.Catalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Catalog.Name = "Catalog";
            this.Catalog.Size = new System.Drawing.Size(350, 112);
            this.Catalog.TabIndex = 1;
            this.Catalog.Text = "CATALOG";
            this.Catalog.UseVisualStyleBackColor = true;
            this.Catalog.Click += new System.EventHandler(this.CATALOGUE_Click);
            // 
            // STOCK
            // 
            this.STOCK.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.STOCK.Location = new System.Drawing.Point(1069, 374);
            this.STOCK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.STOCK.Name = "STOCK";
            this.STOCK.Size = new System.Drawing.Size(350, 112);
            this.STOCK.TabIndex = 5;
            this.STOCK.Text = "STOCK";
            this.STOCK.UseVisualStyleBackColor = true;
            this.STOCK.Click += new System.EventHandler(this.STOCK_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 796);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.Topbar_panel);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Topbar_panel.ResumeLayout(false);
            this.Topbar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Main_panel.ResumeLayout(false);
            this.Main_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Topbar_panel;
        private System.Windows.Forms.Button Menu_button;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Button Catalog;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button Calendar;
        private System.Windows.Forms.Button STOCK;
        private System.Windows.Forms.Label Titel;
    }
}