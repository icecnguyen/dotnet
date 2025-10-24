using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        List<KhenThuong> danhsach = new List<KhenThuong>();
        int n;
        do
        {
            Console.Write("Nhap so luong ca nhan (>=1): ");
            n = int.Parse(Console.ReadLine());
        } while (n < 1);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin ca nhan thu {i + 1}:");
            Console.Write("Giao vien hay Sinh vien (1 - Giao Vien, 2 - Sinh Vien): ");
            int choice = int.Parse(Console.ReadLine());
            KhenThuong canbo;
            if (choice == 1)
            {
                canbo = new GiaoVien();
            }
            else
            {
                canbo = new SinhVien();
            }
            canbo.nhap();
            danhsach.Add(canbo);
        }
        Console.WriteLine("\nDanh sach can bo duoc khen thuong:");
        foreach (var canbo in danhsach)
        {
            if (canbo.ktrakhenthuong())
            {
                canbo.hien();
                Console.WriteLine();
            }
        }
    }
}
