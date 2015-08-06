namespace FairManagementApp.UI
{
    partial class ZoneVisitorNumberUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zoneVisitorNumberListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.totalVisitorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zoneVisitorNumberListView);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zone Visitor Number";
            // 
            // zoneVisitorNumberListView
            // 
            this.zoneVisitorNumberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.zoneVisitorNumberListView.FullRowSelect = true;
            this.zoneVisitorNumberListView.GridLines = true;
            this.zoneVisitorNumberListView.Location = new System.Drawing.Point(18, 26);
            this.zoneVisitorNumberListView.Name = "zoneVisitorNumberListView";
            this.zoneVisitorNumberListView.Size = new System.Drawing.Size(294, 229);
            this.zoneVisitorNumberListView.TabIndex = 0;
            this.zoneVisitorNumberListView.UseCompatibleStateImageBehavior = false;
            this.zoneVisitorNumberListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zone Name";
            this.columnHeader1.Width = 184;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No of Visitor";
            this.columnHeader2.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Visitor";
            // 
            // totalVisitorTextBox
            // 
            this.totalVisitorTextBox.Location = new System.Drawing.Point(197, 309);
            this.totalVisitorTextBox.Name = "totalVisitorTextBox";
            this.totalVisitorTextBox.Size = new System.Drawing.Size(142, 20);
            this.totalVisitorTextBox.TabIndex = 2;
            // 
            // ZoneVisitorNumberUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 357);
            this.Controls.Add(this.totalVisitorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZoneVisitorNumberUI";
            this.Text = "Zone Visitor Number";
            this.Load += new System.EventHandler(this.ZoneVisitorNumberUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView zoneVisitorNumberListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalVisitorTextBox;
    }
}