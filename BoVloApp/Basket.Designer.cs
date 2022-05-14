
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
            this.buttonPlanning = new System.Windows.Forms.Button();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.PanelPanier = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panierData = new System.Windows.Forms.DataGridView();
            this.LabelPrixTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // buttonPlanning
            // 
            this.buttonPlanning.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlanning.Location = new System.Drawing.Point(656, 668);
            this.buttonPlanning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlanning.Name = "buttonPlanning";
            this.buttonPlanning.Size = new System.Drawing.Size(350, 56);
            this.buttonPlanning.TabIndex = 1;
            this.buttonPlanning.Text = "Consulter Planning";
            this.buttonPlanning.UseVisualStyleBackColor = true;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTotal.Location = new System.Drawing.Point(177, 674);
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
            this.Title.Size = new System.Drawing.Size(176, 72);
            this.Title.TabIndex = 4;
            this.Title.Text = "Panier";
            // 
            // PanelPanier
            // 
            this.PanelPanier.Controls.Add(this.label4);
            this.PanelPanier.Controls.Add(this.label3);
            this.PanelPanier.Controls.Add(this.label2);
            this.PanelPanier.Controls.Add(this.label1);
            this.PanelPanier.Controls.Add(this.panierData);
            this.PanelPanier.Controls.Add(this.LabelPrixTotal);
            this.PanelPanier.Controls.Add(this.Title);
            this.PanelPanier.Controls.Add(this.LabelTotal);
            this.PanelPanier.Controls.Add(this.buttonPlanning);
            this.PanelPanier.Controls.Add(this.buttonFinaliser);
            this.PanelPanier.Location = new System.Drawing.Point(0, 0);
            this.PanelPanier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPanier.Name = "PanelPanier";
            this.PanelPanier.Size = new System.Drawing.Size(1701, 823);
            this.PanelPanier.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "cellValue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "columnName";
            // 
            // panierData
            // 
            this.panierData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.panierData.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.panierData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panierData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panierData.Location = new System.Drawing.Point(142, 145);
            this.panierData.Name = "panierData";
            this.panierData.RowTemplate.Height = 25;
            this.panierData.Size = new System.Drawing.Size(1389, 411);
            this.panierData.TabIndex = 6;
            this.panierData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.panierData_CellValueChanged);
            // 
            // LabelPrixTotal
            // 
            this.LabelPrixTotal.AutoSize = true;
            this.LabelPrixTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPrixTotal.Location = new System.Drawing.Point(329, 680);
            this.LabelPrixTotal.Name = "LabelPrixTotal";
            this.LabelPrixTotal.Size = new System.Drawing.Size(32, 37);
            this.LabelPrixTotal.TabIndex = 5;
            this.LabelPrixTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // Panier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 791);
            this.Controls.Add(this.PanelPanier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panier";
            this.Text = "Panier";
            this.PanelPanier.ResumeLayout(false);
            this.PanelPanier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panierData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFinaliser;
        private System.Windows.Forms.Button buttonPlanning;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel PanelPanier;
        private System.Windows.Forms.Label LabelPrixTotal;
        private System.Windows.Forms.DataGridView panierData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}