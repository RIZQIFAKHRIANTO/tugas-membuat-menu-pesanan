using System;

class Program
{
    // Data menu makanan dan minuman menggunakan array
    static string[,] makanan = {
        {"1a", "Nasi Goreng", "12000"},
        {"1b", "Nasi Uduk", "9000"},
        {"1c", "Nasi Kucing", "6000"},
        {"1d", "Mie Rebus", "8000"},
        {"1e", "Mie Goreng", "9000"},
        {"1f", "Mie Ayam", "10000"}
    };

    static string[,] minuman = {
        {"2a", "Teh Botol", "5000"},
        {"2b", "Teh Pucuk", "4000"},
        {"2c", "Susu Jahe", "7000"},
        {"2d", "Kopi Jahe", "6000"},
        {"2e", "Kopi Susu", "5000"},
        {"2f", "Tea Jus", "0"} // Gratis
    };

    // Fungsi untuk menampilkan menu
    static void TampilkanMenu()
    {
        Console.WriteLine("1. Makanan");
        for (int i = 0; i < makanan.GetLength(0); i++)
        {
            Console.WriteLine($"   {makanan[i, 0]}. {makanan[i, 1]} - Rp. {makanan[i, 2]}");
        }

        Console.WriteLine("2. Minuman");
        for (int i = 0; i < minuman.GetLength(0); i++)
        {
            Console.WriteLine($"   {minuman[i, 0]}. {minuman[i, 1]} - Rp. {minuman[i, 2]}");
        }
    }

    // Fungsi untuk memesan
    static void PesanMenu()
    {
        TampilkanMenu();

        Console.Write("Masukkan kode menu: ");
        string kodeMenu = Console.ReadLine().ToLower();

        Console.Write("Berapa banyak yang dipesan: ");
        int jumlahPesanan = int.Parse(Console.ReadLine());

        bool found = false;

        // Pencarian di menu makanan
        for (int i = 0; i < makanan.GetLength(0); i++)
        {
            if (makanan[i, 0] == kodeMenu)
            {
                int harga = int.Parse(makanan[i, 2]);
                int totalHarga = harga * jumlahPesanan;
                Console.WriteLine($"Pesanan: {jumlahPesanan} x {makanan[i, 1]} = Rp. {totalHarga}");
                found = true;
                break;
            }
        }

        // Pencarian di menu minuman jika tidak ditemukan di makanan
        if (!found)
        {
            for (int i = 0; i < minuman.GetLength(0); i++)
            {
                if (minuman[i, 0] == kodeMenu)
                {
                    int harga = int.Parse(minuman[i, 2]);
                    int totalHarga = harga * jumlahPesanan;
                    Console.WriteLine($"Pesanan: {jumlahPesanan} x {minuman[i, 1]} = Rp. {totalHarga}");
                    break;
                }
            }
        }
    }

    static void Main()
    {
        PesanMenu();
    }
}
