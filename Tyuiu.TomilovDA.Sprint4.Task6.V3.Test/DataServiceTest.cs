using Tyuiu.TomilovDA.Sprint4.Task6.V3.Lib;

namespace Tyuiu.TomilovDA.Sprint4.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string[] months = ["Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"];
            Assert.AreEqual(4, dataService.Calculate(months));
        }
    }
}