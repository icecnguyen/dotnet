using System;
public abstract class KhenThuong
{
    protected string hoten;
    protected string ngaysinh;
    public virtual void nhap()
    {
        Console.Write("Nhap ho ten: ");
        hoten = Console.ReadLine();
        Console.Write("Nhap ngay sinh: ");
        ngaysinh = Console.ReadLine();
    }
    public abstract void hien();
    public abstract bool ktrakhenthuong();
}
