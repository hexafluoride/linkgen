namespace LinkGenGui
{
    partial class Form1
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
            this.DisplayBox = new System.Windows.Forms.PictureBox();
            this.TopPanelGroup = new System.Windows.Forms.GroupBox();
            this.TopPanelEmptyRadio = new System.Windows.Forms.RadioButton();
            this.TopImagePicker = new LinkGenGui.ImagePicker();
            this.TopPanelImageRadio = new System.Windows.Forms.RadioButton();
            this.TopPanelTextRadio = new System.Windows.Forms.RadioButton();
            this.TopPanelText = new System.Windows.Forms.TextBox();
            this.RightPanelGroup = new System.Windows.Forms.GroupBox();
            this.RightPanelEmptyRadio = new System.Windows.Forms.RadioButton();
            this.RightImagePicker = new LinkGenGui.ImagePicker();
            this.RightPanelImageRadio = new System.Windows.Forms.RadioButton();
            this.RightPanelLockRadio = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PathPickerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FilenameText = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.WidthInput = new System.Windows.Forms.NumericUpDown();
            this.HeightInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.LockColorPicker = new LinkGenGui.ColorPicker();
            this.LineColorPicker = new LinkGenGui.ColorPicker();
            this.TagColorPicker = new LinkGenGui.ColorPicker();
            this.FillColorPicker = new LinkGenGui.ColorPicker();
            this.InnerFrameColorPicker = new LinkGenGui.ColorPicker();
            this.OuterFrameColorPicker = new LinkGenGui.ColorPicker();
            this.TextColorPicker = new LinkGenGui.ColorPicker();
            this.LeftPanelGroup = new System.Windows.Forms.GroupBox();
            this.LeftPanelEmptyRadio = new System.Windows.Forms.RadioButton();
            this.LeftImagePicker = new LinkGenGui.ImagePicker();
            this.LeftPanelImageRadio = new System.Windows.Forms.RadioButton();
            this.LeftPanelLinesRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).BeginInit();
            this.TopPanelGroup.SuspendLayout();
            this.RightPanelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInput)).BeginInit();
            this.LeftPanelGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayBox
            // 
            this.DisplayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayBox.Location = new System.Drawing.Point(224, 12);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(437, 450);
            this.DisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayBox.TabIndex = 0;
            this.DisplayBox.TabStop = false;
            // 
            // TopPanelGroup
            // 
            this.TopPanelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TopPanelGroup.Controls.Add(this.TopPanelEmptyRadio);
            this.TopPanelGroup.Controls.Add(this.TopImagePicker);
            this.TopPanelGroup.Controls.Add(this.TopPanelImageRadio);
            this.TopPanelGroup.Controls.Add(this.TopPanelTextRadio);
            this.TopPanelGroup.Controls.Add(this.TopPanelText);
            this.TopPanelGroup.Location = new System.Drawing.Point(13, 13);
            this.TopPanelGroup.Name = "TopPanelGroup";
            this.TopPanelGroup.Size = new System.Drawing.Size(200, 450);
            this.TopPanelGroup.TabIndex = 1;
            this.TopPanelGroup.TabStop = false;
            this.TopPanelGroup.Text = "Top panel";
            // 
            // TopPanelEmptyRadio
            // 
            this.TopPanelEmptyRadio.AutoSize = true;
            this.TopPanelEmptyRadio.Location = new System.Drawing.Point(7, 169);
            this.TopPanelEmptyRadio.Name = "TopPanelEmptyRadio";
            this.TopPanelEmptyRadio.Size = new System.Drawing.Size(54, 17);
            this.TopPanelEmptyRadio.TabIndex = 5;
            this.TopPanelEmptyRadio.TabStop = true;
            this.TopPanelEmptyRadio.Text = "Empty";
            this.TopPanelEmptyRadio.UseVisualStyleBackColor = true;
            // 
            // TopImagePicker
            // 
            this.TopImagePicker.Filename = null;
            this.TopImagePicker.Location = new System.Drawing.Point(60, 80);
            this.TopImagePicker.Name = "TopImagePicker";
            this.TopImagePicker.Size = new System.Drawing.Size(134, 83);
            this.TopImagePicker.TabIndex = 4;
            // 
            // TopPanelImageRadio
            // 
            this.TopPanelImageRadio.AutoSize = true;
            this.TopPanelImageRadio.Location = new System.Drawing.Point(7, 85);
            this.TopPanelImageRadio.Name = "TopPanelImageRadio";
            this.TopPanelImageRadio.Size = new System.Drawing.Size(54, 17);
            this.TopPanelImageRadio.TabIndex = 3;
            this.TopPanelImageRadio.TabStop = true;
            this.TopPanelImageRadio.Text = "Image";
            this.TopPanelImageRadio.UseVisualStyleBackColor = true;
            // 
            // TopPanelTextRadio
            // 
            this.TopPanelTextRadio.AutoSize = true;
            this.TopPanelTextRadio.Checked = true;
            this.TopPanelTextRadio.Location = new System.Drawing.Point(7, 20);
            this.TopPanelTextRadio.Name = "TopPanelTextRadio";
            this.TopPanelTextRadio.Size = new System.Drawing.Size(46, 17);
            this.TopPanelTextRadio.TabIndex = 2;
            this.TopPanelTextRadio.TabStop = true;
            this.TopPanelTextRadio.Text = "Text";
            this.TopPanelTextRadio.UseVisualStyleBackColor = true;
            // 
            // TopPanelText
            // 
            this.TopPanelText.Location = new System.Drawing.Point(60, 16);
            this.TopPanelText.Multiline = true;
            this.TopPanelText.Name = "TopPanelText";
            this.TopPanelText.Size = new System.Drawing.Size(134, 59);
            this.TopPanelText.TabIndex = 1;
            this.TopPanelText.Text = "Chain\r\nLink";
            // 
            // RightPanelGroup
            // 
            this.RightPanelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanelGroup.Controls.Add(this.RightPanelEmptyRadio);
            this.RightPanelGroup.Controls.Add(this.RightImagePicker);
            this.RightPanelGroup.Controls.Add(this.RightPanelImageRadio);
            this.RightPanelGroup.Controls.Add(this.RightPanelLockRadio);
            this.RightPanelGroup.Location = new System.Drawing.Point(667, 12);
            this.RightPanelGroup.Name = "RightPanelGroup";
            this.RightPanelGroup.Size = new System.Drawing.Size(200, 219);
            this.RightPanelGroup.TabIndex = 2;
            this.RightPanelGroup.TabStop = false;
            this.RightPanelGroup.Text = "Right panel";
            // 
            // RightPanelEmptyRadio
            // 
            this.RightPanelEmptyRadio.AutoSize = true;
            this.RightPanelEmptyRadio.Location = new System.Drawing.Point(7, 125);
            this.RightPanelEmptyRadio.Name = "RightPanelEmptyRadio";
            this.RightPanelEmptyRadio.Size = new System.Drawing.Size(54, 17);
            this.RightPanelEmptyRadio.TabIndex = 11;
            this.RightPanelEmptyRadio.TabStop = true;
            this.RightPanelEmptyRadio.Text = "Empty";
            this.RightPanelEmptyRadio.UseVisualStyleBackColor = true;
            // 
            // RightImagePicker
            // 
            this.RightImagePicker.Filename = null;
            this.RightImagePicker.Location = new System.Drawing.Point(57, 35);
            this.RightImagePicker.Name = "RightImagePicker";
            this.RightImagePicker.Size = new System.Drawing.Size(137, 84);
            this.RightImagePicker.TabIndex = 10;
            // 
            // RightPanelImageRadio
            // 
            this.RightPanelImageRadio.AutoSize = true;
            this.RightPanelImageRadio.Location = new System.Drawing.Point(7, 39);
            this.RightPanelImageRadio.Name = "RightPanelImageRadio";
            this.RightPanelImageRadio.Size = new System.Drawing.Size(54, 17);
            this.RightPanelImageRadio.TabIndex = 9;
            this.RightPanelImageRadio.Text = "Image";
            this.RightPanelImageRadio.UseVisualStyleBackColor = true;
            // 
            // RightPanelLockRadio
            // 
            this.RightPanelLockRadio.AutoSize = true;
            this.RightPanelLockRadio.Checked = true;
            this.RightPanelLockRadio.Location = new System.Drawing.Point(7, 17);
            this.RightPanelLockRadio.Name = "RightPanelLockRadio";
            this.RightPanelLockRadio.Size = new System.Drawing.Size(49, 17);
            this.RightPanelLockRadio.TabIndex = 0;
            this.RightPanelLockRadio.TabStop = true;
            this.RightPanelLockRadio.Text = "Lock";
            this.RightPanelLockRadio.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(648, 533);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PathBox
            // 
            this.PathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathBox.Location = new System.Drawing.Point(90, 535);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(355, 20);
            this.PathBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Save location:";
            // 
            // PathPickerButton
            // 
            this.PathPickerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PathPickerButton.Location = new System.Drawing.Point(451, 534);
            this.PathPickerButton.Name = "PathPickerButton";
            this.PathPickerButton.Size = new System.Drawing.Size(27, 23);
            this.PathPickerButton.TabIndex = 6;
            this.PathPickerButton.Text = "...";
            this.PathPickerButton.UseVisualStyleBackColor = true;
            this.PathPickerButton.Click += new System.EventHandler(this.PathPickerButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filename:";
            // 
            // FilenameText
            // 
            this.FilenameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FilenameText.Location = new System.Drawing.Point(542, 535);
            this.FilenameText.Name = "FilenameText";
            this.FilenameText.Size = new System.Drawing.Size(100, 20);
            this.FilenameText.TabIndex = 8;
            this.FilenameText.Text = "link.png";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(768, 533);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(99, 23);
            this.GenerateButton.TabIndex = 16;
            this.GenerateButton.Text = "Preview";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // WidthInput
            // 
            this.WidthInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WidthInput.Location = new System.Drawing.Point(794, 470);
            this.WidthInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WidthInput.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(73, 20);
            this.WidthInput.TabIndex = 17;
            this.WidthInput.Value = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            this.WidthInput.ValueChanged += new System.EventHandler(this.UpdateResolution);
            // 
            // HeightInput
            // 
            this.HeightInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightInput.Location = new System.Drawing.Point(794, 507);
            this.HeightInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.HeightInput.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(73, 20);
            this.HeightInput.TabIndex = 18;
            this.HeightInput.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.HeightInput.ValueChanged += new System.EventHandler(this.UpdateResolution);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "×";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(728, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Resolution:";
            // 
            // WarningLabel
            // 
            this.WarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(648, 507);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(140, 20);
            this.WarningLabel.TabIndex = 21;
            // 
            // LockColorPicker
            // 
            this.LockColorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LockColorPicker.ColorName = "Lock";
            this.LockColorPicker.CurrentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(254)))));
            this.LockColorPicker.Location = new System.Drawing.Point(751, 569);
            this.LockColorPicker.Name = "LockColorPicker";
            this.LockColorPicker.Size = new System.Drawing.Size(117, 65);
            this.LockColorPicker.TabIndex = 15;
            // 
            // LineColorPicker
            // 
            this.LineColorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LineColorPicker.ColorName = "Lines";
            this.LineColorPicker.CurrentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(254)))));
            this.LineColorPicker.Location = new System.Drawing.Point(628, 569);
            this.LineColorPicker.Name = "LineColorPicker";
            this.LineColorPicker.Size = new System.Drawing.Size(117, 65);
            this.LineColorPicker.TabIndex = 14;
            // 
            // TagColorPicker
            // 
            this.TagColorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TagColorPicker.ColorName = "Tags";
            this.TagColorPicker.CurrentColor = System.Drawing.Color.Black;
            this.TagColorPicker.Location = new System.Drawing.Point(505, 569);
            this.TagColorPicker.Name = "TagColorPicker";
            this.TagColorPicker.Size = new System.Drawing.Size(117, 65);
            this.TagColorPicker.TabIndex = 13;
            // 
            // FillColorPicker
            // 
            this.FillColorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FillColorPicker.ColorName = "Panel fill";
            this.FillColorPicker.CurrentColor = System.Drawing.Color.White;
            this.FillColorPicker.Location = new System.Drawing.Point(382, 569);
            this.FillColorPicker.Name = "FillColorPicker";
            this.FillColorPicker.Size = new System.Drawing.Size(117, 65);
            this.FillColorPicker.TabIndex = 12;
            // 
            // InnerFrameColorPicker
            // 
            this.InnerFrameColorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InnerFrameColorPicker.ColorName = "Inner frame";
            this.InnerFrameColorPicker.CurrentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.InnerFrameColorPicker.Location = new System.Drawing.Point(259, 569);
            this.InnerFrameColorPicker.Name = "InnerFrameColorPicker";
            this.InnerFrameColorPicker.Size = new System.Drawing.Size(117, 65);
            this.InnerFrameColorPicker.TabIndex = 11;
            // 
            // OuterFrameColorPicker
            // 
            this.OuterFrameColorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OuterFrameColorPicker.ColorName = "Outer frame";
            this.OuterFrameColorPicker.CurrentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(254)))));
            this.OuterFrameColorPicker.Location = new System.Drawing.Point(136, 569);
            this.OuterFrameColorPicker.Name = "OuterFrameColorPicker";
            this.OuterFrameColorPicker.Size = new System.Drawing.Size(117, 65);
            this.OuterFrameColorPicker.TabIndex = 10;
            // 
            // TextColorPicker
            // 
            this.TextColorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextColorPicker.ColorName = "Text";
            this.TextColorPicker.CurrentColor = System.Drawing.Color.Black;
            this.TextColorPicker.Location = new System.Drawing.Point(13, 569);
            this.TextColorPicker.Name = "TextColorPicker";
            this.TextColorPicker.Size = new System.Drawing.Size(117, 65);
            this.TextColorPicker.TabIndex = 9;
            // 
            // LeftPanelGroup
            // 
            this.LeftPanelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftPanelGroup.Controls.Add(this.LeftPanelEmptyRadio);
            this.LeftPanelGroup.Controls.Add(this.LeftImagePicker);
            this.LeftPanelGroup.Controls.Add(this.LeftPanelImageRadio);
            this.LeftPanelGroup.Controls.Add(this.LeftPanelLinesRadio);
            this.LeftPanelGroup.Location = new System.Drawing.Point(668, 237);
            this.LeftPanelGroup.Name = "LeftPanelGroup";
            this.LeftPanelGroup.Size = new System.Drawing.Size(200, 225);
            this.LeftPanelGroup.TabIndex = 12;
            this.LeftPanelGroup.TabStop = false;
            this.LeftPanelGroup.Text = "Left panel";
            // 
            // LeftPanelEmptyRadio
            // 
            this.LeftPanelEmptyRadio.AutoSize = true;
            this.LeftPanelEmptyRadio.Location = new System.Drawing.Point(7, 125);
            this.LeftPanelEmptyRadio.Name = "LeftPanelEmptyRadio";
            this.LeftPanelEmptyRadio.Size = new System.Drawing.Size(54, 17);
            this.LeftPanelEmptyRadio.TabIndex = 11;
            this.LeftPanelEmptyRadio.TabStop = true;
            this.LeftPanelEmptyRadio.Text = "Empty";
            this.LeftPanelEmptyRadio.UseVisualStyleBackColor = true;
            // 
            // LeftImagePicker
            // 
            this.LeftImagePicker.Filename = null;
            this.LeftImagePicker.Location = new System.Drawing.Point(57, 35);
            this.LeftImagePicker.Name = "LeftImagePicker";
            this.LeftImagePicker.Size = new System.Drawing.Size(137, 84);
            this.LeftImagePicker.TabIndex = 10;
            // 
            // LeftPanelImageRadio
            // 
            this.LeftPanelImageRadio.AutoSize = true;
            this.LeftPanelImageRadio.Location = new System.Drawing.Point(7, 39);
            this.LeftPanelImageRadio.Name = "LeftPanelImageRadio";
            this.LeftPanelImageRadio.Size = new System.Drawing.Size(54, 17);
            this.LeftPanelImageRadio.TabIndex = 9;
            this.LeftPanelImageRadio.Text = "Image";
            this.LeftPanelImageRadio.UseVisualStyleBackColor = true;
            // 
            // LeftPanelLinesRadio
            // 
            this.LeftPanelLinesRadio.AutoSize = true;
            this.LeftPanelLinesRadio.Checked = true;
            this.LeftPanelLinesRadio.Location = new System.Drawing.Point(7, 17);
            this.LeftPanelLinesRadio.Name = "LeftPanelLinesRadio";
            this.LeftPanelLinesRadio.Size = new System.Drawing.Size(50, 17);
            this.LeftPanelLinesRadio.TabIndex = 0;
            this.LeftPanelLinesRadio.TabStop = true;
            this.LeftPanelLinesRadio.Text = "Lines";
            this.LeftPanelLinesRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 646);
            this.Controls.Add(this.LeftPanelGroup);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.LockColorPicker);
            this.Controls.Add(this.LineColorPicker);
            this.Controls.Add(this.TagColorPicker);
            this.Controls.Add(this.FillColorPicker);
            this.Controls.Add(this.InnerFrameColorPicker);
            this.Controls.Add(this.OuterFrameColorPicker);
            this.Controls.Add(this.TextColorPicker);
            this.Controls.Add(this.FilenameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PathPickerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RightPanelGroup);
            this.Controls.Add(this.TopPanelGroup);
            this.Controls.Add(this.DisplayBox);
            this.Name = "Form1";
            this.Text = "LinkGen";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).EndInit();
            this.TopPanelGroup.ResumeLayout(false);
            this.TopPanelGroup.PerformLayout();
            this.RightPanelGroup.ResumeLayout(false);
            this.RightPanelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInput)).EndInit();
            this.LeftPanelGroup.ResumeLayout(false);
            this.LeftPanelGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DisplayBox;
        private System.Windows.Forms.GroupBox TopPanelGroup;
        private System.Windows.Forms.GroupBox RightPanelGroup;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PathPickerButton;
        private System.Windows.Forms.RadioButton TopPanelImageRadio;
        private System.Windows.Forms.RadioButton TopPanelTextRadio;
        private System.Windows.Forms.TextBox TopPanelText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilenameText;
        private ColorPicker TextColorPicker;
        private ColorPicker OuterFrameColorPicker;
        private ColorPicker InnerFrameColorPicker;
        private ColorPicker FillColorPicker;
        private ColorPicker TagColorPicker;
        private ColorPicker LineColorPicker;
        private ColorPicker LockColorPicker;
        private System.Windows.Forms.RadioButton RightPanelLockRadio;
        private System.Windows.Forms.RadioButton RightPanelImageRadio;
        private System.Windows.Forms.Button GenerateButton;
        private ImagePicker TopImagePicker;
        private ImagePicker RightImagePicker;
        private System.Windows.Forms.RadioButton TopPanelEmptyRadio;
        private System.Windows.Forms.RadioButton RightPanelEmptyRadio;
        private System.Windows.Forms.NumericUpDown WidthInput;
        private System.Windows.Forms.NumericUpDown HeightInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.GroupBox LeftPanelGroup;
        private System.Windows.Forms.RadioButton LeftPanelEmptyRadio;
        private ImagePicker LeftImagePicker;
        private System.Windows.Forms.RadioButton LeftPanelImageRadio;
        private System.Windows.Forms.RadioButton LeftPanelLinesRadio;
    }
}

