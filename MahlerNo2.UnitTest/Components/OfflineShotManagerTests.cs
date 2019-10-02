#region
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endregion

namespace MahlerNo2.Data.Components.Tests
{
    [TestClass()]
    public class OfflineShotManagerTests
    {
        [TestMethod()]
        public void LoadTest()
        {
            OfflineShotManager.Instance.SetDate("190714");

            var time = "135428";
            var bytes = OfflineShotManager.Instance.Load("190714", time);

            var file = new FileInfo($@"C:\Users\thkim\Documents\MahlerNo2\190714\{time}.png");
            Assert.AreEqual(bytes.Length, file.Length);
        }

        [TestMethod()]
        public void LoadTest2()
        {
            OfflineShotManager.Instance.SetDate("190714");

            var time = "135430";
            var bytes = OfflineShotManager.Instance.Load("190714", time);

            var file = new FileInfo($@"C:\Users\thkim\Documents\MahlerNo2\190714\135428.png");
            Assert.AreEqual(bytes.Length, file.Length);
        }
    }
}