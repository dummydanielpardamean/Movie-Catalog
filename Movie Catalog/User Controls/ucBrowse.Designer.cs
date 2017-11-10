namespace Movie_Catalog.User_Controls
{
    partial class ucBrowse
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
            this.FlowLayoutBrowse = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FlowLayoutBrowse
            // 
            this.FlowLayoutBrowse.AutoScroll = true;
            this.FlowLayoutBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.FlowLayoutBrowse.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutBrowse.Name = "FlowLayoutBrowse";
            this.FlowLayoutBrowse.Size = new System.Drawing.Size(1265, 619);
            this.FlowLayoutBrowse.TabIndex = 0;
            // 
            // ucBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlowLayoutBrowse);
            this.Name = "ucBrowse";
            this.Size = new System.Drawing.Size(1265, 619);
            this.Load += new System.EventHandler(this.ucBrowse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayoutBrowse;
    }
}
