﻿namespace BoVloApp
{
    partial class Calendar
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
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_calendar = new System.Windows.Forms.Panel();
            this.Calendar_grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_calendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Calendar_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calendar Production";
            // 
            // Panel_calendar
            // 
            this.Panel_calendar.Controls.Add(this.label2);
            this.Panel_calendar.Controls.Add(this.Calendar_grid);
            this.Panel_calendar.Location = new System.Drawing.Point(1, -1);
            this.Panel_calendar.Name = "Panel_calendar";
            this.Panel_calendar.Size = new System.Drawing.Size(1688, 788);
            this.Panel_calendar.TabIndex = 2;
            // 
            // Calendar_grid
            // 
            this.Calendar_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Calendar_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Calendar_grid.Location = new System.Drawing.Point(237, 120);
            this.Calendar_grid.Name = "Calendar_grid";
            this.Calendar_grid.RowTemplate.Height = 25;
            this.Calendar_grid.Size = new System.Drawing.Size(912, 554);
            this.Calendar_grid.TabIndex = 3;
            this.Calendar_grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Calendar_grid_CellEndEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1009, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 784);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel_calendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Panel_calendar.ResumeLayout(false);
            this.Panel_calendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Calendar_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_calendar;
        private System.Windows.Forms.DataGridView Calendar_grid;
        private System.Windows.Forms.Label label2;
    }
}