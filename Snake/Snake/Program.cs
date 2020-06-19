using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            func1(x);
            Console.WriteLine("after func1 x = " + x + "\n\n");

            x = 1;
            func2(x);
            Console.WriteLine("after func2 x = " + x + "\n\n");

            x = 1;
            func3(x);
            Console.WriteLine("after func3 x = " + x + "\n\n");

            Point p1 = new Point(1, 3, '!');
            move(p1, 10, 20);
            Console.WriteLine("after move p1.x = " + p1.x + ", p1.y = " + p1.y + "\n\n");

            Point p2 = new Point(3, 4, '@');
            p1 = p2;
            p2.x = 5;
            p2.y = 6;
            Console.WriteLine("p1 = p2   p1.x = " + p1.x + ", p1.y = " + p1.y +" ;   p2.x = " + p2.x + ", p2.y = " + p2.y + "\n\n");

            p1 = new Point(7, 8, '^');
            update(p1);
            Console.WriteLine("after update()  p1.x = " + p1.x + ", p1.y = " + p1.y + ", p1.sym = " + p1.sym + "\n\n");

            Console.ReadLine();
        }

        public static void func1(int value)
        {
            Console.WriteLine("call func1   value = " + value);
            value += 1;
            Console.WriteLine("value += 1;  value = " + value);
        }

        public static void func2(int value)
        {
            // В языке C# указатели очень редко используются, однако в некоторых случаях можно прибегать к ним для оптимизации приложений. 
            //Код, применяющий указатели, еще называют небезопасным кодом. Однако это не значит, что он представляет какую-то опасность. 
            //Просто при работе с ним все действия по использованию памяти, в том числе по ее очистке, ложится целиком на нас, а не на среду CLR. 
            //И с точки зрения CLR такой код не безопасен, так как среда не может проверить данный код, поэтому повышается вероятность различного рода ошибок
            //https://metanit.com/sharp/tutorial/8.3.php
        }

        public static void func3(int value)
        {

        }

        public static void move(Point p, int dx, int dy)
        {
            p.x += dx;
            p.y += dy;
        }

        public static void update(Point p)
        {
            p = new Point();
        }

    }

}
