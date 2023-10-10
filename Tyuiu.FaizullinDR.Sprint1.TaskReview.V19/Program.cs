using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint1.TaskReview.V19.Lib;

namespace Tyuiu.FaizullinDR.Sprint1.TaskReview.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #1 | Выполнил: Файзуллин Д. Р. | ИИПБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                            *");
            Console.WriteLine("* Тема: SprintReview                                                                   *");
            Console.WriteLine("* Задание #7                                                                           *");
            Console.WriteLine("* Вариант #19                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям *");
            Console.WriteLine("* данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой.           *");
            Console.WriteLine("*          7*(x^2)                                                                     *");
            Console.WriteLine("* z = x -  ------   + sin x + |x^4 - x^5|                                              *");
            Console.WriteLine("*           x^3                                                                        *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());








            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            double res = ds.Calculate(x);
            Console.WriteLine(res);


            Console.ReadLine();

        }
    }
}
