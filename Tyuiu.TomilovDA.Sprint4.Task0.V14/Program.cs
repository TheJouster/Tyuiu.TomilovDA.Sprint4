using Tyuiu.TomilovDA.Sprint4.Task0.V14.Lib;
namespace Tyuiu.TomilovDA.Sprint4.Task0.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (статический ввод)                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный статическ*");
            Console.WriteLine("*кими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных элементов*");
            Console.WriteLine("*в массива.  {8, 9, 5, 4, 3, 2, 1, 0, 5, 7}                               *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            var result = ds.GetSumOddArrEl(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}