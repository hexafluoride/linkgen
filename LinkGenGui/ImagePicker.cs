using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ImageMagick;

namespace LinkGenGui
{
    public partial class ImagePicker : UserControl
    {
        public string Filename { get; set; }
        public double Scale { get { return ScaleBar.Value - 5; } }

        public ImagePicker()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            dialog.RestoreDirectory = true;
            dialog.Title = "Pick image...";
            dialog.AutoUpgradeEnabled = true;

            dialog.ShowDialog();
            
            if(File.Exists(dialog.FileName))
            {
                Filename = dialog.FileName;
                ImagePathTextBox.Text = Path.GetFileName(Filename);
            }
        }

        private void ScaleBar_Scroll(object sender, EventArgs e)
        {
            ScaleLabel.Text = string.Format("Scale: {0}%", (int)Scale);
        }
    }
}
