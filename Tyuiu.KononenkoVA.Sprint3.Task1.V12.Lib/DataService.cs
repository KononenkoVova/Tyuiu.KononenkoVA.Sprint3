using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KononenkoVA.Sprint3.Task1.V12.Lib
{
    public class DataService : ISprint3Task1V12
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries += Math.Pow((1 / Math.Pow(startValue, value)), 2);
                startValue++;

            }

            return multSeries;
        }
    }
}
