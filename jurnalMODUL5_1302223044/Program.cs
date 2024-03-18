
﻿using System.Data.Common;
using static Program;

internal class Program
{
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
    private static void Main(string[] args)
    {       
        penjumlahan.jumlahTigaAngka<double>(12.0,34.0,56.0);
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
        SimpleDataBase<int> test = new SimpleDataBase<int>();
        test.AddNewData(13);
        test.AddNewData(02);
        test.AddNewData(22);
        test.PrintAllData();
    }
}


