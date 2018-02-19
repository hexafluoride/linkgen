namespace LinkGenGui
{
    partial class ColorPicker
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
            this.ColorDisplay = new System.Windows.Forms.PictureBox();
            this.ColorPickerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ColorDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorDisplay
            // 
            this.ColorDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorDisplay.Location = new System.Drawing.Point(4, 4);
            this.ColorDisplay.Name = "ColorDisplay";
            this.ColorDisplay.Size = new System.Drawing.Size(126, 26);
            this.ColorDisplay.TabIndex = 0;
            this.ColorDisplay.TabStop = false;
            // 
            // ColorPickerButton
            // 
            this.ColorPickerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorPickerButton.Location = new System.Drawing.Point(4, 36);
            this.ColorPickerButton.Name = "ColorPickerButton";
            this.ColorPickerButton.Size = new System.Drawing.Size(126, 23);
            this.ColorPickerButton.TabIndex = 1;
            this.ColorPickerButton.Text = "button1";
            this.ColorPickerButton.UseVisualStyleBackColor = true;
            this.ColorPickerButton.Click += new System.EventHandler(this.ColorPickerButton_Click);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorPickerButton);
            this.Controls.Add(this.ColorDisplay);
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(133, 65);
            this.Load += new System.EventHandler(this.ColorPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColorDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ColorDisplay;
        private System.Windows.Forms.Button ColorPickerButton;
    }
}
