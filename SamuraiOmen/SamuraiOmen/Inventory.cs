using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SamuraiOmen
{
    class Inventory
    {
        public void CheckInventory(Samurai player,string decision)
        {
            Console.Clear();
            Menu Menu = new Menu();
            Console.WriteLine("Backpack:");
            if (player.Items.Count > 0)
            {
                for (int i = 0; i < player.Items.Count; i++)
                {
                    Console.WriteLine("\n{0}. -{1}", i, player.Items[i]);
                }
                Console.WriteLine("\n0. Back", player.Name);
                decision = Console.ReadLine();
                if (decision == "0")
                {
                    Console.Clear();
                    Menu.MainMenu(player);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("This is not an option");
                    Thread.Sleep(1000);
                    Console.Clear();
                    CheckInventory(player, decision);
                }
            }
            else
            {
                Console.WriteLine("\nNo items are in your inventory");
                Console.WriteLine("\n0. Back", player.Name);
                decision = Console.ReadLine();
                if (decision == "0")
                {
                    Console.Clear();
                    Menu.MainMenu(player);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("This is not an option");
                    Thread.Sleep(1000);
                    Console.Clear();
                    CheckInventory(player, decision);
                }
            }
            

        }

        public void EquipItem(Samurai player, string Item)
        {

            player.HeldWeapon = Item;
            player.HeldFoot = Item;
            player.HeldHead = Item;
            player.HeldLegs = Item;
            player.HeldTorso = Item;
        }
    }
}
