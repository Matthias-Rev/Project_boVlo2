
namespace BoVloApp
{
    partial class Panier
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.PanelPanier = new System.Windows.Forms.Panel();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PanelPanier.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFinaliser
            // 
            this.buttonFinaliser.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFinaliser.Location = new System.Drawing.Point(1520, 890);
            this.buttonFinaliser.Name = "buttonFinaliser";
            this.buttonFinaliser.Size = new System.Drawing.Size(230, 75);
            this.buttonFinaliser.TabIndex = 0;
            this.buttonFinaliser.Text = "Finaliser";
            this.buttonFinaliser.UseVisualStyleBackColor = true;
            // 
            // buttonPlanning
            // 
            this.buttonPlanning.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlanning.Location = new System.Drawing.Point(829, 890);
            this.buttonPlanning.Name = "buttonPlanning";
            this.buttonPlanning.Size = new System.Drawing.Size(400, 75);
            this.buttonPlanning.TabIndex = 1;
            this.buttonPlanning.Text = "Consulter Planning";
            this.buttonPlanning.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(354, 890);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(275, 75);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTotal.Location = new System.Drawing.Point(202, 899);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(122, 57);
            this.LabelTotal.TabIndex = 3;
            this.LabelTotal.Text = "Total:";
            this.LabelTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(861, 51);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(220, 89);
            this.Title.TabIndex = 4;
            this.Title.Text = "Panier";
            // 
            // PanelPanier
            // 
            this.PanelPanier.Location = new System.Drawing.Point(0, 0);
            this.PanelPanier.Name = "PanelPanier";
            this.PanelPanier.Size = new System.Drawing.Size(1944, 1097);
            this.PanelPanier.TabIndex = 22;
            //this.PanelPanier.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPanier_Paint);
            PanelPanier.Controls.Add(this.TableLayoutPanel);
            PanelPanier.Controls.Add(this.Title);
            PanelPanier.Controls.Add(this.LabelTotal);
            PanelPanier.Controls.Add(this.richTextBox1);
            PanelPanier.Controls.Add(this.buttonPlanning);
            PanelPanier.Controls.Add(this.buttonFinaliser);
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.AutoScroll = true;
            this.TableLayoutPanel.ColumnCount = 1;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Location = new System.Drawing.Point(202, 185);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(1548, 627);
            this.TableLayoutPanel.TabIndex = 2;
            this.TableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Panier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.PanelPanier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Panier";
            this.Text = "Panier";
            this.Load += new System.EventHandler(this.Panier_Load);
            this.PanelPanier.ResumeLayout(false);
            this.PanelPanier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFinaliser;
        private System.Windows.Forms.Button buttonPlanning;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel PanelPanier;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    }
}