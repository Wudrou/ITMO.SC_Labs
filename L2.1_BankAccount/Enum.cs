﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2._1_BankAccount
{
    public enum AccountType          //добавление перечисления AccountType
    {
        Checking, Deposit
    }
    class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccount = AccountType.Checking;
            AccountType platinumAccount = AccountType.Deposit;

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);

            Console.ReadKey();
        }
    }
}
