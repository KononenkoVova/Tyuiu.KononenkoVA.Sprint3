using Microsoft.Testing.Platform.Extensions.Messages;
using Tyuiu.KononenkoVA.Sprint3.Task0.V1.Lib;

namespace Tyuiu.KononenkoVA.Sprint3.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 4;
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = res;

            Assert.AreEqual(wait, res);
        }
    }
}
