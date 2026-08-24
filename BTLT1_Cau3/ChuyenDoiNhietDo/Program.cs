using System;

namespace ChuyenDoiNhietDo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap nhiet do Celsius
            Console.Write("Nhap nhiet do (Celsius): ");
            decimal celsius = decimal.Parse(Console.ReadLine());

            // Chuyen doi
            decimal fahrenheit = celsius * 9 / 5 + 32;
            decimal kelvin = celsius + 273.15m; // them m de la kieu decimal

            // In ket qua lam tron 2 chu so thap phan
            Console.WriteLine("Fahrenheit = {0:F2}", fahrenheit);
            Console.WriteLine("Kelvin = {0:F2}", kelvin);
        }
    }
}
