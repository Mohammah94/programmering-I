using system;

namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaration av variabler
            Random slumpat = new Random(); // skapar ett random objekt
            int speltal = slumpat.Next(1, 21); // anropar Next metoden för att skapa ett slumptal mellan 1 och 20 
            // du bör specificera intevalet för slumpat.next()funktion så att du kan ha ett slumptal mellan 1,20. 
            // läs på, vad är overload metoder? https://msdn.microsoft.com/en-us/library/system.random.next(v=vs.110).aspx
            bool spela = true; // Variabel för att kontrollera om spelet ska fortsätta köras

            while (spela) // while loop kommer inte att köras när ( ! spela), därför att det kommer alltid vara fel.   
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
                int tal;  // vi behöver använda TryParse för att undvika fel inmatning för användaren.
               bool success = Int32.TryParse(Console.ReadLine(), out tal);
                if (!success)
                {
                    Console.WriteLine("inmatning fel");
                }
                else
                {


                    if (tal < speltal)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         {
                        Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                    }

                    if (tal > speltal)
                    {
                        Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen."); // jag tillägger + för att kunna kombinera intger med string. 
                    }

                    if (tal == speltal)   // tillägg här oskså = tecken
                        Console.WriteLine("\tGrattis, du gissade rätt!");
                    Console.ReadLine();
                    spela = false;

                }
            }
        }
    }
}
