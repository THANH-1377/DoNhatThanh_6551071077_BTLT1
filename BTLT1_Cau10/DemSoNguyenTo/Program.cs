using System;

namespace DemSoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DoNhatThanh_6551071077");

            int n = 0;
            bool validInput = false;

            // Xu ly ngoai le khi nhap khong phai so
            while (!validInput)
            {
                try
                {
                    Console.Write("Nhap so nguyen duong n (n <= 1000): ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0 || n > 1000)
                    {
                        Console.WriteLine("Loi! Vui long nhap so nguyen duong khong vuot qua 1000.");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Loi! Vui long nhap dung dinh dang so nguyen.");
                }
            }

            int dem = 0;
            Console.WriteLine("Cac so nguyen to tu 2 den {0}:", n);

            // Tim so nguyen to bang vong lap for long nhau
            for (int i = 2; i <= n; i++)
            {
                bool laNguyenTo = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        laNguyenTo = false;
                        break;
                    }
                }
                if (laNguyenTo)
                {
                    Console.Write(i + " ");
                    dem++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Tong so luong so nguyen to tim duoc = " + dem);
        }
    }
}
