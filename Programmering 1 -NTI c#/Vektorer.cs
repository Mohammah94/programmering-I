using System;

namespace uppgift_5
{
    using System;

        class Program // här börjar klassen program.
        {
            static void Main(string[] args)
            {
            String[] ryggsäck = new string[5]; //skapa vektorn

                String thing = "";        // det är variable.
            int i = 0;
                bool run = true;
                while (run) // skapa en loop
                {
                    Console.WriteLine("\tVälkommen till ryggsäcken!");//
                    Console.WriteLine("\t[1] Lägg till ett föremål");//
                    Console.WriteLine("\t[2] Skriv ut innehållet"); // skriv ut en meny
                    Console.WriteLine("\t[3] Sök i ryggsäcken");//
                    Console.WriteLine("\t[4] Avsluta");//
                    Console.WriteLine("\t Välj :");//
                                          
                // int choice = Convert.ToInt32(Console.ReadLine());
                
                int choice;
                bool s = Int32.TryParse(Console.ReadLine(), out choice);
                if (!s)
                {
                    Console.WriteLine("inmatning fel ");

                }

                else
                {
                    switch (choice)
                    {
                        case 1:
                            if (i >= ryggsäck.Length)
                            {
                                Console.WriteLine("the bag is full");
                            }
                            else
                            {


                                Console.WriteLine("\t Write the item name :");
                                thing = Console.ReadLine();
                                ryggsäck[i] = thing;
                                i++;
                            }
                            break;
                        case 2:
                            for (int j = 0; j < ryggsäck.Length; j++) // for-loopen går igenom vektorn.
                            {
                                Console.WriteLine(ryggsäck[j]); //skriv ut
                            }

                            break;
                        case 3:
                            Console.WriteLine("vad söker du ?");
                            string sökning = Console.ReadLine();
                            for (int j = 0; j < ryggsäck.Length; j++) // Den for-loopen
                            {
                                if (ryggsäck[j].ToUpper() == sökning.ToUpper())
                                {

                                    Console.WriteLine("the item that you are searching is in index number : " + j);
                                    break;
                                }

                            }
                            break;
                        case 4:
                            run = false;
                            break;
                        default:
                            Console.WriteLine("Function not avialable.");
                            break; //




                    }
                }
                }
            }
        }
    }


