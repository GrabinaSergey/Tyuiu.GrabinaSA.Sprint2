using Tyuiu.GrabinaSA.Sprint2.Task6.V10.Lib;
namespace Tyuiu.GrabinaSA.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("13.10.2023", ds.FindDateOfPreviousDay(2023, 10, 14));

        }
    }
}