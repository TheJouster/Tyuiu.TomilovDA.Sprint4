using Tyuiu.TomilovDA.Sprint4.Task6.V3.Lib;
namespace Tyuiu.TomilovDA.Sprint4.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Класс Array                                                             *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан строковый массив данных [\"Январь\", \"Февраль\", \"Март\", \"Апрель\", \"Май\"*");
            Console.WriteLine("*\", \"Июнь\", \"Июль\", \"Август\", \"Сентябрь\", \"Октябрь\", \"Ноябрь\", \"Декабрь\"] * ");
            Console.WriteLine("* используя класс Array подсчитайте количество элементов, длина которых ме*");
            Console.WriteLine("*еньше 6.                                                                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] months = ["Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"];
            Console.WriteLine($"Полученный массив:");
            for (int i = 0; i < months.Length; i++)
            {
                Console.Write(Convert.ToString(months[i]) + "\t ");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(months);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}