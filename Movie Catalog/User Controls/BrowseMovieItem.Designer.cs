namespace Movie_Catalog.User_Controls
{
    partial class BrowseMovieItem
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
            this.MovieTitle = new System.Windows.Forms.Label();
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieTitle
            // 
            this.MovieTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MovieTitle.Location = new System.Drawing.Point(0, 246);
            this.MovieTitle.Margin = new System.Windows.Forms.Padding(0);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(214, 70);
            this.MovieTitle.TabIndex = 1;
            this.MovieTitle.Text = "Spider-Man : Homecoming (2017)";
            // 
            // MoviePoster
            // 
            this.MoviePoster.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoviePoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviePoster.Image = global::Movie_Catalog.Properties.Resources.pirate;
            this.MoviePoster.Location = new System.Drawing.Point(0, 0);
            this.MoviePoster.Margin = new System.Windows.Forms.Padding(0);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(214, 246);
            this.MoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePoster.TabIndex = 0;
            this.MoviePoster.TabStop = false;
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.OpenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenButton.ForeColor = System.Drawing.Color.White;
            this.OpenButton.Location = new System.Drawing.Point(0, 316);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(214, 36);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "OPEN";
            this.OpenButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.OpenButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MovieTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MoviePoster, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(214, 352);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BrowseMovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BrowseMovieItem";
            this.Size = new System.Drawing.Size(214, 352);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.Label MovieTitle;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
