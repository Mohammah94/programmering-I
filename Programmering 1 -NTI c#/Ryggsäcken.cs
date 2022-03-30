using System;

namespace program
{
    class Program // här börjar klassen program.
    {
        static void Main(string[] args)
        {
            String thing = "";        // det är variable.
            bool run = true;
            while (run) // skapa en loop
            {
                Console.WriteLine("\tVälkommen till ryggsäcken!");//
                Console.WriteLine("\t[1] Lägg till ett föremål");//
                Console.WriteLine("\t[2] Skriv ut innehållet"); // skriv ut en meny
                Console.WriteLine("\t[3] Rensa innehållet");//
                Console.WriteLine("\t[4] Avsluta");//
                Console.WriteLine("\t Välj :");//
                int choice = Convert.ToInt32(Console.ReadLine()); // 
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\t Write the item name :");  
                        thing = Console.ReadLine();          
                        break;
                    case 2:
                        Console.WriteLine(thing); 
                        break;
                    case 3:
                        thing = "";
                        break;
                    case 4:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Function not avialable.");
                        break; // avbryter while-loopen
                        



                }

            }
        }
    }
}
           
