using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KononenkoVA.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double res = Math.Cos(x) + x;

                if (Math.Abs(res) < 0.0001)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double numerator = 2 * x - 3;
                    double functionValue = numerator / res + 5;

                    valueArray[count] = Math.Round(functionValue, 2);
                }

                count++;
            }

            return valueArray;
        }
    }
}