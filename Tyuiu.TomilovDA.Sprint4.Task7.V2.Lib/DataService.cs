using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TomilovDA.Sprint4.Task7.V2.Lib
{
    public class DataService : ISprint4Task7V2
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i,j] = int.Parse(value.Substring((i * 4) + j,1));
                    if (matrix[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
