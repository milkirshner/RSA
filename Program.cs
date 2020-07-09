using System;

namespace RSA
{
    class Program
    {

        static void Main(string[] args)
        {

            static double NOD(double e, double fi)
            {
                if (e == fi)
                    return e;
                else
                    if (e > fi)
                    return NOD(e - fi, fi);
                else
                    return NOD(fi - e, e);
            }

            int simple(int n)
            {
                for (int i = 2; i <= n / 2; i++) if ((n % i) == 0) return 0;
                return 1;
            }

            {
                Console.WriteLine("введите числа p и q:");
                int p = int.Parse(Console.ReadLine());
                int q = int.Parse(Console.ReadLine());
                double n = p * q;
                Console.WriteLine("n=" + n.ToString());
                double fi = (p - 1) * (q - 1);
                Console.WriteLine("fi=" + fi.ToString());
                int g = 0;
                int e1 = 0;
                double e = 0;
                for (int i = 0; i < fi; i++)
                {
                    e1++;
                    if (simple(e1) == 1)
                        if (e1 < fi)
                            if (NOD(e1, fi) == 1)
                            { g++; e = e1; }
                }
                Console.WriteLine("всего значений e:" + g);
                Console.WriteLine("e =" + e);
                double d = 0;
                int h = 0;
                while (h < 5)
                {
                    if ((d * e) % n == 1)
                    {
                        h++;
                        Console.WriteLine("Одно из 5 значений d:" + d);
                        d++;
                    }

                    else d++;
                }

                Console.WriteLine("Открытый ключ -  {" + e + "," + n + "}");
                Console.WriteLine("Закрытый ключ -  {" + d + "," + n + "}");
                Console.ReadKey();

            }
        }
    }
}
