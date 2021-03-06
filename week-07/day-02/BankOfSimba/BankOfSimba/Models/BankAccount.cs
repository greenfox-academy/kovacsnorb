﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Balance { get; set; }
        public string AnimalType { get; set; }
        public string Currency { get; set; }
        public bool IsKing { get; set; }
        public bool IsGoodGuy { get; set; }

        public List<BankAccount> accountList = new List<BankAccount>();

        public BankAccount()
        {
        }

        public BankAccount(string name, string balance, string animalType, string currency, bool isKing, bool isGoodGuy)
        {
            Name = name;
            Balance =  float.Parse(balance).ToString("0.00");
            AnimalType = animalType;
            Currency = currency;
            IsKing = isKing;
            IsGoodGuy = isGoodGuy;
        }
    }
}
