using Tyuiu.TomilovDA.Sprint4.Task2.V17.Lib;
namespace Tyuiu.TomilovDA.Sprint4.Task2.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Title = "Спринт #4 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы. (генератор случайных чисел)                         *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 9 элементов заполненный случайными*");
            Console.WriteLine("*и в диапазоне от 3 до 9 подсчитать произведение нечетных элементов массив*");
            Console.WriteLine("*ва.                                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 9;
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = random.Next(3,9);
            }
            Console.WriteLine($"Полученный массив:");
            for (int i = 0; i < len; i++)
            {
                Console.Write(Convert.ToString(array[i]) + "\t ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}