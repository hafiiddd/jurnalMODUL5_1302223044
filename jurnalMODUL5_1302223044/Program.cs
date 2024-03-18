
using System.Data.Common;
using static Program;

public class penjumlahan
    {
        public static void jumlahTigaAngka<T>(T A,T B,T C)
        {
            dynamic temp;
            dynamic angka1 = A;
            dynamic angka2 = B;
            dynamic angka3 = C;
            temp = angka1 + angka2 + angka3;
            Console.WriteLine(temp);
            
        }
    }
public class SimpleDataBase<T>
{
    private List<T> storeDataList;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storeDataList = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        this.storeDataList.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < this.storeDataList.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {this.storeDataList.ElementAt(i)}, yang disimpan pada waktu {this.inputDates.ElementAt(i)}");
        }
    }
}

public class MainProgram
{
    public static void Main(String[] args)
    {
        penjumlahan.jumlahTigaAngka<double>(13.0, 02.0, 22.0);
        SimpleDataBase<double> test = new SimpleDataBase<double>();
        test.AddNewData(13.0);
        test.AddNewData(02.0);
        test.AddNewData(22.0);
        test.PrintAllData();
    }
}

