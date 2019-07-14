using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MahlerNo2.Core.Components
{
    public class ScreenShotTaker
    {
        #region singleton

        private static ScreenShotTaker _instance;

        public static ScreenShotTaker Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ScreenShotTaker();
                return _instance;
            }
        }

        private ScreenShotTaker()
        {
        }

        #endregion

        public Screen Screen { get; set; } = Screen.PrimaryScreen;

        public Bitmap Shot(Screen screen)
        {
            var bounds = screen.Bounds;
            var bitmap = new Bitmap(bounds.Width, bounds.Height);
            var graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bitmap.Size);

            return bitmap;
        }

        public byte[] Shot(int maxPreviousShots)
        {
            var bytes = Shot(Screen).ToBytes();

            if (IsNewBytes(bytes))
            {
                _previousBytes.Enqueue(bytes);
                if (_previousBytes.Count > maxPreviousShots)
                    _previousBytes.Dequeue();

                return bytes;
            }

            return null;
        }

        private bool IsNewBytes(byte[] bytes)
        {
            return _previousBytes.All(x => x.IsEqual(bytes) == false);
        }

        private readonly Queue<byte[]> _previousBytes = new Queue<byte[]>();
    }

    public static class ScreenShotExtension
    {
        public static byte[] ToBytes(this Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        public static Image ToImage(this byte[] bytes)
        {
            var ms = new MemoryStream(bytes);
            var image = Image.FromStream(ms);
            return image;
        }

        public static bool IsEqual(this byte[] source, byte[] target)
        {
            if (source.Length != target.Length)
                return false;

            for (int i = 0; i < source.Length; i++)
                if (source[i] != target[i])
                    return false;

            return true;
        }
    }
}