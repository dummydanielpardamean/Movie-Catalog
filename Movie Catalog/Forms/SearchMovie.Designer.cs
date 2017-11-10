namespace Movie_Catalog
{
    partial class SearchMovie
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
            this.SearchFieldTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MovieDGV = new System.Windows.Forms.DataGridView();
            this.FetchingStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchFieldTextBox
            // 
            this.SearchFieldTextBox.Location = new System.Drawing.Point(12, 12);
            this.SearchFieldTextBox.Name = "SearchFieldTextBox";
            this.SearchFieldTextBox.Size = new System.Drawing.Size(397, 20);
            this.SearchFieldTextBox.TabIndex = 0;
            this.SearchFieldTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchFieldTextBox_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(416, 8);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MovieDGV
            // 
            this.MovieDGV.AllowUserToAddRows = false;
            this.MovieDGV.AllowUserToDeleteRows = false;
            this.MovieDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDGV.Location = new System.Drawing.Point(12, 38);
            this.MovieDGV.Name = "MovieDGV";
            this.MovieDGV.ReadOnly = true;
            this.MovieDGV.Size = new System.Drawing.Size(790, 327);
            this.MovieDGV.TabIndex = 2;
            // 
            // FetchingStatus
            // 
            this.FetchingStatus.AutoSize = true;
            this.FetchingStatus.Location = new System.Drawing.Point(498, 12);
            this.FetchingStatus.Name = "FetchingStatus";
            this.FetchingStatus.Size = new System.Drawing.Size(0, 13);
            this.FetchingStatus.TabIndex = 3;
            // 
            // SearchMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 377);
            this.Controls.Add(this.FetchingStatus);
            this.Controls.Add(this.MovieDGV);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchFieldTextBox);
            this.Name = "SearchMovie";
            this.Text = "SearchMovie";
            ((System.ComponentModel.ISupportInitialize)(this.MovieDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchFieldTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView MovieDGV;
        private System.Windows.Forms.Label FetchingStatus;
    }
}