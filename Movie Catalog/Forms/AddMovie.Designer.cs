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
            this.OpenFileMovieButton = new System.Windows.Forms.Button();
            this.PosterLabel = new System.Windows.Forms.Label();
            this.MoviePathLabel = new System.Windows.Forms.Label();
            this.PosterPreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleAddMovieButton = new System.Windows.Forms.TextBox();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.OpenFileSubtitleButton = new System.Windows.Forms.Button();
            this.SubtitlePathLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionLabelField = new System.Windows.Forms.RichTextBox();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.DTPReleaseYear = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PosterPreviewPictureBox)).BeginInit();
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
            // OpenFileMovieButton
            // 
            this.OpenFileMovieButton.Location = new System.Drawing.Point(112, 41);
            this.OpenFileMovieButton.Name = "OpenFileMovieButton";
            this.OpenFileMovieButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileMovieButton.TabIndex = 1;
            this.OpenFileMovieButton.Text = "Choose file";
            this.OpenFileMovieButton.UseVisualStyleBackColor = true;
            this.OpenFileMovieButton.Click += new System.EventHandler(this.OpenFileButton_Click);
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
            // PosterPreviewPictureBox
            // 
            this.PosterPreviewPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PosterPreviewPictureBox.Image = global::Movie_Catalog.Properties.Resources.none_flowers;
            this.PosterPreviewPictureBox.Location = new System.Drawing.Point(113, 80);
            this.PosterPreviewPictureBox.Name = "PosterPreviewPictureBox";
            this.PosterPreviewPictureBox.Size = new System.Drawing.Size(139, 189);
            this.PosterPreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PosterPreviewPictureBox.TabIndex = 5;
            this.PosterPreviewPictureBox.TabStop = false;
            this.PosterPreviewPictureBox.Click += new System.EventHandler(this.PosterPreviewPictureBox_Click);
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
            // TitleAddMovieButton
            // 
            this.TitleAddMovieButton.Location = new System.Drawing.Point(113, 9);
            this.TitleAddMovieButton.Name = "TitleAddMovieButton";
            this.TitleAddMovieButton.Size = new System.Drawing.Size(273, 20);
            this.TitleAddMovieButton.TabIndex = 7;
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
            // OpenFileSubtitleButton
            // 
            this.OpenFileSubtitleButton.Location = new System.Drawing.Point(113, 490);
            this.OpenFileSubtitleButton.Name = "OpenFileSubtitleButton";
            this.OpenFileSubtitleButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileSubtitleButton.TabIndex = 9;
            this.OpenFileSubtitleButton.Text = "Choose file";
            this.OpenFileSubtitleButton.UseVisualStyleBackColor = true;
            this.OpenFileSubtitleButton.Click += new System.EventHandler(this.OpenFileSubtitleButton_Click);
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
            // DescriptionLabelField
            // 
            this.DescriptionLabelField.Location = new System.Drawing.Point(113, 365);
            this.DescriptionLabelField.Name = "DescriptionLabelField";
            this.DescriptionLabelField.Size = new System.Drawing.Size(387, 119);
            this.DescriptionLabelField.TabIndex = 15;
            this.DescriptionLabelField.Text = "";
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
            // DTPReleaseYear
            // 
            this.DTPReleaseYear.CustomFormat = "dd-MM-yyyy";
            this.DTPReleaseYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPReleaseYear.Location = new System.Drawing.Point(113, 297);
            this.DTPReleaseYear.Name = "DTPReleaseYear";
            this.DTPReleaseYear.Size = new System.Drawing.Size(200, 20);
            this.DTPReleaseYear.TabIndex = 17;
            this.DTPReleaseYear.Value = new System.DateTime(2017, 11, 6, 2, 4, 0, 0);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 576);
            this.Controls.Add(this.DTPReleaseYear);
            this.Controls.Add(this.ReleaseYearLabel);
            this.Controls.Add(this.DescriptionLabelField);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SubtitlePathLabel);
            this.Controls.Add(this.OpenFileSubtitleButton);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.TitleAddMovieButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PosterPreviewPictureBox);
            this.Controls.Add(this.MoviePathLabel);
            this.Controls.Add(this.PosterLabel);
            this.Controls.Add(this.OpenFileMovieButton);
            this.Controls.Add(this.MovieLabel);
            this.Name = "AddMovie";
            this.RightToLeftLayout = true;
            this.Text = "AddMovie";
            ((System.ComponentModel.ISupportInitialize)(this.PosterPreviewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.Button OpenFileMovieButton;
        private System.Windows.Forms.Label PosterLabel;
        private System.Windows.Forms.Label MoviePathLabel;
        private System.Windows.Forms.PictureBox PosterPreviewPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleAddMovieButton;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Button OpenFileSubtitleButton;
        private System.Windows.Forms.Label SubtitlePathLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox DescriptionLabelField;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.DateTimePicker DTPReleaseYear;
    }
}