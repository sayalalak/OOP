using System;
using System.Collections;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer("Lalak", 35900189, 1234, 500000);

            int pin;
            int balance = cust1.Balance;
            int deposit, withdrawal;
            ArrayList mutation = new ArrayList();
            Console.WriteLine("Silahkan Inputkan Pin Anda");
            pin = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            bool condition = true;

            while (ChekPin(pin, cust1.Pin))
            {
                while (condition)
                {
                    Menu();
                    int choice;
                    Console.WriteLine("Silahkan pilih menu : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            cust1.ShowData();
                            Console.WriteLine($"Saldo anda adalah : Rp.{balance}");
                            break;
                        case 2:
                            cust1.ShowData();
                            Console.WriteLine("Silahkan input jumlah setoran : ");
                            deposit = Convert.ToInt32(Console.ReadLine());
                            balance += deposit;
                            Console.WriteLine("Uang berhasil disetorkan");
                            Console.WriteLine($"Saldo anda adalah : Rp.{balance}");
                            mutation.Add($"Setor Tunai Rp. {deposit}");
                            break;
                        case 3:
                            cust1.ShowData();
                            Console.WriteLine("Silahkan input jumlah tarikan : ");
                            withdrawal = Convert.ToInt32(Console.ReadLine());
                            if (balance > withdrawal)
                            {
                                balance -= withdrawal;
                                Console.WriteLine("Uang berhasil ditarik");
                                mutation.Add($"Tarik Tunai Rp.{withdrawal} ");
                            }
                            else
                            {
                                Console.WriteLine("Saldo Tidak Cukup!!");
                                Console.WriteLine("Silahkan lakukan setoran");
                            }
                            Console.WriteLine($"Saldo anda adalah : Rp.{balance}");
                            break;
                        case 4:
                            cust1.ShowData();
                            Console.WriteLine("Data Mutasi Rekening Anda");
                            foreach (var data in mutation)
                            {
                                Console.WriteLine(data + "\n");
                            }
                            try
                            {
                                if (mutation.Count == 0)
                                {
                                    Console.WriteLine(mutation[0]);
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("ERROR : Belum ada riwayat Transaksi yang dilakukan ");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Terimakasih Telah Menggunakan Mesin ATM <3");
                            Environment.Exit(0);
                            break;
                    }
                    Console.WriteLine("Ingin Melakukan Transaksi Lain ? y/n");
                    string n = Console.ReadLine();
                    Console.Clear();
                    if (n == "y")
                    {
                        condition = true;
                    }
                    else
                    {
                        Console.WriteLine("Terimakasih Telah Menggunakan Mesin ATM <3");
                        condition = false;
                    }
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("SELAMAT DATANG DI MESIN ATM");
            Console.WriteLine("===========================");

            Console.WriteLine("1. Cek Saldo");
            Console.WriteLine("2. Setor Tunai");
            Console.WriteLine("3. Tarik Tunai");
            Console.WriteLine("4. Cek Mutasi");
            Console.WriteLine("5. Exit");
        }
        static bool ChekPin(int pin, int check)
        {
            if (pin == check) { return true; }
            else
            {
                Console.WriteLine("Pin Salah, Silahkan input ulang");
                Environment.Exit(0);
                return false;
            }
        }

    }
}
