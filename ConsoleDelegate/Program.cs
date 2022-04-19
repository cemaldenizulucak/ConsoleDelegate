using System;

namespace ConsoleDelegate
{
    class Program
    {
        /*
            Delegateler bir nevi metodların pointerlarıdır
            yani metodları yönetirler
            Delegate tipinde bir nesne türetip rahatlıkl işlemler yapılabilmesine olanak tanır.

            Ayrıca delegatin parametresi içindeki değişkenlerinde aşağıdakilerle aynı olma zorunluluğu yoktur.

         */
        delegate double Dikdortgen(double x, double y);
        static void Main(string[] args)
        {
            Dikdortgen test = new Dikdortgen(alan);
            Console.WriteLine(test(4, 5));

        }

        static double cevre(double a, double b)
        {
            return 2 * (a + b);
        }

        static double alan(double a,double b)
        {
            return a * b;
        }
    }
}
