using System;

namespace C_task_01
{
    public class SqrtNewton
    {
        public static double Sgrt(double num, int degree, double accuracyRange)
        {

            double root = num / degree;       //начальное приближение корня
            double rootInSolution = num;      //значение корня последовательным делением
                                              // accuracyRange    //погрешность
            while (Math.Abs(root - rootInSolution) >= accuracyRange)
            {
                rootInSolution = num;
                for (int i = 1; i < degree; i++)
                {
                    rootInSolution = rootInSolution / root;
                }
                root = 0.5 * (rootInSolution + root);
            }
            return root;

        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Здравствуйте! Данна программа позволяет вычислить корень n-ой степени из числа с заданной погрешностью методом Ньютона.");
            Console.Write("Введите число : ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите степень корня: ");
            int degree = Convert.ToInt16(Console.ReadLine());

            Console.Write("Введите максимальную погрешность: ");
            double accuracyRange = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: {0}",SqrtNewton.Sgrt(num, degree, accuracyRange));
            Console.WriteLine("Хотели бы вы сравнить результат с корнем, полученным компилятором по умолчанию? y/n");
            char chose = Convert.ToChar(Console.ReadLine());
            if (chose == 'y')
            Console.WriteLine("Результат расчета стандартным методом: {0}", Math.Pow(num, 0.5));
            Console.WriteLine("Спасибо, что воспользовались нашей программой.");
            Console.ReadLine();
        }
    }
}
