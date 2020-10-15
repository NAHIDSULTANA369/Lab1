using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem_1
            Console.WriteLine("Hello");
            Console.WriteLine("Nahid");


            //Problem_2
            int p = 33;
            int q = 3;
            int r = p + q;
            Console.WriteLine("Add:" +r);


            //Problem_3
            double s = p / q;
            Console.WriteLine("Div:" + s);


            //Problem_4
            double a = -5 + 8 * 6;
            Console.WriteLine("Result 1:" + a);
            double b = (55 + 9) % 9;
            Console.WriteLine("Result 2:" + b);
            double c = 20 + -3 * 5 / 8;
            Console.WriteLine("Result 3:" + c);
            double d = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("Result 4:" + d);


            //Problem_5
            int x = 50;
            int y = 30;
            int add = x + y;
            int sub = x - y;
            int mul = x * y;
            double div = x / y;

            Console.WriteLine("Result add:" + add);
            Console.WriteLine("Result sub:" + sub);
            Console.WriteLine("Result mul:" + mul);
            Console.WriteLine("Result div:" + div);


            //Problem_6
            double Res = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine("Result:" + Res);


            //Problem_7
            double width = 5.5;
            double height = 8.5;
            double area = width * height;
            double perimeter = 2 * (width * height);
            Console.WriteLine("Area is" + width + "*" + height + "=" + area);
            Console.WriteLine("Perimeter is 2* (" + width + "+" + height + ") =" + perimeter);


        }
    }
}
