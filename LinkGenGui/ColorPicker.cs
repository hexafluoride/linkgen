using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;

namespace LinkGenGui
{
    public partial class ColorPicker : UserControl
    {
        public Color CurrentColor { get; set; }
        public string ColorName { get; set; }

        public ColorPicker()
        {
            InitializeComponent();
        }

        public ColorPicker(string name, Color starting_color) :
            this()
        {
            CurrentColor = starting_color;
            ColorName = name;
        }

        public void UpdateColor()
        {
            ColorDisplay.BackColor = CurrentColor;
            ColorPickerCache.Add(CurrentColor);
        }

        private void ColorPickerButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = CurrentColor;
            dialog.FullOpen = true;
            dialog.CustomColors = ColorPickerCache.GetDialogList();
            var result = dialog.ShowDialog();

            CurrentColor = dialog.Color;
            UpdateColor();
        }

        private void ColorPicker_Load(object sender, EventArgs e)
        {
            UpdateColor();
            ColorPickerButton.Text = ColorName;
        }
    }

    public static class ColorPickerCache
    {
        public static List<Color> Colors = new List<Color>();

        public static void Add(Color color)
        {
            if(!Colors.Contains(color))
                Colors.Add(color);
        }

        public static int[] GetDialogList()
        {
            return Colors.Select(ToBgrInt).ToArray();
        }

        private static int ToBgrInt(Color color)
        {
            return (color.B << 16) | (color.G << 8) | color.R;
        }
    }
}
