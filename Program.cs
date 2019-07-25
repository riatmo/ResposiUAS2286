using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            
            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Customer\n2. Hapus Customer\n3. Tampilkan Customer\n4. Keluar");

        }

        static void TambahCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Tambah Data Customer\n");

            Customer pelanggan = new Customer();

            Console.Write("Nama Customer : "); pelanggan.Nama = Console.ReadLine();
            Console.Write("Kode Customer : "); pelanggan.Kode = Console.ReadLine();
            Console.Write("Total Piutang : "); pelanggan.Hutang = Convert.ToInt32(Console.ReadLine());

            daftarCustomer.Add(pelanggan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            string var;
            Console.WriteLine("Hapus Data Customer\n");

            Console.Write("Kode Customer : "); var = Console.ReadLine();

            Customer pelanggan = new Customer();
            pelanggan = daftarCustomer.SingleOrDefault(kode => kode.Kode == var);

            if (pelanggan != null)
            {
                daftarCustomer.Remove(pelanggan);
                Console.WriteLine("\nData Customer berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nKode Customer tidak ditemukan");
            }


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
        
        static void TampilCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Data Customer\n");
            int x = 1;
            foreach (Customer pel in daftarCustomer)
            {
                
                Console.WriteLine("{0}. {1},\t{2},\t{3}", x++,pel.Kode,pel.Nama, pel.Hutang);
                
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

