using System;

namespace TinhTongDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DoNhatThanh_6551071077");

            // Nhap so nguyen duong n
            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            // Tinh tong 1 + 2 + ... + n
            int tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += i;
            }

            // Tinh tong cac so chan tu 1 den n
            int tongChan = 0;
            for (int i = 2; i <= n; i += 2)
            {
                tongChan += i;
            }

            // Tinh tong cac so le tu 1 den n
            int tongLe = 0;
            for (int i = 1; i <= n; i += 2)
            {
                tongLe += i;
            }

            // Tinh giai thua bang vong lap while
            long giaiThua = 1;
            int j = 1;
            while (j <= n)
            {
                giaiThua *= j;
                j++;
            }

            // In ket qua
            Console.WriteLine("Tong 1 + 2 + ... + n = " + tong);
            Console.WriteLine("Tong cac so chan tu 1 den n = " + tongChan);
            Console.WriteLine("Tong cac so le tu 1 den n = " + tongLe);
            Console.WriteLine("Giai thua n! = " + giaiThua);
        }
    }
}
