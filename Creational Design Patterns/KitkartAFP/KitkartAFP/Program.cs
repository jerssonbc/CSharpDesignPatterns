﻿using System;
using System.Linq;
using kitkart.core;

namespace KitkartAFP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Client (a or b): ");
            var client = Console.ReadLine();

            IFactory factory;

            if (client == "a")
            {
                factory = new ClientAFactory();
            }else if (client =="b")
            {
                factory = new ClientBFactory();
            }
            else
            {
                return;
            }
            var order = new Order();

            Console.Write("How many computers? ");
            order.Computers = ConvertToInt32(Console.ReadLine());

            Console.Write("How many tablets? ");
            order.Tablets = ConvertToInt32(Console.ReadLine());

            Console.Write("How many phones? ");
            order.SmartPhones = ConvertToInt32(Console.ReadLine());

            var company = new KitkartManufacturingCompany(factory);

            company.Produce(order);
            Console.WriteLine("Created " + company.Computers.Count()+ " computers.");
            Console.WriteLine("Created " + company.Tablets.Count() + " tablets.");
            Console.WriteLine("Created " + company.SamSmartPhones.Count() + " phones.");

            Console.ReadLine();
        }

        private static int ConvertToInt32(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;
            return Int32.Parse(input);
        }
    }
}
