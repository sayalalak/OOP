using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class Customer
    {
        public string Name { get;  set; }
        public int AccNumber { get; set; }
        public int Pin { get; set; }
        public int Balance { get; set; }
        public Customer()
        {

        }

        public Customer(string name, int accNumber, int pin, int balance)
        {
            Name = name;
            AccNumber = accNumber;
            Pin = pin;
            Balance = balance;
        }

        public void ShowData()
        {
            Console.WriteLine("===Data Nasabah===");
            Console.WriteLine($"Nama    : {Name}");
            Console.WriteLine($"No. Rek : {AccNumber}");
        }

    }
}
