using Tyuiu.BazilevichAV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.BazilevichAV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Алёна";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Алёна", res);
        }
    }
}
