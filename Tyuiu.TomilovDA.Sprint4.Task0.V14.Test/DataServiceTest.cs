using Tyuiu.TomilovDA.Sprint4.Task0.V14.Lib;

namespace Tyuiu.TomilovDA.Sprint4.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            Assert.AreEqual(6, dataService.GetSumOddArrEl(array));
        }
    }
}