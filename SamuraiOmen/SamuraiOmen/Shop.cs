using SamuraiOmen.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SamuraiOmen
{
    class Shop
    {
        private List<Item> ShopItems = new List<Item>();
        public List<int> ShopPrices { get; set; }

        public void CreateshoppingItems()
        {
            Items items = new Items();
            ShopItems.Add(items.CreateItem("Katana", 20));
            ShopItems.Add(items.CreateItem("Health-pack", 10));
            ShopItems.Add(items.CreateItem("Stamina-pack", 20));
            ShopItems.Add(items.CreateItem("Helmet", 20));
            ShopItems.Add(items.CreateItem("Breastplate", 20));
            ShopItems.Add(items.CreateItem("Pants", 20));
            ShopItems.Add(items.CreateItem("Boots", 50));
        }
        public void ShopMenu(Samurai player)
        {
            Menu menu = new Menu();
            CreateshoppingItems();
            Console.WriteLine("Welcome to the shop!");
            Console.WriteLine("Your current gold coins is: {0}g\n", player.GoldCoins);
            int i = 0;
            foreach (var item in ShopItems)
            {
                Console.WriteLine("{0}. {1} - {2}g", i , item.Name, item.Price);
                i++;
            }
            Console.WriteLine("\n \n0. Back");
            string decision = Console.ReadLine();
            if(decision == "1")
            {
                if(player.GoldCoins >= 20)
                {
                    int money = player.GoldCoins;
                    money -= 20;
                    player.GoldCoins = money;
                    Console.Clear();
                    Console.WriteLine("You bought the Katana!");
                    player.Items.Add("Katana");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ShopMenu(player);

                }
                else
                {
                    Console.WriteLine("You dont have enough gold coins for that!");
                    Console.Clear();
                    ShopMenu(player);
                }
            }
            else if (decision == "2")
            {
                if (player.GoldCoins >= 10)
                {
                    int money = player.GoldCoins;
                    money -= 10;
                    player.GoldCoins = money;
                    Console.Clear();
                    Console.WriteLine("You bought the Health-pack!");
                    player.Items.Add("Health-pack");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ShopMenu(player);

                }
                else
                {
                    Console.WriteLine("You dont have enough gold coins for that!");
                    Console.Clear();
                    ShopMenu(player);
                }
            }
            else if (decision == "3")
            {
                if (player.GoldCoins >= 15)
                {
                    int money = player.GoldCoins;
                    money -= 15;
                    player.GoldCoins = money;
                    Console.Clear();
                    Console.WriteLine("You bought the Stamina-pack!");
                    player.Items.Add("Stamina-pack");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ShopMenu(player);

                }
                else
                {
                    Console.WriteLine("You dont have enough gold coins for that!");
                    Console.Clear();
                    ShopMenu(player);
                }
            }
            else if (decision == "4")
            {
                if (player.GoldCoins >= 35)
                {
                    int money = player.GoldCoins;
                    money -= 35;
                    player.GoldCoins = money;
                    Console.Clear();
                    Console.WriteLine("You bought the Helmet!");
                    player.Items.Add("Helmet");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ShopMenu(player);

                }
                else
                {
                    Console.WriteLine("You dont have enough gold coins for that!");
                    Console.Clear();
                    ShopMenu(player);
                }
            }
            else if (decision == "5")
            {
                if (player.GoldCoins >= 45)
                {
                    int money = player.GoldCoins;
                    money -= 45;
                    player.GoldCoins = money;
                    Console.Clear();
                    Console.WriteLine("You bought the Breastplate!");
                    player.Items.Add("Breastplate");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ShopMenu(player);

                }
                else
                {
                    Console.WriteLine("You dont have enough gold coins for that!");
                    Console.Clear();
                    ShopMenu(player);
                }
            }
            else if (decision == "6")
            {
                if (player.GoldCoins >= 25)
                {
                    int money = player.GoldCoins;
                    money -= 25;
                    player.GoldCoins = money;
                    Console.Clear();
                    Console.WriteLine("You bought the Pants!");
                    player.Items.Add("Pants");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ShopMenu(player);

                }
                else
                {
                    Console.WriteLine("You dont have enough gold coins for that!");
                    Console.Clear();
                    ShopMenu(player);
                }
            }
            else if (decision == "0")
            {
                Console.Clear();
                menu.MainMenu(player);
            }
            else
            {
                Console.WriteLine("This is not a option.");
                Thread.Sleep(1000);
                Console.Clear();
                ShopMenu(player);
            }
        }
    }
}
