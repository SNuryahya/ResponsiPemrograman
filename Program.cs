using System;

namespace ResponsiPemrograman26191
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker (19112619, "Nuryahya", 9999999);
            Worker worker2 = new Worker (18192598, "Nanda",   15000000);


            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            worker.showWorker();
            worker2.showWorker();

            Console.WriteLine("\n\n Mantap Naik Gajiii");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            worker.naikGaji();
            worker2.naikGaji();

            Console.ReadKey();
        }
    }

    
}