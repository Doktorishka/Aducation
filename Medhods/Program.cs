using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        /*Конструкция методов
         [модификаторы] тип_возвращаемого_значения название_метода ([параметры])
            {
            // тело метода
            } 
        */

        //Метод без параметров, не возвращающий значения
        static void Hello()
        {
            Console.WriteLine("Hello World");
        }
        //Метод без параметров, с иной конструкцией
        static void Say() => Console.WriteLine("Say");

        //Метод с параметрами
        static void SayOne(string s) => Console.WriteLine(s);

        //Метод с параметрами, возвращающий int
        static int PrintNumber(int n) {
            return n;
        }

        static void Increment(int n) {
            n++;
            Console.WriteLine($"Число в методе Increment: {n}");
        }
        static void Increment(ref int n)
        {
            n++;
            Console.WriteLine($"Число в методе Increment: {n}");
        }

        //Сноска
        // ВХОДНОЙ Параметр ref используется для передачи НЕ копии переменной, а его оригинал
        // ВЫХОДНОЙ Параметр out используется для работы НЕ с копией переменной, а с его оригиналом

        static void Sum(int x, int y, out int result) { 
            result = x + y;

            Console.WriteLine($"Результат в методе: {result}");
        }

        static void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr){
            width = 10;
            rectArea = width * height;
            rectPerimetr = (width + height) * 2;
          }
        static void GetRectangleData(in int width, in int height, out int rectArea, out int rectPerimetr)
        {
            rectArea = width * height;
            rectPerimetr = (width + height) * 2;
        }

        static void Add(int a, int b) {
            int result = a + b;
            Console.WriteLine(result);
        }

        static void Add(params int[] num) {
            int result = 0;
            foreach (var n in num) {
                result += n;
            }
            Console.WriteLine(result);
        }

        static int Factorial(int n) { 
            if(n == 1) return 1;

            return n * Factorial(n - 1);
        }

        static int Fibonachi(int n) {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        static void Main(string[] args)
        {
            // Факториал ! 10! = 1 * 2 * 3 * 4 * 5 * 6 * 7 * 8 * 9 * 10
            // n! = 1 * 2 * … * n

            //Число Фибоначчи f(n) = f(n - 1) + f(n - 2)
            // 1 2 3 5 8 13 21 34 55
            // f(0) = 0; f(1) = 1

            //Пример 1
            //Hello();
            //Say();
            //SayOne("One");
            //int i = PrintNumber(10);

            //Пример 2
            //int number = 3;
            //Console.WriteLine($"Число до метода Increment: {number}");
            //Increment(number);
            //Console.WriteLine($"Число после метода Increment без ref: {number}");
            //Increment(ref number);
            //Console.WriteLine($"Число после метода Increment с параметорм ref: {number}");
            //Console.ReadLine();

            //Пример 3
            //int result = 0;
            //int result2 = 0;
            //int result3 = 0;

            //Sum(10, 15, out result);
            //Sum(10, 10, out result2);
            //Sum(result, result2, out result3);
            //Console.WriteLine($"После выполнения метода: {result3}");

            //Пример 4
            // использование нескольких параметорв out

            //int area = 0;
            //int perimetr = 0;

            //GetRectangleData(10, 20, out area, out perimetr);

            //Console.WriteLine($"Площадь прямоугольника: {area}");
            //Console.WriteLine($"Периметр прямоугольника: {perimetr}");

            //Пример 5
            // использование нескольких параметорв in
            //int width = 10;
            //int height = 20;

            //GetRectangleData(in width, in height, out area, out perimetr);
            //Console.WriteLine($"Площадь прямоугольника: {area}");
            //Console.WriteLine($"Периметр прямоугольника: {perimetr}");

            //Пример 6
            //Использование ключевого слова params
            //int a = 5, b = 7;
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Add(a, b);
            //Add(num);
            //Add(1,2,3,4,5,6,7,8,9,10,11,12,154,243);
            //Add(1,2,3,4,5);

            //Пример 7
            // Факториал

            //int fact1 = Factorial(5);
            //int fact2 = Factorial(6);
            //int fact3 = Factorial(10);

            //Console.WriteLine($"Факториал числа 5 - {fact1}");
            //Console.WriteLine($"Факториал числа 6 - {fact2}");
            //Console.WriteLine($"Факториал числа 10 - {fact3}");

            //Пример 8
            // Число Фибоначчи

            //int fib1 = Fibonachi(4);
            //int fib2 = Fibonachi(5);
            //int fib3 = Fibonachi(10);

            //Console.WriteLine($"Фибоначчи числа 4 - {fib1}");
            //Console.WriteLine($"Фибоначчи числа 5 - {fib2}");
            //Console.WriteLine($"Фибоначчи числа 10 - {fib3}");

            // 3x+1, если четное дели на два, если нет, то 3x-1      4 2 1

            // 5 16 8 4 2 1
            // 6 3 10 5

            /*
                ЗАДАЧА 1:
                Написать метод для вычисления площади окружности;

                ЗАДАЧА 2:
                Вызвать в методе Say() Hello();
                
                ЗАДАЧА 3: 
                Используя библиотекy Math (Math.Sin, Math.Cos) решить уравнение

                cos((pi/2) - 2x) = -1
                tg((pi/4 - x/2)) = -1             
             */
            Console.ReadLine();
        }
    }
}
