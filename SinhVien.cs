using System;
public class SinhVien : KhenThuong
{
    private string lop;
    private float diemtrungbinh;
    public override void nhap()
    {
        base.nhap();
        Console.Write("Nhap lop: ");
        lop = Console.ReadLine();
        do
        {
            Console.Write("Nhap diem trung binh (0.0 - 10.0): ");
            diemtrungbinh = float.Parse(Console.ReadLine());
        } while (diemtrungbinh < 0.0f || diemtrungbinh > 10.0f);
    }
    public override void hien()
    {
        Console.WriteLine("Ho ten: " + hoten);
        Console.WriteLine("Ngay sinh: " + ngaysinh);
        Console.WriteLine("Lop: " + lop);
        Console.WriteLine("Diem trung binh: " + diemtrungbinh);
    }
    public override bool ktrakhenthuong()
    {
        return diemtrungbinh >= 9.0;
    }
}
