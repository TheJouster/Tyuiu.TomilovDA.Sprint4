using Tyuiu.TomilovDA.Sprint4.Task3.V3.Lib;

namespace Tyuiu.TomilovDA.Sprint4.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[,] array = { {9, 4, 5, 4, 8},
                            {7, 6, 7, 7, 4 },
                            {4, 4, 3, 5, 6 },
                            {6, 5, 9, 4, 9 },
                            {9, 7, 8, 7, 7 }};
           Assert.AreEqual(14, dataService.Calculate(array));
        }
    }
}