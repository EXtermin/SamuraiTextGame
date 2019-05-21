﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SamuraiOmen
{
    class Menu
    {

        public void MainMenu(Samurai player)
        {
            Console.WriteLine("Name: {0}", player.Name);
            Console.WriteLine("Health: {0}/{1}", player.Health, player.MaxHealth);
            Console.WriteLine("Stamina: {0}/{1}", player.Stamina, player.MaxStamina);
            Console.WriteLine("Gold: {0}", player.GoldCoins);
            Console.WriteLine("Held Item: {0}", player.HeldItem);
            Console.WriteLine("1. Check inventory/Equipment", player.Name);
            Console.WriteLine("2. Rest (Regain health,stamina)", player.Name);
            Console.WriteLine("3. Battle");
            Console.WriteLine("4. Shop");
            Console.WriteLine("\n9. Save");
            Console.WriteLine("0. Exit");
            string decision = Console.ReadLine();
            SaveMenu(player, decision);
            if (decision == "1")
            {
                Inventory inventory = new Inventory();
                inventory.CheckInventory(player, decision);
                Console.WriteLine("\n0. Back", player.Name);
                decision = Console.ReadLine();
                if (decision == "0")
                {
                    Console.Clear();
                    MainMenu(player);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("This is not an option");
                    Thread.Sleep(1000);
                    Console.Clear();
                    MainMenu(player);
                }

            }
            else if (decision == "2")
            {

            }
            else if (decision == "3")
            {
                Random rnd = new Random();
                int enemy = rnd.Next(1, 4);
                Console.WriteLine("\n {0}", enemy);
                Console.ReadKey();
                Console.Clear();
                MainMenu(player);
            }
            else if (decision == "4")
            {
                Console.Clear();
                player.GoldCoins += 40;
                Shop shop = new Shop();
                shop.ShopMenu(player);
            }
            else
            {
                Console.Clear();
                MainMenu(player);
            }
        }
        
        public void SaveMenu(Samurai player, string decision)
        {
            
            if(decision == "0")
            {
                Environment.Exit(0);

            }
            else if (decision == "9")
            {
                Environment.Exit(0);
            }
        }
    }
}
