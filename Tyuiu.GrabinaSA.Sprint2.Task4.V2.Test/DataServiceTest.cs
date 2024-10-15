using Tyuiu.GrabinaSA.Sprint2.Task4.V2.Lib;
namespace Tyuiu.GrabinaSA.Sprint2.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 21;
            Assert.AreEqual(res, wait);
        }
    }
}