using Tyuiu.BazilevichAV.Sprint0.Task4.V0.Lib;
namespace Tyuiu.BazilevichAV.Sprint0.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChechedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]

        public void ChechedRemovalValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]

        public void ChechedSubtractionValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]

        public void ChechedMultiplicationValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
