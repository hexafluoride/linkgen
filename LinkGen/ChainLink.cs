using ImageMagick;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinkGen
{
    public enum PlateType
    {
        Text, Image, Lines, Lock, Empty
    }

    public enum Plate
    {
        Left, Right, Top
    }

    public class ChainLink
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public MagickImage MainImage { get; set; }
        public string Text { get; set; }
        public MagickColor TextColor { get; set; }

        public int FrameMargin { get; set; }
        public double FrameThickness { get; set; }

        public MagickColor FrameColor { get; set; }
        public MagickColor FillColor { get; set; }

        public double InnerFrameThickness { get; set; }
        public MagickColor InnerFrameColor { get; set; }

        public MagickColor TagColor { get; set; }
        public MagickColor LineColor { get; set; }
        public MagickColor InnerLockColor { get; set; }
        public MagickColor OuterLockColor { get; set; }

        public PlateType LeftPlate = PlateType.Lines;
        public PlateType RightPlate = PlateType.Lock;
        public PlateType TopPlate = PlateType.Text;

        public MagickImage TopPlateImage { get; set; }
        public MagickImage LeftPlateImage { get; set; }
        public MagickImage RightPlateImage { get; set; }
        public double TopPlateImagePercentage { get; set; }
        public double LeftPlateImagePercentage { get; set; }
        public double RightPlateImagePercentage { get; set; }

        public static string InternalResourceLocation = "";

        public bool AutoInnerLockColor = true;

        internal PointD Top;
        internal PointD Bottom;
        internal PointD LeftTop;
        internal PointD LeftBottom;
        internal PointD RightTop;
        internal PointD RightBottom;
        internal PointD Center;

        public static void InitializeResourceLocation()
        {
            InternalResourceLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().FullName), "resources");
        }

        public ChainLink(double scale = 0.5)
        {
            FrameMargin = 50;
            FrameThickness = 40;
            InnerFrameThickness = 25;

            FillColor = new MagickColor("white");
            FrameColor = new MagickColor("#00a8fe");
            TagColor = new MagickColor("black");
            LineColor = new MagickColor("#00a8fe");
            OuterLockColor = new MagickColor("#00a8fe");
            TextColor = new MagickColor("black");
            InnerFrameColor = new MagickColor("#eeeeee");
            //FrameColor = new MagickColor("#dc3737");
            //FillColor = new MagickColor("black");

            //InnerFrameColor = new MagickColor("#444444");

            //TextColor = new MagickColor("white");
            //LineColor = new MagickColor("#dc3737");
            //OuterLockColor = new MagickColor("#dc3737");
            //TagColor = new MagickColor("white");
            var outer_lock_native_color = OuterLockColor.ToColor();

            ColorUtils.ColorToHSV(OuterLockColor, out double hue, out double saturation, out double value);

            //InnerLockColor = new MagickColor(string.Format("hsb({0},{1},{2})", outer_h + 0.09, outer_s + 0.03, outer_l - 0.03));
            //InnerLockColor = ColorUtils.ColorFromHSV(hue, saturation + 0.05, value - 0.1);
            //InnerLockColor = new MagickColor("white");
            //InnerLockColor = MagickColor.

            SetScale(scale);
        }

        public MagickImage LoadInternalImage(string filename)
        {
            string path = Path.Combine(InternalResourceLocation, filename);

            try
            {
                return new MagickImage(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't load resource {0}", filename);
                Console.WriteLine("Calculated path: {0}", path);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                return null;
            }
        }

        public void SetScale(double scale)
        {
            Width = (int)Math.Ceiling(2600d * scale);
            Height = (int)Math.Ceiling(3000d * scale);
        }

        public void SetSize(int width, int height)
        {
            Width = width;
            Height = height;
        }

        private void DrawTopPlate()
        {
            if (TopPlate == PlateType.Text)
            {
                var text = GetText();

                PrepareForPlate(text, Plate.Top, Gravity.West);

                text.Scale(new Percentage(((MainImage.Height / 2d)) / text.Height * 90d));
                //text.Write("text-plate-modified.png");

                MainImage.Composite(text, /*Scale(570, 310)*/new PointD((((MainImage.Width - (Scale(FrameThickness + FrameMargin * 2))) - text.Width) / 2) + Scale(FrameMargin + FrameThickness), Scale(FrameMargin + FrameThickness)), CompositeOperator.Over);
            }
            else if (TopPlate == PlateType.Image)
            {
                //TopPlateImage.Scale(new Percentage(((MainImage.Width / 2d)) / TopPlateImage.Width * 100d));
                PrepareForPlate(TopPlateImage, Plate.Top);
                TopPlateImage.Scale(new Percentage(((MainImage.Height / 2d)) / TopPlateImage.Height * TopPlateImagePercentage));

                MainImage.Composite(TopPlateImage, /*Scale(570, 310)*/new PointD((((MainImage.Width - (Scale((FrameMargin + FrameMargin) * 2))) - TopPlateImage.Width) / 2) + Scale(FrameMargin + FrameThickness), /*Scale(FrameMargin) + */(((100d - TopPlateImagePercentage) / 200d) * Center.Y)), CompositeOperator.Over);
            }
            else if(TopPlate == PlateType.Empty)
            {
                return;
            }
        }

        private void DrawLeftPlate()
        {
            if (LeftPlate == PlateType.Lines)
            {
                var lines_plain = LoadInternalImage("lines-plain.png");
                var lines_tags = LoadInternalImage("lines-tags.png");

                lines_plain.Colorize(LineColor, new Percentage(100));
                lines_tags.Colorize(TagColor, new Percentage(100));

                lines_plain.Scale(new Percentage((MainImage.Width / 2d) / lines_plain.Width * 100d), new Percentage((MainImage.Width / 2d) / lines_plain.Width * 82.5d));
                lines_tags.Scale(new Percentage((MainImage.Width / 2d) / lines_tags.Width * 100d), new Percentage((MainImage.Width / 2d) / lines_tags.Width * 82.5d));

                PrepareForPlate(lines_plain, Plate.Left, Gravity.Center);
                PrepareForPlate(lines_tags, Plate.Left, Gravity.Center);
                //lines_plain.Scale(new Percentage((MainImage.Width / 2d) / lines_plain.Width * 100d), new Percentage((MainImage.Width / 2d) / lines_plain.Width * 82.5d));
                //lines_tags.Scale(new Percentage((MainImage.Width / 2d) / lines_tags.Width * 100d), new Percentage((MainImage.Width / 2d) / lines_tags.Width * 82.5d));

                //lines_plain.BackgroundColor = new MagickColor(65535, 65535, 65535, 0);
                //lines_plain.Shear(-30, 0);
                //lines_plain.Rotate(30);
                //lines_plain.Trim();

                //lines_tags.BackgroundColor = new MagickColor(65535, 65535, 65535, 0);
                //lines_tags.Shear(-30, 0);
                //lines_tags.Rotate(30);
                //lines_tags.Trim();

                double total_height = LeftBottom.Y - LeftTop.Y;
                //MainImage.Composite(lines_plain, /*Scale(MainImage, 1646, 1426)*/new PointD(LeftTop.X + Scale(20) + MainImage.Height / 64d, (((Center.Y + LeftTop.Y) / 2d) + ((total_height - lines_plain.Height) / 2d)) - MainImage.Height / 96d), CompositeOperator.Over);
                //MainImage.Composite(lines_tags, /*Scale(MainImage, 1646, 1426)*/new PointD(LeftTop.X + Scale(20) + MainImage.Height / 64d, (((Center.Y + LeftTop.Y) / 2d) + ((total_height - lines_tags.Height) / 2d)) - MainImage.Height / 96d), CompositeOperator.Over);

                MainImage.Composite(lines_plain, /*Scale(MainImage, 1646, 1426)*/new PointD((((MainImage.Width / 2) - lines_plain.Width) / 2), (((Center.Y + LeftTop.Y) / 2d) + ((total_height - lines_plain.Height) / 2d)) - MainImage.Height / 96d), CompositeOperator.Over);
                MainImage.Composite(lines_tags, /*Scale(MainImage, 1646, 1426)*/new PointD((((MainImage.Width / 2) - lines_tags.Width) / 2), (((Center.Y + LeftTop.Y) / 2d) + ((total_height - lines_tags.Height) / 2d)) - MainImage.Height / 96d), CompositeOperator.Over);
            }
            else if(LeftPlate == PlateType.Image)
            {
                PrepareForPlate(LeftPlateImage, Plate.Left);
                LeftPlateImage.Scale(new Percentage((Bottom.Y - LeftTop.Y) / LeftPlateImage.Height * LeftPlateImagePercentage));

                //MainImage.Composite(TopPlateImage, /*Scale(570, 310)*/new PointD((MainImage.Width - RightPlateImage.Width) / 2, Scale(FrameMargin)), CompositeOperator.Over);

                //MainImage.Composite(RightPlateImage, /*Scale(MainImage, 1646, 1426)*/new PointD(Top.X + (MainImage.Width / 8d), (((Center.Y + LeftTop.Y) / 2d) + ((total_height - RightPlateImage.Height) / 2d) + MainImage.Height / 64d)), CompositeOperator.Over);
                MainImage.Composite(LeftPlateImage, new PointD((((MainImage.Width / 2) - LeftPlateImage.Width) / 2), LeftTop.Y + (((Bottom.Y - LeftTop.Y) - LeftPlateImage.Height) / 2)), CompositeOperator.Over);
            }
            else if(LeftPlate == PlateType.Empty)
            {

            }
        }

        private void DrawRightPlate()
        {
            double total_height = LeftBottom.Y - LeftTop.Y;
            if (RightPlate == PlateType.Lock)
            {
                var lock_outer = LoadInternalImage("lock-outer.png");
                var lock_inner = LoadInternalImage("lock-inner.png");
                //lock_img.Tint("100", LockColor);
                lock_inner.Colorize(InnerLockColor, new Percentage(100));
                lock_outer.Colorize(OuterLockColor, new Percentage(100));
                lock_inner.Scale(new Percentage((MainImage.Width / 4d) / lock_inner.Width * 100d));
                lock_outer.Scale(new Percentage((MainImage.Width / 4d) / lock_outer.Width * 100d));

                PrepareForPlate(lock_inner, Plate.Right);
                PrepareForPlate(lock_outer, Plate.Right);

                /*////lock_img.ColorFuzz = new Percentage(10);
                ////lock_img.Transparent(new MagickColor("black"));
                ////lock_img.ColorFuzz = new Percentage(0);
                //lock_inner.BackgroundColor = new MagickColor(65535, 65535, 65535, 0);
                ////lock_img.Tint("100", LockColor);
                //lock_inner.Shear(30, 0);
                //lock_inner.Rotate(-30);
                //lock_inner.Trim();
                //lock_inner.Write("./inner.png");
                //lock_outer.BackgroundColor = new MagickColor(65535, 65535, 65535, 0);
                ////lock_img.Tint("100", LockColor);
                //lock_outer.Shear(30, 0);
                //lock_outer.Rotate(-30);
                //lock_outer.Trim();
                //lock_outer.Write("./outer.png");*/
                MainImage.Composite(lock_outer, /*Scale(MainImage, 1646, 1426)*/new PointD(Top.X + (((MainImage.Width / 2) - lock_outer.Width) / 2), (((Center.Y + LeftTop.Y) / 2d) + ((total_height - lock_outer.Height) / 2d))), CompositeOperator.Over);
                MainImage.Composite(lock_inner, /*Scale(MainImage, 1646, 1426)*/new PointD(Top.X + (((MainImage.Width / 2) - lock_outer.Width) / 2), (((Center.Y + LeftTop.Y) / 2d) + ((total_height - lock_inner.Height) / 2d))), CompositeOperator.Over);
            }
            else if(RightPlate ==  PlateType.Image)
            {
                //RightPlateImage.Scale(new Percentage(((MainImage.Width / 2d)) / RightPlateImage.Width * 100d));
                PrepareForPlate(RightPlateImage, Plate.Right);
                RightPlateImage.Scale(new Percentage((Bottom.Y - LeftTop.Y) / RightPlateImage.Height * RightPlateImagePercentage));

                //MainImage.Composite(TopPlateImage, /*Scale(570, 310)*/new PointD((MainImage.Width - RightPlateImage.Width) / 2, Scale(FrameMargin)), CompositeOperator.Over);

                //MainImage.Composite(RightPlateImage, /*Scale(MainImage, 1646, 1426)*/new PointD(Top.X + (MainImage.Width / 8d), (((Center.Y + LeftTop.Y) / 2d) + ((total_height - RightPlateImage.Height) / 2d) + MainImage.Height / 64d)), CompositeOperator.Over);
                MainImage.Composite(RightPlateImage, new PointD(Top.X + (((MainImage.Width / 2) - RightPlateImage.Width) / 2), LeftTop.Y + (((Bottom.Y - LeftTop.Y) - RightPlateImage.Height) / 2)), CompositeOperator.Over);
            }
            else if (RightPlate == PlateType.Empty)
            {
                return;
            }
        }

        public void PrepareForPlate(MagickImage image, Plate plate, Gravity gravity = Gravity.Center, bool extent = true)
        {
            image.BackgroundColor = new MagickColor(255, 255, 255, 0);
            switch(plate)
            {
                case Plate.Left:
                    if (extent)
                    { 
                        image.Trim();
                        image.Extent(Math.Max(image.Width, image.Height), Math.Max(image.Width, image.Height), gravity);
                        image.BorderColor = new MagickColor("transparent");
                        image.Border(20);
                        image.BorderColor = new MagickColor("#ffffff01");
                        image.Border(1);
                    }
                    image.Shear(-30, 0);
                    image.Rotate(30);
                    break;
                case Plate.Right:
                    image.Trim();
                    image.Extent(Math.Max(image.Width, image.Height), Math.Max(image.Width, image.Height), gravity);
                    image.BorderColor = new MagickColor("transparent");
                    image.Border(20);
                    image.BorderColor = new MagickColor("#ffffff01");
                    image.Border(1);
                    image.Shear(30, 0);
                    image.Rotate(-30);
                    break;
                case Plate.Top:
                    //image.Scale(new Percentage(GetScalingFactor() * 100));
                    image.Trim();
                    image.Extent(Math.Max(image.Width, image.Height), Math.Max(image.Width, image.Height), gravity);
                    image.BorderColor = new MagickColor("transparent");
                    image.Border(10);
                    image.BorderColor = new MagickColor("#ffffff01");
                    image.Border(1);
                    image.Shear(30, 0);
                    image.Rotate(30);
                    break;
            }
            image.Trim();
        }

        public void Draw()
        {
            if(AutoInnerLockColor)
            {
                ColorUtils.ColorToHSV(OuterLockColor, out double hue, out double saturation, out double value);
                InnerLockColor = ColorUtils.ColorFromHSV(hue, saturation + 0.05, value - 0.1);
            }

            MainImage = new MagickImage(new MagickColor(255, 255, 255, 0), Width, Height);
            SetUpPoints();

            var frame = GetFramePath();
            var inner_frame = GetInnerFramePath();
            //var lock_img = new MagickImage("./lock.png");

            //lines.Transparent(new MagickColor("white"));
            //lines_plain.ColorFuzz = new Percentage(0.5);
            //lines_plain.Opaque(new MagickColor("#00a8fe"), lines_main);
            //lines_plain.Alpha(AlphaOption.Off);

            //lines_tags.ColorFuzz = new Percentage(0.5);
            //lines_plain.Opaque(new MagickColor("#00a8fe"), lines_main);

            frame.StrokeOpacity(new Percentage(0));
            MainImage.Draw(frame);
            MainImage.Draw(inner_frame);

            frame.FillOpacity(new Percentage(0));
            frame.StrokeOpacity(new Percentage(100));

            MainImage.Draw(frame);

            DrawTopPlate();
            DrawLeftPlate();
            DrawRightPlate();
            //HighlightPoints();
        }

        public void SetUpPoints()
        {
            int width = MainImage.Width;
            int height = MainImage.Height;

            double frame_margin = Scale(FrameMargin);

            int virtual_width = (int)(width - (frame_margin * 2));
            int virtual_height = (int)(height - (frame_margin * 2));

            Top = new PointD(width / 2, frame_margin);
            Bottom = new PointD(width / 2, height - frame_margin);
            LeftTop = new PointD(frame_margin, (virtual_height / 4) + frame_margin);
            LeftBottom = new PointD(frame_margin, (virtual_height / 4 * 3) + frame_margin);
            RightTop = new PointD(width - frame_margin, (virtual_height / 4) + frame_margin);
            RightBottom = new PointD(width - frame_margin, (virtual_height / 4 * 3) + frame_margin);
            Center = new PointD(width / 2, height / 2);
        }

        public void HighlightPoints()
        {
            new List<PointD>() { Top, Bottom, LeftTop, LeftBottom, RightTop, RightBottom, Center }.ForEach(p => MainImage.Draw(new DrawablePoint(p.X, p.Y)));
        }

        public MagickImage GetText()
        {
            var image = new MagickImage(new MagickColor(255, 255, 255, 0), 4000, 2000);

            var drawables = new Drawables()
            //.Rotation(30)
            .Text(0, 0, Text)
            .TextAntialias(true)
            .Font("CarbonRegular W00")
            .FontPointSize(387)
            //.FontPointSize(360)
            //.FontPointSize(-1)
            .TextInterlineSpacing(-50)
            .TextKerning(20)
            //.TextKerning(9)
            .FillColor(TextColor)
            .Gravity(Gravity.West);

            //return drawables;
            image.Draw(drawables);

            image.Scale(new Percentage(GetScalingFactor() * 100));
            image.Trim();
            image.Extent(Math.Max(image.Width, image.Height), Math.Max(image.Width, image.Height), Gravity.West);
            image.BorderColor = new MagickColor("transparent");
            image.Border(20);
            image.BorderColor = new MagickColor("#ffffff01");
            image.Border(1);
            //image.Write("./text-face.png");

            return image;
        }

        public Drawables GetFramePath()
        {
            var drawables = new Drawables().Path(
                new PathLineToAbs(Top, LeftTop, LeftBottom, Bottom, RightBottom, RightTop, Top));

            drawables.StrokeColor(FrameColor);
            drawables.FillColor(FillColor);
            drawables.StrokeWidth(Scale(FrameThickness));

            return drawables;
        }

        public Drawables GetInnerFramePath()
        {
            var drawables = new Drawables().Path(
                new PathLineToAbs(Center, Bottom))
                .Path(new PathLineToAbs(Center, LeftTop))
                .Path(new PathLineToAbs(Center, RightTop));

            drawables.StrokeColor(InnerFrameColor);
            drawables.StrokeWidth(Scale(InnerFrameThickness));

            return drawables;
        }

        public double GetScalingFactor()
        {
            return Width / 2600d;
        }

        public double Scale(double value)
        {
            return GetScalingFactor() * value;
        }

        public PointD Scale(int x, int y)
        {
            return new PointD((Width / 2600d) * x, (Height / 3000d) * y);
        }
    }
}
