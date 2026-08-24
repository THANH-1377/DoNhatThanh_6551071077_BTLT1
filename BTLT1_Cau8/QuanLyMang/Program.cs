using System;

namespace QuanLyMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Console.WriteLine("DoNhatThanh_6551071077");

            // Nhap gia tri tung phan tu
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            // In toan bo mang
            Console.WriteLine("Mang vua nhap:");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            // Tong va trung binh
            int tong = 0;
            foreach (int x in arr)
            {
                tong += x;
            }
            double trungBinh = (double)tong / arr.Length;
            Console.WriteLine("Tong cac phan tu = " + tong);
            Console.WriteLine("Trung binh cac phan tu = " + trungBinh);

            // Gia tri lon nhat va nho nhat
            int max = arr[0], min = arr[0];
            int viTriMax = 0, viTriMin = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    viTriMax = i;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    viTriMin = i;
                }
            }
            Console.WriteLine("Gia tri lon nhat = {0} tai vi tri {1}", max, viTriMax);
            Console.WriteLine("Gia tri nho nhat = {0} tai vi tri {1}", min, viTriMin);

            // So luong phan tu chan va le
            int soChan = 0, soLe = 0;
            foreach (int x in arr)
            {
                if (x % 2 == 0) soChan++;
                else soLe++;
            }
            Console.WriteLine("So luong phan tu chan = " + soChan);
            Console.WriteLine("So luong phan tu le = " + soLe);

            // Dao nguoc mang
            Array.Reverse(arr);
            Console.WriteLine("Mang sau khi dao nguoc:");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}
