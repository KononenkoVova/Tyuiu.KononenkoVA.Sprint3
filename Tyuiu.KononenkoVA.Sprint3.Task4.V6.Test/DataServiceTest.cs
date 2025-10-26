using Tyuiu.KononenkoVA.Sprint3.Task4.V6.Lib;

namespace Tyuiu.KononenkoVA.Sprint3.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            double res = ds.Calculate(start, stop);

            Assert.AreEqual(res, res);
        }
    }
}
