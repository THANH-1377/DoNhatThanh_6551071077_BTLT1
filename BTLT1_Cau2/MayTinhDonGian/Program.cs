using System;

namespace MayTinhDonGian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DoNhatThanh_6551071077");

            // Nhap du lieu
            Console.Write("Nhap so a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so b: ");
            double b = double.Parse(Console.ReadLine());

            // Cac phep toan
            double tong = a + b;
            double hieu = a - b;
            double tich = a * b;
            double thuong = a / b;

            // Chia lay phan nguyen va phan du (ep kieu int)
            int phanNguyen = (int)a / (int)b;
            int phanDu = (int)a % (int)b;

            // Luy thua
            double luyThua = Math.Pow(a, b);

            // In ket qua
            Console.WriteLine("Ket qua cong: " + tong);
            Console.WriteLine("Ket qua tru: " + hieu);
            Console.WriteLine("Ket qua nhan: " + tich);
            Console.WriteLine("Ket qua chia: " + thuong);
            Console.WriteLine("Chia lay phan nguyen: " + phanNguyen);
            Console.WriteLine("Chia lay phan du: " + phanDu);
            Console.WriteLine("Luy thua a^b: " + luyThua);
        }
    }
}
