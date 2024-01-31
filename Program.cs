class program
{
    static void  Main()
    {
        Random random = new Random(); // ett objekt för att kunna slumpa fram ett tal 
        int randomNumber = random.Next(1, 51); // slumpa talet mella 1 och 51
        int guess = 0; // variabeln för användares gissning
        Console.WriteLine(" Hej!, och välkommen till mitt gissa siffran spel");
        Console.WriteLine(" Jag har slumpat ett nummer från 1 till 51, försök gissa vilket tal jag har valt :)");
        while (true) // en while-loop som fortsättas till spelaren har gissat på rätt nummer
        {
            Console.WriteLine(" Gissa talet?");
            string input = Console.ReadLine(); // detta är till för att se till att användares inmatning läses in som en string

            if (!int.TryParse(input, out guess)) // kontrollerar om inmatningen kan ändras till ett heltal
            {
                Console.WriteLine("Felt gissat");
            }
            if (guess < randomNumber) // om gissningen är lägre en de slumpade nummret
            {
                Console.WriteLine("För lågt gissat"); // skrivs det ut detta meddelande för användaren
            }
            else if (guess > randomNumber) // om gissningen är högre en de slumpade nummret
            {
                Console.WriteLine("För högt gissat"); // skrivs ut detta meddelande för användaren
            }
            else // om gissningen är korrekt
            {
                Console.WriteLine(" Perfekt, du har gissat rätt! Rätt siffra är " + randomNumber + "!"); // skriv ut meddelande till användaren så att den vet att hen gissade rätt och berätta också för användaren vad nummret var 
                break;
            }
        }

    }



}