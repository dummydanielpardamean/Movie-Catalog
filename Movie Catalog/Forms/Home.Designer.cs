namespace Movie_Catalog
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.WatchingListButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.AddMovieButton);
            this.panel1.Controls.Add(this.BrowseButton);
            this.panel1.Controls.Add(this.WatchingListButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 65);
            this.panel1.TabIndex = 1;
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.BackColor = System.Drawing.Color.Transparent;
            this.AddMovieButton.FlatAppearance.BorderSize = 0;
            this.AddMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMovieButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddMovieButton.Image = global::Movie_Catalog.Properties.Resources.add_movie_icon;
            this.AddMovieButton.Location = new System.Drawing.Point(1145, 0);
            this.AddMovieButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(120, 65);
            this.AddMovieButton.TabIndex = 3;
            this.AddMovieButton.Text = "Add Movie";
            this.AddMovieButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddMovieButton.UseVisualStyleBackColor = false;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.Transparent;
            this.BrowseButton.FlatAppearance.BorderSize = 0;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BrowseButton.Image = global::Movie_Catalog.Properties.Resources.browse_icon;
            this.BrowseButton.Location = new System.Drawing.Point(208, 0);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(120, 65);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // WatchingListButton
            // 
            this.WatchingListButton.BackColor = System.Drawing.Color.Transparent;
            this.WatchingListButton.FlatAppearance.BorderSize = 0;
            this.WatchingListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WatchingListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WatchingListButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WatchingListButton.Image = global::Movie_Catalog.Properties.Resources.watching_icon;
            this.WatchingListButton.Location = new System.Drawing.Point(82, 0);
            this.WatchingListButton.Margin = new System.Windows.Forms.Padding(0);
            this.WatchingListButton.Name = "WatchingListButton";
            this.WatchingListButton.Size = new System.Drawing.Size(120, 65);
            this.WatchingListButton.TabIndex = 1;
            this.WatchingListButton.Text = "Watching List";
            this.WatchingListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WatchingListButton.UseVisualStyleBackColor = false;
            this.WatchingListButton.Click += new System.EventHandler(this.WatchingListButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Movie_Catalog.Properties.Resources.movie_icon;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(0, 63);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1265, 619);
            this.panelContainer.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button WatchingListButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button AddMovieButton;
    }
}