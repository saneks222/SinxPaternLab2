using System;

namespace SinxPaternLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("V1.0");

            Tintset tintset1 = new Tintset(4);
            Tintset tintset2 = new Tintset(4);

            tintset1.input();
            tintset2.input();

            tintset1.watch();
            tintset2.watch();

           Console.WriteLine(tintset1.Equals(tintset2));

            tintset1.SumOtherNumber(tintset2);

            tintset1.watch();
        }
    }
}
