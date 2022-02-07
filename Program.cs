using System;

namespace ПерегрузкаМетодов
{
    class Decart
    {
        int x { get; set; }

        int y { get; set; }

        int z { get; set; }

        int g { get; set; }
        // конструктор
        public Decart(int x, int y, int z, int g)
        {
            this.x = x;

            this.y = y;

            this.z = z;

            this.g = g;
        }

        // квадрат расстояния для 4d-точки
        public int distance(int a, int b, int c, int d)
        {
            return a * a + b * b + c * c + d * d;
        }
        // квадрат расстояния для 3d-точки
        public int distance(int a, int b, int c)
        {
            return a * a + b * b + c * c;
        }

        // квадрат расстояния для 2d-точки

        public int distance(int a, int b)
        {
            return a * a + b * b;
        }
        // квадрат расстояния для 1d-точки
        public int distance(int a)
        {
            return a * a;
        }
        // квадрат расстояния для 3d-объекта
        public int distance()
        {
            return x * x + y * y + z * z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Decart d = new Decart(4, 4, 4,4);

            Console.WriteLine(d.distance());

            Console.WriteLine(d.distance(3));

            Console.WriteLine(d.distance(3, 4));

            Console.WriteLine(d.distance(3, 4, 5));

            Console.WriteLine(d.distance(3, 4, 5, 6));

            Console.ReadKey();
        }
    }
}
