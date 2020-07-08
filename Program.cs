using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

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
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
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

            // PERINTAH: lengkapi kode untuk menampilkan menu
                        Console.Clear();
            Console.WriteLine("\nPilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Data");
            Console.WriteLine("2. Hapus Data");
            Console.WriteLine("3. Tampilkan Data");
            Console.WriteLine("4. Keluar\n");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Mahasiswa mahasiswa = new Mahasiswa();
           
            Console.WriteLine("\nTambah Data Mahasiswa ");
             Console.Write("NIM \t\t: ");
                mahasiswa.NIM = Console.ReadLine();

                Console.Write("Nama \t\t: ");
                mahasiswa.Nama = Console.ReadLine();

                Console.Write("Jenis Kelamin [L/P] \t: ");
                mahasiswa.JenisKelamin = (JenisKelamin == "L" || JenisKelamin == "P") ? "Laki Laki" : "Perempuan";

                Console.Write("IPK \t\t: ");
                mahasiswa.IPK = Convert.ToDouble(Console.ReadLine());

                daftarMahasiswa.Add(mahasiswa);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

             Console.WriteLine("Hapus Data Mahasiswa");
           

           
            bool found = true;

           
            string nik;
            Console.Write("\nNIM: ");
            nim = Console.ReadLine();

           
            for (int i = 0; i < mahasiswa.Count; i++)
            {
               
                if (mahasiswa[i].NIM == nim)
                {
                   
                    mahasiswa.RemoveAt(mahasiswa[i]);
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }

            if (!found)
            {
                Console.WriteLine("NIM tidak ditemukan", nim);
            }
            else
            {
                Console.WriteLine("Data mahasiswa berhasil dihapus", nim);
            }
        }

        static void TampilkanData(List<Mahasiswa> mahasiswa)
        {

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;

            Console.WriteLine("NO\tNIM\tNAMA \tJENIS KELAMIN\tIPK");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}", no, mahasiswa.NIM, mahasiswa.Nama, mahasiswa.JenisKelamin, mahasiswa.IPK);
                no++;
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
