using System;
using System.Xml;

class Program
{
    public static void Main(string[] args)
    {
        bool playactive = true;
        while (playactive == true)
        {
            int playthrough = 0;
            double speed = 0;
            double pwr = 0;
            double epower = 0;
            double espeed = 0;
            if (playthrough == 0)
            {
                Console.WriteLine("𝘸𝘩𝘦𝘳𝘦 𝘢𝘮 𝘐? 𝘯𝘰 𝘴𝘤𝘳𝘢𝘱 𝘵𝘩𝘢𝘵, 𝘸𝘩𝘰 𝘢𝘮 𝘐?");
            }
            else if (playthrough == 1)
            {
                Console.WriteLine("where am I?  no scrap that, who am I?");
            }
            else
            {
                Console.WriteLine("why do i know where i am?");
            }

            Console.WriteLine("As the world slowly adorns my eyes i try to survey my surrondings in hope of finding a answer, i seem to be sat up against a wall in a ruined alleyway with what seems like crystals sticking out from the crubleling buildings. A small girl with pink hair is perched next to me looking at me inquisitively");
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
            Console.WriteLine(" Girl: ah! you have awakend at last! i was getting worried! ");
            Console.WriteLine(" You: who are you? who even am i? where the hell are we? ");
            Console.WriteLine(@"Girl: im inori you are 'leave' as for anything else i am unsure thats all i can rememeber, however you probably want to grab one of those wepons ive seen what looks like monsters walking about");
            if (playthrough == 0)
            {
                Console.WriteLine("beside you rests ");
            }
            playactive = false;
        }
        playactive = true;
    }
    }

        

