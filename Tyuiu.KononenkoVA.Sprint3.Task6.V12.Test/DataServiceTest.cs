using Tyuiu.KononenkoVA.Sprint3.Task6.V12.Lib;

namespace Tyuiu.KononenkoVA.Sprint3.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;

            double res = ds.GetSumTheDivisors(startValue1,stopValue1);

            Assert.AreEqual(res, res);
        }
    }
}
