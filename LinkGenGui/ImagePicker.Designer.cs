namespace LinkGenGui
{
    partial class ImagePicker
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
            this.ImagePathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ScaleBar = new System.Windows.Forms.TrackBar();
            this.ScaleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePathTextBox
            // 
            this.ImagePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePathTextBox.Location = new System.Drawing.Point(4, 4);
            this.ImagePathTextBox.Name = "ImagePathTextBox";
            this.ImagePathTextBox.ReadOnly = true;
            this.ImagePathTextBox.Size = new System.Drawing.Size(94, 20);
            this.ImagePathTextBox.TabIndex = 0;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(103, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(36, 22);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ScaleBar
            // 
            this.ScaleBar.Location = new System.Drawing.Point(4, 31);
            this.ScaleBar.Maximum = 105;
            this.ScaleBar.Minimum = 6;
            this.ScaleBar.Name = "ScaleBar";
            this.ScaleBar.Size = new System.Drawing.Size(135, 45);
            this.ScaleBar.SmallChange = 5;
            this.ScaleBar.TabIndex = 2;
            this.ScaleBar.TickFrequency = 20;
            this.ScaleBar.Value = 75;
            this.ScaleBar.Scroll += new System.EventHandler(this.ScaleBar_Scroll);
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Location = new System.Drawing.Point(43, 63);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(60, 13);
            this.ScaleLabel.TabIndex = 3;
            this.ScaleLabel.Text = "Scale: 75%";
            // 
            // ImagePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScaleLabel);
            this.Controls.Add(this.ScaleBar);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ImagePathTextBox);
            this.Name = "ImagePicker";
            this.Size = new System.Drawing.Size(144, 82);
            ((System.ComponentModel.ISupportInitialize)(this.ScaleBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImagePathTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TrackBar ScaleBar;
        private System.Windows.Forms.Label ScaleLabel;
    }
}
