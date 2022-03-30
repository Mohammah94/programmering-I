using System;
using System.Collections.Generic;
using System.Globalization;

namespace loggboken
{
    class Program
    {



        static void Main(string[] args)
        { 
            List<string[]> loggbok = new List<string[]> { };// skpa en lista.

            bool run = true;
            while (run) // skapa en loop.
            {
                Console.WriteLine("\tVälkommen till loggboken!");//
                Console.WriteLine("\t[1] Lägg till en ny logg");//
                Console.WriteLine("\t[2] Skriv ut innehållet"); // skriv ut en meny
                Console.WriteLine("\t[3] Sök en logg");//
                Console.WriteLine("\t[4] Avsluta");//
                Console.WriteLine("\t Välj :");//

                int choice; // vi behöver använda TryParse för att undvika inmatning fel för användaren.
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

                            string[] logg = new string[3]; // skapa en array.
                            Console.WriteLine("skriv en title"); 
                            string title = Console.ReadLine();
                            logg[0] = title; // lägg title till array.
                            Console.WriteLine("skiv ett datum");// 
                            DateTime D;
                            CultureInfo Dc = new CultureInfo("fr-FR"); // datum format.

                            while (!DateTime.TryParse(Console.ReadLine(),Dc,DateTimeStyles.None, out D)) // kolla om datumet är rätt.
                            {
                                Console.WriteLine("\t fel inmatning");
                                Console.WriteLine("\t skriv ett datum");
                                
                            }
                            string date = D.ToString("yyyy/MM/dd");// datumet format.
                            logg[1] = date; // lägg date till array.

                            Console.WriteLine("skriv en text");
                            string text = Console.ReadLine();
                            logg[2] = text; // lägg text till text.


                            loggbok.Add(logg);


                            break;
                        case 2:
                            if (loggbok.Count == 0) { Console.WriteLine("loggbok är tom"); }
                            else
                            {
                                foreach (string[] log in loggbok) // for-loopen går igenom vektorn.
                                {
                                    Console.WriteLine("\t Title: " + log[0] + " Datum: " + log[1]+ "  Text: " + log[2]); //skriv ut
                                    Console.WriteLine("\t "); //Empty line.

                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("vad söker du ?");
                            string sökning = Console.ReadLine();
                            bool find = false;

                            foreach (string[] log in loggbok) // Den for-loopen.
                            {
                                if (log[0].ToUpper() == sökning.ToUpper())
                                {
                                    Console.WriteLine("\tTitle: " + log[0] + " Datum: " + log[1] + "  Text: " + log[2]);
                                    Console.WriteLine("\t "); //Empty line.
                                    find = true;
                                    break;
                                }
                              
                            }
                            if (!find) { Console.WriteLine(" logg finns inte"); }
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