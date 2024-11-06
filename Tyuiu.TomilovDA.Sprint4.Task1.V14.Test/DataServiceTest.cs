using Tyuiu.TomilovDA.Sprint4.Task1.V14.Lib;

namespace Tyuiu.TomilovDA.Sprint4.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            int[] array = { 1, 5, 3, 6, 5, 4, 8, 6, 8, 4, 2, 3, 1 };
            Assert.AreEqual(18, dataService.Calculate(array));
        }
    }
}