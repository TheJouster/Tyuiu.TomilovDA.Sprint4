using Tyuiu.TomilovDA.Sprint4.Task5.V13.Lib;

namespace Tyuiu.TomilovDA.Sprint4.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[,] matrix = {
                {7, 9, 7, -6, 7},
                {9, 9, -8, -6, 7},
                {-8, -6, 5, -6, 7},
                {9, 9, 7, -8, 7},
                {5, 9, 9, -8, 9}};
            int[,] matrix1 = {
                {7, 9, 7, 0, 7},
                {9, 9, 0, 0, 7},
                {0, 0, 5, 0, 7},
                {9, 9, 7, 0, 7},
                {5, 9, 9, 0, 9}};
            CollectionAssert.AreEqual(matrix1, dataService.Calculate(matrix));
        }
    }
}