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

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public  SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {

        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + " yang disimpan pada waktu UTC: " + inputDates[i]);
        }

    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        Console.WriteLine(penjumlahan.JumlahTigaAngka(13, 02, 22));
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.addNewData(13);
        data.addNewData(02);
        data.addNewData(22);
        data.printAllData();
    }
}

