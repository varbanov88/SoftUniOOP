﻿using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var accounts = new Dictionary<int, BankAccount>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            var cmdArgs = input.Split();
            var command = cmdArgs[0];

            switch (command)
            {
                case "Create":
                    Create(cmdArgs, accounts);
                    break;

                case "Deposit":
                    Deposit(cmdArgs, accounts);
                    break;

                case "Withdraw":
                    Withdraw(cmdArgs, accounts);
                    break;

                case "Print":
                    Print(cmdArgs, accounts);
                    break;
            }
        }
    }

    private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id].ToString());
        }

        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        var amount = double.Parse(cmdArgs[2]);

        if (accounts.ContainsKey(id))
        {
            if (accounts[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }

            else
            {
                accounts[id].Withdraw(amount);
            }
        }

        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        var amount = double.Parse(cmdArgs[2]);

        if (accounts.ContainsKey(id))
        {
            accounts[id].Deposit(amount);
        }

        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }

        else
        {
            var acc = new BankAccount
            {
                ID = id
            };

            accounts.Add(id, acc);
        }
    }
}
