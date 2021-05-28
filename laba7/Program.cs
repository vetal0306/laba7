using System;

namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7 в. - знайти середне арифметичне кожного другого додатнього парного елемента в кожному рядку;
            int p = 3;
            int[,] m = {{ 1, -4, 3},
                        { 4, 5, 6},
                        { 7, 4, 9} };


            // операція умови            
            int n;
            if ((m[0, 1] % 2 == 0) && (m[0, 1] > 0)) //перевірка першого члена
            {
                if ((m[1, 1] % 2 == 0) && (m[1, 1] > 0)) //перевірка другого члена
                {
                    try
                    {
                        if ((m[2, 1] % 2 == 0) && (m[2, 1] > 0)) //перевірка третього члена
                        {
                            n = (m[0, 1] + m[1, 1] + m[2, 1]) / 3;
                            Console.WriteLine($"Середнє арифметичне чисел {m[0, 1]}, {m[1, 1]} i {m[2, 1]}  = {n}");
                        }
                        else
                        {
                            n = (m[0, 1] + m[1, 1]) / 2;
                            Console.WriteLine($"Середнє арифметичне чисел {m[0, 1]} i {m[1, 1]} = {n}");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("something wrong ");
                    }
                    
                }
                else
                {
                    n = (m[0, 1] + m[1, 1]) / 2;
                    Console.WriteLine($"Тiльки число {m[0, 1]} вiдповiдає вимогам");
                }

            }
            else if ((m[1, 1] % 2 == 0) && (m[1, 1] > 0))
            {
                if ((m[2, 1] % 2 == 0) && (m[2, 1] > 0))
                {
                    n = (m[1, 1] + m[2, 1]) / 2;
                    Console.WriteLine($"Середнє арифметичне чисел {m[1, 1]} i {m[2, 1]}  = {n}");
                }
                else
                {
                    n = (m[0, 1] + m[1, 1]) / 2;
                    Console.WriteLine($"Тiльки число {m[1, 1]} вiдповiдає вимогам");
                }
            }
            else
            {
                try
                {
                    if ((m[2, 1] % 2 == 0) && (m[2, 1] > 0))
                    {
                        n = m[2, 1];
                        Console.WriteLine($"Лише число {m[2, 1]} вiдповiдає вимогам{n}");
                    }
                }
                catch
                {
                    Console.WriteLine("something was wrong ");
                }
            }
            //Вивід масиву
            Console.WriteLine("Масив: ");

            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write($"{m[i, j]}\t");
                }
                Console.WriteLine();
            }
            // приклади з теорії
            #region 

            /*
            try
            {
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                checked
                {
                    Console.WriteLine($"result: {a}+{b} = {a + b}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter just a number next time!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You need 2 arguments");
            }



            int a = int.MinValue;
            int b = int.MinValue;
            try           
            {
                a = int.Parse(args[0]);
                b = int.Parse(args[1]);
                checked
                {
                    Console.WriteLine($"result: {a}+{b} = {a + b}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter just a number next time!");
            }
            catch (IndexOutOfRangeException)           
            {
                Console.WriteLine("You need 2 arguments");
            }
            catch (OverflowException) when (a != int.MinValue && b !=
            Int32.MinValue)
            {
                Console.WriteLine($"result: {a}+{b} = {double.NaN}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("number range in {0:E} - {1:E}",
                int.MinValue, int.MaxValue);
            }



            Console.WriteLine("Enter number for x value:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for y value:");
            int y = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(MyDiv(x, y));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

            
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Конец программы");
            Console.Read();
            

            try
            {
                Del(5, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Program error: {e.Message}");
            }
            Console.ReadLine();

            static void Del(int x, int y)
            {
                try
                {
                    int result = x / y;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Divide By Zero");
                    throw;
                }
            }



            try
            {
                double x;
                x = 1 / new Random().Next(0, 6);
                Console.WriteLine($"{x}");
            }
            catch
            {
                Console.WriteLine("Divide By zero");            
            }
            */
            #endregion
        }
        public static double MyPowOnlyAboveZero(int a, int b)
        {
            if (b <= 0)
                throw new Exception("b is equals zero or less");
            int res = 1;
            for (int i = 0; i <= b; i++)
                res *= a;
            return res;

        }
        private static double MyDiv(int a, int b)
        {
            if (b == 0)
                throw new Exception("Division by zero");
            return (double)a / b;
        }

    }
}
