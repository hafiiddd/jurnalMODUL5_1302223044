
﻿using System.Data.Common;

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

