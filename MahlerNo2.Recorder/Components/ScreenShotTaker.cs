using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MahlerNo2.Recorder.Components
{
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
    }

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

        public byte[] ShotSelectedScreen()
        {
            var bytes = Shot(Screen).ToBytes();

            if (IsNewBytes(bytes))
            {
                _lastBytes = bytes;
                return _lastBytes;
            }

            return null;
        }

        private bool IsNewBytes(byte[] bytes)
        {
            if (_lastBytes.Length != bytes.Length)
                return true;

            for (int i = 0; i < bytes.Length; i++)
                if (_lastBytes[i] != bytes[i])
                    return true;

            return false;
        }

        private byte[] _lastBytes = new byte[0];
    }
}