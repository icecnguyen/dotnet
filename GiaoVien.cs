using System;
public class GiaoVien : KhenThuong
{
    private string khoa;
    private int sodetai;
    public override void nhap()
    {
        base.nhap();
        Console.Write("Nhap khoa: ");
        khoa = Console.ReadLine();
        do
        {
            Console.Write("Nhap so de tai (>=0): ");
            sodetai = int.Parse(Console.ReadLine());
        } while (sodetai < 0);
    }
    public override bool ktrakhenthuong()
    {
        return sodetai >= 1;
    }

    public override void hien()
    {
        Console.WriteLine($"{hoten}\t{ngaysinh}\t{khoa}\t{sodetai}");
    }
}
