using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SamuraiOmen
{
    class Storyline
    {
        Samurai player;
        Menu Menu = new Menu();

        public void start()
        {
            Samurai player = new Samurai();
            Console.WriteLine("Welcome to Samurai Omen! \n" +
                "This is a Text game made by Iron Sword Studios \n" +
                "We hope you enjoy playing our game!");

            Thread.Sleep(1500);
            Console.WriteLine("\n \n Samurai Omen......");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Enter your name:");
            player.CreateSamurai(Console.ReadLine());
            this.player = player;
            Console.Clear();
            Console.WriteLine("Creating Samurai 0%");
            Console.WriteLine("...............");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Creating Samurai 20%");
            Console.WriteLine("|||............");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("Creating Samurai 40%");
            Console.WriteLine("|||||||..........");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Creating Samurai 55%");
            Console.WriteLine("||||||||||.......");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Creating Samurai 85%");
            Console.WriteLine("||||||||||||||...");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Creating Samurai 100%");
            Console.WriteLine("|||||||||||||||||");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Samurai created, enjoy your adventure!");
            //Console.WriteLine("{0} {1} {2} {3} {4} {5}",player.Health, player.HeldItem, player.MaxBasicDamage, player.MaxStamina, player.power, player.Name);
            Console.WriteLine("Press enter to continue!");
            Console.ReadKey();
            Console.Clear();
            begin();
            
        }
        public void begin()
        {
            //hier komt de aankomst in, waar wij vertellen waarom de samurai hiero is enzo.
            Console.WriteLine("blabla aankomst hiero(skip cause there aint a story here yet c:)");
            Console.ReadKey();
            Console.Clear();
            Menu.MainMenu(player);
        }
    } 
}
