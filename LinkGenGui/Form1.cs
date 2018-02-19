using ImageMagick;
using LinkGen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkGenGui
{
    public partial class Form1 : Form
    {
        ChainLink CurrentLink { get; set; }
        double SaveScale = 0.5;
        double SaveWidth = 1300;
        double SaveHeight = 1500;

        public Form1()
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            CurrentLink = new ChainLink(0.2);

            ColorPickerCache.Add(Color.FromArgb(238, 238, 238));
            ColorPickerCache.Add(Color.FromArgb(0, 168, 254));
            ColorPickerCache.Add(Color.FromArgb(68, 68, 68));
            ColorPickerCache.Add(Color.FromArgb(220, 55, 55));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.Text = "Saving...";
            SaveButton.Enabled = false;
            Enabled = false;

            new Thread((ThreadStart)delegate {
                try
                {
                    UpdateLink();

                    double scale = CurrentLink.GetScalingFactor();
                    CurrentLink.SetSize((int)Math.Round(SaveWidth), (int)Math.Round(SaveHeight));
                    CurrentLink.Draw();
                    CurrentLink.MainImage.Write(Path.Combine(PathBox.Text, FilenameText.Text));
                    CurrentLink.SetScale(scale);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    SaveButton.Text = "Save";
                    SaveButton.Enabled = true;
                    Enabled = true;
                }
            }).Start();
        }

        private void UpdateLink()
        {
            CurrentLink.Text = TopPanelText.Text;
            CurrentLink.OuterLockColor = LockColorPicker.CurrentColor;
            CurrentLink.TextColor = TextColorPicker.CurrentColor;
            CurrentLink.FrameColor = OuterFrameColorPicker.CurrentColor;
            CurrentLink.InnerFrameColor = InnerFrameColorPicker.CurrentColor;
            CurrentLink.TagColor = TagColorPicker.CurrentColor;
            CurrentLink.LineColor = LineColorPicker.CurrentColor;
            CurrentLink.FillColor = FillColorPicker.CurrentColor;

            if (TopPanelImageRadio.Checked)
            {
                CurrentLink.TopPlate = PlateType.Image;
                CurrentLink.TopPlateImage = new MagickImage(TopImagePicker.Filename);
                CurrentLink.TopPlateImagePercentage = TopImagePicker.Scale;
            }
            else if (TopPanelTextRadio.Checked)
            {
                CurrentLink.TopPlate = PlateType.Text;
            }
            else if(TopPanelEmptyRadio.Checked)
            {
                CurrentLink.TopPlate = PlateType.Empty;
            }

            if (RightPanelImageRadio.Checked)
            {
                CurrentLink.RightPlate = PlateType.Image;
                CurrentLink.RightPlateImage = new MagickImage(RightImagePicker.Filename);
                CurrentLink.RightPlateImagePercentage = RightImagePicker.Scale;
            }
            else if (RightPanelLockRadio.Checked)
            {
                CurrentLink.RightPlate = PlateType.Lock;
            }
            else if (RightPanelEmptyRadio.Checked)
            {
                CurrentLink.RightPlate = PlateType.Empty;
            }

            if (LeftPanelImageRadio.Checked)
            {
                CurrentLink.LeftPlate = PlateType.Image;
                CurrentLink.LeftPlateImage = new MagickImage(LeftImagePicker.Filename);
                CurrentLink.LeftPlateImagePercentage = LeftImagePicker.Scale;
            }
            else if (LeftPanelLinesRadio.Checked)
            {
                CurrentLink.LeftPlate = PlateType.Lines;
            }
            else if (LeftPanelEmptyRadio.Checked)
            {
                CurrentLink.LeftPlate = PlateType.Empty;
            }
        }
        
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            UpdateLink();

            CurrentLink.Draw();
            CurrentLink.MainImage.Write("./.temp.png");
            MemoryStream ms = new MemoryStream();
            using (var fs = new FileStream("./.temp.png", FileMode.Open))
            {
                fs.CopyTo(ms);
            }

            DisplayBox.Image = new Bitmap(ms);
            File.Delete("./.temp.png");
        }

        private void UpdateResolution(object sender, EventArgs e)
        {
            if(sender == WidthInput)
            {
                SaveScale = (double)WidthInput.Value / 2600d;
                SaveHeight = SaveScale * 3000d;

                if(HeightInput.Value != (decimal)SaveHeight)
                    HeightInput.Value = (decimal)SaveHeight;
            }
            else if(sender == HeightInput)
            {
                SaveScale = (double)HeightInput.Value / 3000d;
                SaveWidth = SaveScale * 2600d;

                if (WidthInput.Value != (decimal)SaveWidth)
                    WidthInput.Value = (decimal)SaveWidth;
            }

            if(SaveScale > 1)
            {
                WarningLabel.Text = "This might take a long time.";
            }
            else if(SaveScale < 0.1)
            {
                WarningLabel.Text = "Proportions might be wrong.";
            }
            else
            {
                WarningLabel.Text = "";
            }
        }

        private void PathPickerButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;

            dialog.ShowDialog();
            PathBox.Text = dialog.SelectedPath;
        }
    }
}
