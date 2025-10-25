using Tyuiu.KononenkoVA.Sprint3.Task1.V12.Lib;

namespace Tyuiu.KononenkoVA.Sprint3.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = res;

            Assert.AreEqual(wait, res);
        }
    }
}
