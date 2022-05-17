
namespace BoVloApp
{
    partial class Basket
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
            this.buttonFinaliser = new System.Windows.Forms.Button();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.PanelPanier = new System.Windows.Forms.Panel();
            this.label_estimate_date = new System.Windows.Forms.Label();
            this.label_deliverytitle = new System.Windows.Forms.Label();
            this.catalog_button = new System.Windows.Forms.Button();
            this.panierData = new System.Windows.Forms.DataGridView();
            this.LabelPrixTotal = new System.Windows.Forms.Label();
            this.PanelPanier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panierData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFinaliser
            // 
            this.buttonFinaliser.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFinaliser.Location = new System.Drawing.Point(1330, 668);
            this.buttonFinaliser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFinaliser.Name = "buttonFinaliser";
            this.buttonFinaliser.Size = new System.Drawing.Size(201, 56);
            this.buttonFinaliser.TabIndex = 0;
            this.buttonFinaliser.Text = "Finaliser";
            this.buttonFinaliser.UseVisualStyleBackColor = true;
            this.buttonFinaliser.Click += new System.EventHandler(this.buttonFinaliser_Click);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTotal.Location = new System.Drawing.Point(175, 591);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(155, 46);
            this.LabelTotal.TabIndex = 3;
            this.LabelTotal.Text = "Total (€) :";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(753, 38);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(184, 72);
            this.Title.TabIndex = 4;
            this.Title.Text = "Basket";
            // 
            // PanelPanier
            // 
            this.PanelPanier.Controls.Add(this.label_estimate_date);
            this.PanelPanier.Controls.Add(this.label_deliverytitle);
            this.PanelPanier.Controls.Add(this.catalog_button);
            this.PanelPanier.Controls.Add(this.panierData);
            this.PanelPanier.Controls.Add(this.LabelPrixTotal);
            this.PanelPanier.Controls.Add(this.Title);
            this.PanelPanier.Controls.Add(this.LabelTotal);
            this.PanelPanier.Controls.Add(this.buttonFinaliser);
            this.PanelPanier.Location = new System.Drawing.Point(0, 0);
            this.PanelPanier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPanier.Name = "PanelPanier";
            this.PanelPanier.Size = new System.Drawing.Size(1701, 823);
            this.PanelPanier.TabIndex = 22;
            // 
            // label_estimate_date
            // 
            this.label_estimate_date.AutoSize = true;
            this.label_estimate_date.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_estimate_date.Location = new System.Drawing.Point(565, 662);
            this.label_estimate_date.Name = "label_estimate_date";
            this.label_estimate_date.Size = new System.Drawing.Size(0, 37);
            this.label_estimate_date.TabIndex = 9;
            // 
            // label_deliverytitle
            // 
            this.label_deliverytitle.AutoSize = true;
            this.label_deliverytitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_deliverytitle.Location = new System.Drawing.Point(175, 653);
            this.label_deliverytitle.Name = "label_deliverytitle";
            this.label_deliverytitle.Size = new System.Drawing.Size(384, 46);
            this.label_deliverytitle.TabIndex = 8;
            this.label_deliverytitle.Text = "Estimated delivery date :";
            // 
            // catalog_button
            // 
            this.catalog_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catalog_button.Location = new System.Drawing.Point(51, 60);
            this.catalog_button.Name = "catalog_button";
            this.catalog_button.Size = new System.Drawing.Size(187, 50);
            this.catalog_button.TabIndex = 7;
            this.catalog_button.Text = "Catalog";
            this.catalog_button.UseVisualStyleBackColor = true;
            this.catalog_button.Click += new System.EventHandler(this.catalog_button_Click);
            // 
            // panierData
            // 
            this.panierData.AllowUserToAddRows = false;
            this.panierData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.panierData.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.panierData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panierData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panierData.Location = new System.Drawing.Point(142, 145);
            this.panierData.Name = "panierData";
            this.panierData.RowHeadersVisible = false;
            this.panierData.RowTemplate.Height = 25;
            this.panierData.Size = new System.Drawing.Size(1389, 411);
            this.panierData.TabIndex = 6;
            this.panierData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.panierData_CellValueChanged);
            // 
            // LabelPrixTotal
            // 
            this.LabelPrixTotal.AutoSize = true;
            this.LabelPrixTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPrixTotal.Location = new System.Drawing.Point(345, 597);
            this.LabelPrixTotal.Name = "LabelPrixTotal";
            this.LabelPrixTotal.Size = new System.Drawing.Size(0, 37);
            this.LabelPrixTotal.TabIndex = 5;
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 791);
            this.Controls.Add(this.PanelPanier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Basket";
            this.Text = "Panier";
            this.PanelPanier.ResumeLayout(false);
            this.PanelPanier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panierData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFinaliser;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel PanelPanier;
        private System.Windows.Forms.Label LabelPrixTotal;
        private System.Windows.Forms.DataGridView panierData;
        private System.Windows.Forms.Button catalog_button;
        private System.Windows.Forms.Label label_estimate_date;
        private System.Windows.Forms.Label label_deliverytitle;
    }
}