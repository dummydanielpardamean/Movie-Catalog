namespace Movie_Catalog.User_Controls
{
    partial class WatchingListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PositionInformation = new System.Windows.Forms.Label();
            this.MovieTitle = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.LastWatchedInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviePoster
            // 
            this.MoviePoster.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoviePoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviePoster.Image = global::Movie_Catalog.Properties.Resources.pirate;
            this.MoviePoster.Location = new System.Drawing.Point(0, 0);
            this.MoviePoster.Margin = new System.Windows.Forms.Padding(0);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(214, 228);
            this.MoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePoster.TabIndex = 0;
            this.MoviePoster.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PositionInformation, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MoviePoster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MovieTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlayButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LastWatchedInformation, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(214, 352);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PositionInformation
            // 
            this.PositionInformation.AutoSize = true;
            this.PositionInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionInformation.Location = new System.Drawing.Point(0, 297);
            this.PositionInformation.Margin = new System.Windows.Forms.Padding(0);
            this.PositionInformation.Name = "PositionInformation";
            this.PositionInformation.Size = new System.Drawing.Size(214, 17);
            this.PositionInformation.TabIndex = 4;
            this.PositionInformation.Text = "30:00 / 120:00 min";
            // 
            // MovieTitle
            // 
            this.MovieTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitle.Location = new System.Drawing.Point(3, 228);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(208, 52);
            this.MovieTitle.TabIndex = 1;
            this.MovieTitle.Text = "Pirates of the caribean : Dead men tells no tales";
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.PlayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(0, 314);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(0);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(214, 38);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.UseVisualStyleBackColor = false;
            // 
            // LastWatchedInformation
            // 
            this.LastWatchedInformation.AutoSize = true;
            this.LastWatchedInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastWatchedInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastWatchedInformation.Location = new System.Drawing.Point(0, 280);
            this.LastWatchedInformation.Margin = new System.Windows.Forms.Padding(0);
            this.LastWatchedInformation.Name = "LastWatchedInformation";
            this.LastWatchedInformation.Size = new System.Drawing.Size(214, 17);
            this.LastWatchedInformation.TabIndex = 3;
            this.LastWatchedInformation.Text = "--";
            // 
            // LastWatchedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LastWatchedItem";
            this.Size = new System.Drawing.Size(214, 352);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label MovieTitle;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label LastWatchedInformation;
        private System.Windows.Forms.Label PositionInformation;
    }
}
