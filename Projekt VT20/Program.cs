using System;

namespace Projekt_VT20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string place = "Dungeon Start"; //Platsen börjar som ett place som heter Dungeon start
            while (place != "end") // Så länge Place inte är lika med "end" så kommer spelet fortsätta att gå.
            {
                if (place == "Dungeon Start") // Om spelaren startar i "Dungeon Start" Så visas nedstående kod
                {
                    Console.WriteLine("You are awake now!");
                    Console.WriteLine("Now when you are awake, we need to get out of this dungeon!");
                    Console.WriteLine("What way do you want to go?");
                    Console.WriteLine("The traintracks or The glowy path?");
                    string inpt = Console.ReadLine(); // Inpt lagrar valet av plats man skriver i stringen

                    if (inpt == "The traintracks") // Om man skrev in att man vill till "The traintracks" så kommer inpt ihåg och så syns nedstånende kod.
                    {
                        place = "The traintracks";
                        Console.WriteLine("Welcome to the traintracks, you can now continue further.");

                        Console.WriteLine("What way do you want to go?");
                        Console.WriteLine("Continue on the road or Turn right and take the stairs?");
                        inpt = Console.ReadLine();
                    }
                    





                    if  (inpt == "The glowy path") //Om man skrev "The glowy path" så stöter man på att spelet tar slut
                    {


                        Console.WriteLine("The player went into the glowy path and it was so bright so he fell down in a hole!");
                        Console.WriteLine("Game over");
                        Console.ReadLine();
                        place = "end"; //Detta gör så att spelet tar slut

                    

                    }

                    else
                    {
                        Console.WriteLine("I didn't get what you said?");
                        Console.WriteLine("Please say it again");
                        Console.ReadLine();
                    }
                }
            }

        }
    }
}
