using System;
namespace Buble_Sort
{
    /// <summary>
    /// Class <c>Program</c> berisi variabel dan method untuk membaca data
    /// </summary>
    class Program
    {
        //Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        /// <summary>
        /// Method <c>read</c>Fungsi / Method untuk menerima masukan
        /// </summary>
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                //menampilkan tulisan yang sebagai wadah untuk input data string
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                //jika n lebih dari 20 maka akan mendapat notifikasi maksimal 20 elemen
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");

            }

            //menampilkan tulisan input elemen
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            //Pengguna memasukkan elemen pada array
            for (int i = 0; i< n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }

        }

        /// <summary>
        ///Method <c>display</c>untuk menampilkan data yang terdapat pada program
        /// </summary>
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Elemen Array yang telah tersusun ");
            Console.WriteLine("----------------------------------");
            //untuk nilai j = 0, j kurang dari n dan j++, maka akan menampilkan array yang tersusun
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Method <c>BubbleSortArray</c>Method untuk program bublesort yang mengurutkan antar elemen menggunakan array
        /// </summary>
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) //For n - 1 passes
            {
                //Pada pass i, bandingkan n-i elemen pertama dengan elemen selanjutnya

                for (int j = 0; j < n; j++)
                {
                    if (a[j] > a[j + 1]) //jika elemen tidak dalam urutan yang benar
                    {
                        //Tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Method <c>Main</c>Method Main atau program utama untuk menjalankan program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Membuat Objek class dari BubbleSort
            Program myList = new Program();

            //Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            //Pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            //Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            //Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja untuk keluar. ");
            Console.Read();
        }
    }
}