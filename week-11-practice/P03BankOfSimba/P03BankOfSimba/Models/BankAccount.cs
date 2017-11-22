﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P03BankOfSimba.Models
{
    public class BankAccount
    {
        public BankAccount(string name, double balance, Animal animalType)
        {
            Name = name;
            Balance = string.Format("{0:0.00}", balance);
            AnimalType = animalType;
            Currency = "Zebra";
        }

        public string Name { get; set; }
        public string Balance { get; set; }
        public Animal AnimalType { get; set; }
        public string Currency { get; set; }
    }
}