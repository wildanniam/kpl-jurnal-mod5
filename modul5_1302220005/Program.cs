// See https://aka.ms/new-console-template for more information
public class Penjumlahan
{
    public double JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic aa = a;
        dynamic bb = b;
        dynamic cc = c;
        return aa + bb + cc;
    }
}
public class Program
{
    //NIM: 1302220005
    public static void Main(string[]args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        Console.WriteLine(penjumlahan.JumlahTigaAngka(13, 02, 22)); 
    }
}
