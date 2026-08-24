using System;

namespace XuLyChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DoNhatThanh_6551071077");

            // Nhap chuoi ho ten
            Console.Write("Nhap ho ten day du: ");
            string hoTen = Console.ReadLine();

            // Do dai chuoi
            Console.WriteLine("Do dai chuoi = " + hoTen.Length);

            // Chuoi chu HOA va chu thuong
            Console.WriteLine("Chuoi chu HOA = " + hoTen.ToUpper());
            Console.WriteLine("Chuoi chu thuong = " + hoTen.ToLower());

            // Chuoi sau khi xoa khoang trang hai dau
            string hoTenTrim = hoTen.Trim();
            Console.WriteLine("Chuoi sau khi Trim = " + hoTenTrim);

            // Kiem tra co chua tu "Nguyen" khong
            if (hoTen.Contains("Nguyen"))
                Console.WriteLine("Chuoi co chua tu 'Nguyen'");
            else
                Console.WriteLine("Chuoi khong chua tu 'Nguyen'");

            // Tach thanh mang tung tu theo dau cach
            string[] tuArray = hoTen.Split(' ');
            Console.WriteLine("Cac tu trong chuoi:");
            foreach (string tu in tuArray)
            {
                Console.WriteLine(tu);
            }

            // Ghep lai bang String.Join voi dau "-"
            string chuoiGhep = String.Join("-", tuArray);
            Console.WriteLine("Chuoi ghep lai = " + chuoiGhep);
        }
    }
}
