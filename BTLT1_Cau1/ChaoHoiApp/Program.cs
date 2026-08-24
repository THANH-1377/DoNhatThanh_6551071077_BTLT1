using System;

namespace ChaoHoiApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo biến
            string hoTen;
            int tuoi;
            double chieuCao;
            float canNang;
            bool daTotNghiep;

            Console.WriteLine("DoNhatThanh_6551071077 ");

            // Nhập dữ liệu từ bàn phím
            Console.Write("Nhap ho tên: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap tuoi: ");
            tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhap chieu cao (m): ");
            chieuCao = double.Parse(Console.ReadLine());

            Console.Write("Nhap can nang (kg): ");
            canNang = float.Parse(Console.ReadLine());

            Console.Write("Đa tot nghiep (true/false): ");
            daTotNghiep = bool.Parse(Console.ReadLine());

            // In ra màn hình
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("Chieu cao: " + chieuCao + " m");
            Console.WriteLine("Can nang: " + canNang + " kg");
            Console.WriteLine("Đa tot nghiep: " + daTotNghiep);
        }
    }
}
