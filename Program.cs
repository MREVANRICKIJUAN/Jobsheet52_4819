using System;

namespace Jobsheet52_4819
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BIAYA_ADMIN = 2000;

            Console.Write("Masukkan nama pelanggan : ");
            string namaPelanggan = Console.ReadLine();

            Console.Write("Masukkan nama dokumen   : ");
            string namaDokumen = Console.ReadLine();

            Console.Write("Masukkan jumlah halaman : ");
            int jumlahHalaman = int.Parse(Console.ReadLine());

            Console.Write("Masukkan harga per halaman : ");
            int hargaPerHalaman = int.Parse(Console.ReadLine());

            int subtotal = jumlahHalaman * hargaPerHalaman;
            int totalBayar = subtotal + BIAYA_ADMIN;

            Console.WriteLine();
            Console.WriteLine("=== RINCIAN PENCETAKAN ===");
            Console.WriteLine($"Nama pelanggan    = {namaPelanggan}");
            Console.WriteLine($"Nama dokumen      = {namaDokumen}");
            Console.WriteLine($"Jumlah halaman    = {jumlahHalaman}");
            Console.WriteLine($"Harga per halaman = {hargaPerHalaman}");
            Console.WriteLine($"Subtotal          = {subtotal}");
            Console.WriteLine($"Biaya administrasi= {BIAYA_ADMIN}");
            Console.WriteLine($"Total bayar       = {totalBayar}");
        }
    }
}