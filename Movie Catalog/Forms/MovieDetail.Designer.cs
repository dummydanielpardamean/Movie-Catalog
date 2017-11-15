namespace Movie_Catalog
{
    partial class MovieDetail
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
            this.MovieTitle = new System.Windows.Forms.Label();
            this.MovieDescription = new System.Windows.Forms.Label();
            this.PlayMovieButton = new System.Windows.Forms.Button();
            this.DeleteMovieButton = new System.Windows.Forms.Button();
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieTitle
            // 
            this.MovieTitle.AutoSize = true;
            this.MovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitle.Location = new System.Drawing.Point(147, 12);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(26, 25);
            this.MovieTitle.TabIndex = 1;
            this.MovieTitle.Text = "--";
            // 
            // MovieDescription
            // 
            this.MovieDescription.Location = new System.Drawing.Point(149, 56);
            this.MovieDescription.Name = "MovieDescription";
            this.MovieDescription.Size = new System.Drawing.Size(351, 164);
            this.MovieDescription.TabIndex = 2;
            this.MovieDescription.Text = "--";
            // 
            // PlayMovieButton
            // 
            this.PlayMovieButton.Location = new System.Drawing.Point(425, 460);
            this.PlayMovieButton.Name = "PlayMovieButton";
            this.PlayMovieButton.Size = new System.Drawing.Size(75, 23);
            this.PlayMovieButton.TabIndex = 3;
            this.PlayMovieButton.Text = "Play";
            this.PlayMovieButton.UseVisualStyleBackColor = true;
            this.PlayMovieButton.Click += new System.EventHandler(this.PlayMovieButton_Click);
            // 
            // DeleteMovieButton
            // 
            this.DeleteMovieButton.Location = new System.Drawing.Point(12, 460);
            this.DeleteMovieButton.Name = "DeleteMovieButton";
            this.DeleteMovieButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteMovieButton.TabIndex = 4;
            this.DeleteMovieButton.Text = "Delete";
            this.DeleteMovieButton.UseVisualStyleBackColor = true;
            this.DeleteMovieButton.Click += new System.EventHandler(this.DeleteMovieButton_Click);
            // 
            // MoviePoster
            // 
            this.MoviePoster.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoviePoster.Image = global::Movie_Catalog.Properties.Resources.none_flowers;
            this.MoviePoster.Location = new System.Drawing.Point(12, 12);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(129, 208);
            this.MoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePoster.TabIndex = 0;
            this.MoviePoster.TabStop = false;
            // 
            // MovieDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 495);
            this.Controls.Add(this.DeleteMovieButton);
            this.Controls.Add(this.PlayMovieButton);
            this.Controls.Add(this.MovieDescription);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.MoviePoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MovieDetail";
            this.Text = "MovieDetail";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.Label MovieTitle;
        private System.Windows.Forms.Label MovieDescription;
        private System.Windows.Forms.Button PlayMovieButton;
        private System.Windows.Forms.Button DeleteMovieButton;
    }
}