using Tyuiu.TomilovDA.Sprint4.Task1.V14.Lib;
namespace Tyuiu.TomilovDA.Sprint4.Task1.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (ввод с клавиатуры)                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 13 элементов заполненный значениям*");
            Console.WriteLine("*ми с клавиатуры в диапазоне от 1 до 8 подсчитать сумму нечетных элементов*");
            Console.WriteLine("*в массива.  С клавиатуры: 1, 5, 3, 6, 5, 4, 8, 6, 8, 4, 2, 3, 1          *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите длину массива:");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Введённый массив:");
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