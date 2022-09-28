using System;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;

class Program
{

    public static void Main(string[] args)
    {
      
        {
            bool playactive = true;



            loop(playactive);
            playactive = true;
            loop(playactive, 1);
            playactive = true;
            loop(playactive, 2);



        }
    }
    

    static void loop(bool playactive, int playthrough = 0)
    {


      
        while (playactive == true)
            
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("press w to progress the story and type out your choice exactly how the story presents it to you");
            Console.ForegroundColor = ConsoleColor.White;
            double speed = 10;
            double pwr = 10;
            double health = 100;  
            double epower = 10;
            double espeed = 10;
            double ehealth = 100;
            double dmg = 0;
            double edmg= 0;
            bool win = false;
            
          
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Red;
            if (key.Key == ConsoleKey.W)
            {
                if (playthrough == 0)
                {
                    Console.WriteLine(" 𝘸𝘩𝘦𝘳𝘦 𝘢𝘮 𝘐? 𝘯𝘰 𝘴𝘤𝘳𝘢𝘱 𝘵𝘩𝘢𝘵, 𝘸𝘩𝘰 𝘢𝘮 𝘐?");
                }
                else if (playthrough == 1)
                {
                    Console.WriteLine(" Where am I?  no scrap that, who am I?");
                }
                else
                {
                    Console.WriteLine(" why do i know where i am?");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            key = Console.ReadKey(false);          
            if (key.Key == ConsoleKey.W)
            {
                Console.WriteLine(" As the world slowly adorns my eyes i try to survey my surrondings in hope of finding a answer, i seem to be sat up against a wall in a ruined alleyway with what seems like crystals sticking out from the crubleling buildings. A small girl with pink hair is perched next to me looking at me inquisitively");
            }   
            if (playthrough == 0)
            {
                speed = 10;
                pwr = 10;
            }
            else
            {
                pwr = 5;
                speed = 5;
            }
            key = Console.ReadKey(false);
            if (key.Key == ConsoleKey.W)
            {
                Console.WriteLine(" Girl: ah! you have awakend at last! i was getting worried! ");
            }
            key = Console.ReadKey(false);
            if (key.Key == ConsoleKey.W)
            {
                Console.WriteLine(" You: who are you? who even am i? where the hell are we? ");
            }
            key = Console.ReadKey(false);
            if (key.Key == ConsoleKey.W)
            {
                Console.WriteLine(@"  inori: im inori you are 'leave' as for anything else i am unsure thats all i can rememeber, however you probably want to grab one of those wepons ive seen hideous cretures strolling these streets");
            }
            key = Console.ReadKey(false);
            if (key.Key == ConsoleKey.W)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (playthrough == 0)
                {
                    Console.WriteLine(" beside you rests a large axe, will you take the axe? yes or no ");
                }
                else if (playthrough == 1)
                {
                    Console.WriteLine("beside you rests a rusty looking sword and a large axe, you can only take one, sword or axe ?");
                }
                else
                {
                    Console.WriteLine("beside you rests a smalll dagger , a rusty looking sword and a large axe, you can only take one, sword , axe , dagger or no weapon ?");
                }
            Console.ForegroundColor = ConsoleColor.White;
                
                
               string Weapon = Console.ReadLine();
               Console.ForegroundColor = ConsoleColor.Red;

                if (Weapon == "yes")
                {
                    speed = speed - 5;
                    pwr = pwr + 15;

                    Console.WriteLine(" A axe! its heavy but it will sure do alot of damage!!!");

                }
                else if (Weapon == "sword")
                {
                    pwr = pwr + 10;
                    Console.WriteLine(" A sword! the perfect balence balence between agility and power!");
                }
                else if (Weapon == "dagger")
                {
                    pwr  =+ 5;
                    speed = speed + 5;  
                    Console.WriteLine(" A dagger! it might not pack the biggest punch but you will defiantly get the first shot!");
                }
                else
                {
                    speed = speed + 10;
                    Console.WriteLine("really? dont regret it, show 'em your fists of iron");
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                key = Console.ReadKey(false);
                if (key.Key == ConsoleKey.W)
                {
                    Console.WriteLine(" As you eqip your chosen wepon to your person suddenly you hear a growl, infrount of you is a disfigured wolf, its time to fight");
                }
                Console.ForegroundColor = ConsoleColor.White;

                fight(speed, pwr, health, epower, espeed, ehealth, dmg, edmg, win);










            }
            playactive = false;
        }
    }


    static void fight(double speed = 10, double pwr = 10, double health = 100,  double epower = 10, double espeed = 10,double ehealth = 100,double dmg = 0,double edmg = 0,bool win = false)
    {
        int roll = 0;
        int eroll = 0;
        

        Console.WriteLine("your health" + health);
        Console.WriteLine("enemy health" + ehealth);

        do
        {
            if (espeed > speed)
            {

                eroll = DiceRoll(0, 3);
                health -= epower * eroll;
                Console.WriteLine("your health" + health);
            }
            else if (espeed < speed)
            {
                roll = DiceRoll(0, 3);
                ehealth -= pwr * roll;
                Console.WriteLine("enemy health:" + ehealth);
            } 
            if ((espeed < speed) && (ehealth > 0) && (health > 0))
            {

                roll = DiceRoll(0, 3);
                health -= epower * roll;
                Console.WriteLine("your health" + health);
            }
             else if ((espeed > speed) && (ehealth > 0) && (health > 0))
            {
                eroll = DiceRoll(0, 3);
                ehealth -= pwr * eroll;
                Console.WriteLine("enemy health:" + ehealth);
            }
        } while (health >= 0 && ehealth >= 0);

        if (pwr > epower)
        {
            win = true; 
        }


    }

    private static int DiceRoll(int min, int max)
    {
        int result;
        Random rnd = new Random();

        result = rnd.Next(min, max);
        return result;
    }

}






