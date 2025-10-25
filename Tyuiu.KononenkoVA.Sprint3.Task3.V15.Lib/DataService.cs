using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KononenkoVA.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int minAdjacentCount = int.MaxValue;
            int currentCount = 0;

            foreach (char currentChar in value)
            {
                if (currentChar == item)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > 0 && currentCount < minAdjacentCount)
                    {
                        minAdjacentCount = currentCount;
                    }
                    currentCount = 0;
                }
            }

            if (currentCount > 0 && currentCount < minAdjacentCount)
            {
                minAdjacentCount = currentCount;
            }

            return minAdjacentCount == int.MaxValue ? 0 : minAdjacentCount;
        }
    }
}