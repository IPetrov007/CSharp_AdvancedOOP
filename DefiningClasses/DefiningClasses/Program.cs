
using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Program
    {
        public static void Main()
        {
            var accounts = new Dictionary<int, BankAccount>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var commands = input.Split();
                var command = commands[0];

                switch (command)
                {
                    case "Create":
                        Create(commands, accounts);
                        break;
                    case "Deposit":
                        Deposit(commands, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(commands, accounts);
                        break;
                    case "Print":
                        Print(commands, accounts);
                        break;
                }
            }
        }

        private static void Print(string[] commands, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(commands[1]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine(accounts[id].ToString()); ;
            };
        }

        private static void Withdraw(string[] commands, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(commands[1]);
            var ammaunt = double.Parse(commands[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Withdraw(ammaunt);
            }
        }

        private static void Deposit(string[] commands, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(commands[1]);
            var ammaunt = double.Parse(commands[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Deposit(ammaunt);
            }
        }

        private static void Create(string[] commands, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(commands[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.ID = id;
                accounts.Add(id, acc);
            }
        }
    }
}
