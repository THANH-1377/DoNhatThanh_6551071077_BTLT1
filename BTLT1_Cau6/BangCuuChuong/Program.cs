using System;

namespace BangCuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DoNhatThanh_6551071077");

            int n;

            // Vong lap do-while de nhap lai neu sai
            do
            {
                Console.Write("Nhap mot so nguyen (1-9): ");
                n = int.Parse(Console.ReadLine());

                if (n < 1 || n > 9)
                {
                    Console.WriteLine("Loi! Vui long nhap lai so trong khoang 1-9.");
                }

            } while (n < 1 || n > 9);

            // In bang cuu chuong
            Console.WriteLine("Bang cuu chuong cua {0}:", n);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }
    }
}
