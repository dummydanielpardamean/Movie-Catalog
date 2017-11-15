namespace Movie_Catalog
{
    partial class AddMovie
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
            this.MovieLabel = new System.Windows.Forms.Label();
            this.MovieFile = new System.Windows.Forms.Button();
            this.PosterLabel = new System.Windows.Forms.Label();
            this.MoviePathLabel = new System.Windows.Forms.Label();
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieTitle = new System.Windows.Forms.TextBox();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.MovieSubtitle = new System.Windows.Forms.Button();
            this.SubtitlePathLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.MovieDescription = new System.Windows.Forms.RichTextBox();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.MovieReleaseYear = new System.Windows.Forms.DateTimePicker();
            this.MovieID = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieLabel.Location = new System.Drawing.Point(11, 44);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(45, 17);
            this.MovieLabel.TabIndex = 0;
            this.MovieLabel.Text = "Movie";
            this.MovieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieFile
            // 
            this.MovieFile.Location = new System.Drawing.Point(112, 41);
            this.MovieFile.Name = "MovieFile";
            this.MovieFile.Size = new System.Drawing.Size(75, 23);
            this.MovieFile.TabIndex = 1;
            this.MovieFile.Text = "Choose file";
            this.MovieFile.UseVisualStyleBackColor = true;
            this.MovieFile.Click += new System.EventHandler(this.MovieFile_Click);
            // 
            // PosterLabel
            // 
            this.PosterLabel.AutoSize = true;
            this.PosterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosterLabel.Location = new System.Drawing.Point(11, 80);
            this.PosterLabel.Name = "PosterLabel";
            this.PosterLabel.Size = new System.Drawing.Size(49, 17);
            this.PosterLabel.TabIndex = 2;
            this.PosterLabel.Text = "Poster";
            this.PosterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoviePathLabel
            // 
            this.MoviePathLabel.AutoSize = true;
            this.MoviePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviePathLabel.Location = new System.Drawing.Point(205, 44);
            this.MoviePathLabel.Name = "MoviePathLabel";
            this.MoviePathLabel.Size = new System.Drawing.Size(0, 17);
            this.MoviePathLabel.TabIndex = 4;
            this.MoviePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoviePoster
            // 
            this.MoviePoster.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoviePoster.Image = global::Movie_Catalog.Properties.Resources.none_flowers;
            this.MoviePoster.Location = new System.Drawing.Point(113, 80);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(139, 189);
            this.MoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePoster.TabIndex = 5;
            this.MoviePoster.TabStop = false;
            this.MoviePoster.Click += new System.EventHandler(this.MoviePoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieTitle
            // 
            this.MovieTitle.Location = new System.Drawing.Point(113, 9);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(273, 20);
            this.MovieTitle.TabIndex = 7;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(13, 493);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(72, 17);
            this.SubtitleLabel.TabIndex = 8;
            this.SubtitleLabel.Text = "Subtitle(s)";
            this.SubtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieSubtitle
            // 
            this.MovieSubtitle.Location = new System.Drawing.Point(113, 490);
            this.MovieSubtitle.Name = "MovieSubtitle";
            this.MovieSubtitle.Size = new System.Drawing.Size(75, 23);
            this.MovieSubtitle.TabIndex = 9;
            this.MovieSubtitle.Text = "Choose file";
            this.MovieSubtitle.UseVisualStyleBackColor = true;
            this.MovieSubtitle.Click += new System.EventHandler(this.MovieSubtitle_Click);
            // 
            // SubtitlePathLabel
            // 
            this.SubtitlePathLabel.AutoSize = true;
            this.SubtitlePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitlePathLabel.Location = new System.Drawing.Point(206, 493);
            this.SubtitlePathLabel.Name = "SubtitlePathLabel";
            this.SubtitlePathLabel.Size = new System.Drawing.Size(0, 17);
            this.SubtitlePathLabel.TabIndex = 10;
            this.SubtitlePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(254, 534);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(132, 31);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(403, 7);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Find online";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(13, 365);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieDescription
            // 
            this.MovieDescription.Location = new System.Drawing.Point(113, 365);
            this.MovieDescription.Name = "MovieDescription";
            this.MovieDescription.Size = new System.Drawing.Size(387, 119);
            this.MovieDescription.TabIndex = 15;
            this.MovieDescription.Text = "";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseYearLabel.Location = new System.Drawing.Point(13, 297);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(92, 17);
            this.ReleaseYearLabel.TabIndex = 16;
            this.ReleaseYearLabel.Text = "Release year";
            this.ReleaseYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieReleaseYear
            // 
            this.MovieReleaseYear.CustomFormat = "dd-MM-yyyy";
            this.MovieReleaseYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MovieReleaseYear.Location = new System.Drawing.Point(113, 297);
            this.MovieReleaseYear.Name = "MovieReleaseYear";
            this.MovieReleaseYear.Size = new System.Drawing.Size(200, 20);
            this.MovieReleaseYear.TabIndex = 17;
            this.MovieReleaseYear.Value = new System.DateTime(2017, 11, 6, 2, 4, 0, 0);
            // 
            // MovieID
            // 
            this.MovieID.Location = new System.Drawing.Point(721, 9);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(61, 20);
            this.MovieID.TabIndex = 18;
            this.MovieID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MovieID_KeyPress);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(694, 10);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 17);
            this.IDLabel.TabIndex = 19;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 576);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.MovieID);
            this.Controls.Add(this.MovieReleaseYear);
            this.Controls.Add(this.ReleaseYearLabel);
            this.Controls.Add(this.MovieDescription);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SubtitlePathLabel);
            this.Controls.Add(this.MovieSubtitle);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoviePoster);
            this.Controls.Add(this.MoviePathLabel);
            this.Controls.Add(this.PosterLabel);
            this.Controls.Add(this.MovieFile);
            this.Controls.Add(this.MovieLabel);
            this.Name = "AddMovie";
            this.RightToLeftLayout = true;
            this.Text = "6";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.Button MovieFile;
        private System.Windows.Forms.Label PosterLabel;
        private System.Windows.Forms.Label MoviePathLabel;
        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MovieTitle;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Button MovieSubtitle;
        private System.Windows.Forms.Label SubtitlePathLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox MovieDescription;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.DateTimePicker MovieReleaseYear;
        private System.Windows.Forms.TextBox MovieID;
        private System.Windows.Forms.Label IDLabel;
    }
}