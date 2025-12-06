using System;
using System.Collections;

class Barang
{
    public int Id;
    public string Nama ="";
    public string Kategori ="";
    public int Harga;
    public int Stok;
}

class Program
{
    static ArrayList listbarang = new ArrayList();
    static int autoinc = 1;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Program Koperasi By Kelompok 4");
            Console.WriteLine("1. Tambah Barang");
            Console.WriteLine("2. Lihat Semua Barang");
            Console.WriteLine("3. Edit Barang");
            Console.WriteLine("4. Hapus Barang");
            Console.WriteLine("5. Cari Barang");
            Console.WriteLine("6. Filter Barang");
            Console.WriteLine("0. Keluar");
            Console.WriteLine("===================================");
            Console.Write("Pilih Menu");

            string pilih = Console.ReadLine()!;

            switch (pilih)
            {
                case "1": Create(); break;
                case "2": Read(); break;
                case "3": Update(); break;
                case "4": Delete(); break;
                case "5": Search(); break;
                case "6": Filter(); break;
                case "0": return;
                default:
                Console.WriteLine("Menu tidak valid!");
                Console.ReadKey();
                break;
            }
        }
    }

//Ngodingnya disini yh
    static void Create()
    {
        
    }

    static void Read()
    {
        
    }

    static void Update()
    {
        
    }

    static void Delete()
    {
        
    }

    static void Search()
    {
        
    }

    static void Filter()
    {
        
    }
}