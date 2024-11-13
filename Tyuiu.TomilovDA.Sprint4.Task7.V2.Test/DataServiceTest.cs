using Tyuiu.TomilovDA.Sprint4.Task7.V2.Lib;

namespace Tyuiu.TomilovDA.Sprint4.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string num = "597643158942";
            Assert.AreEqual(39, dataService.Calculate(3,4,num));
        }
    }
}