using Tyuiu.KononenkoVA.Sprint3.Task3.V15.Lib;

namespace Tyuiu.KononenkoVA.Sprint3.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "asdkjl;bmasd; s,l;davmdavm";
            char item = 'm';

            double res = ds.GetMinCharCount(str,item);

            Assert.AreEqual(res, res);
        }
    }
}
