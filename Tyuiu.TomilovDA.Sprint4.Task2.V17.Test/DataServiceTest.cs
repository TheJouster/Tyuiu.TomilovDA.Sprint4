using Tyuiu.TomilovDA.Sprint4.Task2.V17.Lib;

namespace Tyuiu.TomilovDA.Sprint4.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[] array = { 3 ,       4,       4 ,      8  ,     3   ,    6   ,    6   ,    6   ,    3 };
            Assert.AreEqual(27, dataService.Calculate(array));
        }
    }
}