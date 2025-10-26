using Tyuiu.KononenkoVA.Sprint3.Task7.V18.Lib;

namespace Tyuiu.KononenkoVA.Sprint3.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue1 = 1;
            int stopValue1 = 3;

            double[] res = ds.GetMassFunction(startValue1, stopValue1);

            Assert.AreEqual(res, res);
        }
    }
}
