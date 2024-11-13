using Tyuiu.TomilovDA.Sprint4.Task7.V2.Lib;
namespace Tyuiu.TomilovDA.Sprint4.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                            *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дана строка из одноразрядных цифр \"597643158942\". Преобразуйте ее в матри*");
            Console.WriteLine("*ицу 3 на 4 и подсчитайте сумму нечетных чисел.                           *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int n = 3;
            int m = 4;
            string value = "597643158942";
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring((i * 4) + j, 1));
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(n,m,value);
            Console.WriteLine("Количество нечетных чисел:");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}