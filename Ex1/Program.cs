using System;
using Chernyshev;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            min();
            getLengthNum();
            getSumOddNum();
            authentication();
            getIndexBM();
            getGoodNum();
            getRecursion();
        }

        #region Task 7. Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).*Разработать рекурсивный метод, который считает сумму чисел от a до b.
        private static void getRecursion()
        {
            Console.WriteLine("Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();

            Console.WriteLine("Введите числа а и b :");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            rec(a, b); 
            Console.WriteLine();
            Console.WriteLine($"Сумма в рекурии = {recSum(a, b)}");
            SimpleHelperProgram.Pause();
        }
        #endregion
        #region Рекурсии для задачи 7
        private static int recSum(int a, int b)
        {
            
            if (a <= b)
            {
                int sum = b;
                sum += recSum(a, b - 1);
                return sum;
            }
            return 0;
        }

        private static void rec(int a, int b)
        {
            if(a < b)
                rec(a, b-1);
            Console.Write(b + " ");
        }
        #endregion
        #region Task 6. Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        private static void getGoodNum()
        {
            int num = 0;
            int sum = 0;
            DateTime dateTime = DateTime.Now;
            for (int i = 0; i < 1000000000; i++)
            {
                sum = 0;
                num = i;
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum != 0)
                    if (i % sum == 0)
                        Console.WriteLine(i);
            }
            Console.WriteLine(DateTime.Now - dateTime);
            SimpleHelperProgram.Pause();

        }
        #endregion
        #region Task 5. Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        private static void getIndexBM()
        {
            Console.WriteLine("Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.");
            Console.WriteLine("===================================================================================");
            Console.WriteLine();

            Console.WriteLine("Введите значение массы и роста через enter: ");

            Console.Write("Масса: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Рост: ");
            double h = double.Parse(Console.ReadLine());

            double l = m / (h * h);
            Console.WriteLine($"Индекс массы вашего тела = {l:F5}");

            if (l > 0.0025)
            {
                Console.WriteLine($"Для нормальизации индекса вам надо сбросить {m - 0.0025 * (h * h):F2} кг.");

            }
            else if (l < 0.00185)
            {
                Console.WriteLine($"Для нормальизации индекса вам надо набрать {0.00185 * (h * h) - m:F2} кг.");
            }
            else
            {
                Console.WriteLine("У вас всё в норме");
            }
            Console.WriteLine();
            SimpleHelperProgram.Pause();
        }
        #endregion
        #region Task 4. Реализовать метод проверки логина и пароля.
        private static void authentication()
        {
            Console.WriteLine("Реализовать метод проверки логина и пароля.");
            Console.WriteLine("===========================================");
            Console.WriteLine();
            int attempt = 3;
            do
            {
                Console.Write("Логин: ");
                string login = Console.ReadLine();
                Console.Write("Пароль: ");
                string password = "";
                while (true)
                {
                    var key = Console.ReadKey(true);//не отображаем клавишу - true

                    if (key.Key == ConsoleKey.Enter) break; //enter - выходим из цикла

                    Console.Write("*");//рисуем звезду вместо нее
                    password += key.KeyChar; //копим в пароль символы
                }
                if (login == "root" && password == "GeekBrains")
                {
                    Console.WriteLine();
                    Console.WriteLine("Добро пожаловать!");
                    SimpleHelperProgram.Pause();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Не верный логин или пароль.");
                    SimpleHelperProgram.Pause();
                    attempt--;
                }
            } while (attempt != 0);
            if (attempt == 0)
                Console.WriteLine("Доступ закрыт!");
            SimpleHelperProgram.Pause();
        }
        #endregion
        #region Task 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        private static void getSumOddNum()
        {
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.");
            Console.WriteLine("=======================================================================================================");
            Console.WriteLine();
            int sum = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                    sum += num;
                if (num == 0)
                    break;
            }
            Console.WriteLine($"Сумма нечётных числе последовательности = {sum}");
            SimpleHelperProgram.Pause();

        }
        #endregion
        #region Task 2. Написать метод подсчета количества цифр числа.
        private static void getLengthNum()
        {
            Console.WriteLine("Написать метод подсчета количества цифр числа.");
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.Write("Введите число: ");
            string num = Console.ReadLine();
            int numLength = num.Length;
            if (double.Parse(num) % 1 != 0)
                numLength--;
            if (double.Parse(num) < 0)
                numLength--;
            Console.WriteLine(numLength);
            SimpleHelperProgram.Pause();

        }
        #endregion
        #region Task 1. Написать метод, возвращающий минимальное из трёх чисел.
        private static void min()
        {
            Console.WriteLine("Написать метод, возвращающий минимальное из трёх чисел.");
            Console.WriteLine("=======================================================");
            Console.WriteLine();
            Console.WriteLine("Введите числа через enter для определения максимального из них : ");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            if (a < b)
            {
                a = a < c ? a : c;
                Console.WriteLine($"min = {a}");
            }
            else
            {
                a = b < c ? b : c;
                Console.WriteLine($"min = {a}");
            }
            SimpleHelperProgram.Pause();
        }
        #endregion
    }
}
