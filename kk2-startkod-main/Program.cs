ShoppingList list = new ShoppingList("items.txt");
list.Load();

while (true)
{
    Console.WriteLine();
    list.Print();
    Console.WriteLine();
    Console.WriteLine("1. Lägg till vara");
    Console.WriteLine("2. Ta bort vara");
    Console.WriteLine("3. Spara");
    Console.WriteLine("4. Sök vara");
    Console.WriteLine("5. Avsluta");
    Console.Write("Välj: ");

    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Ogiltigt val använd nummer tack .");
        continue;
    }

    if (choice == 1)
    {
        Console.Write("Namn: ");
        string name = Console.ReadLine();
        Console.Write("Pris: ");
        if (!int.TryParse(Console.ReadLine(), out int price))
        {
            Console.WriteLine("Ogiltigt pris. skriv heltal tack.");
            continue;
        }
        try
        {
            Item item = new Item(name, price);

            if (!list.Add(item))
            {
            Console.WriteLine("Varan ryms inte inom budgettaket och lades inte till i din lista.");
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Ogiltigt pris: priset får inte vara negativt.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Ogiltig vara: namnet får inte vara tomt.");
        }
    }

    else if (choice == 2)
    {
        Console.Write("Nummer: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Ogiltigt nummer. skriv heltal tack.");
            continue;
        }
        list.RemoveAt(number);
    }
    else if (choice == 3)
    {
        list.Save();
    }
    else if (choice == 4)
    {
        Console.Write("Namn att söka efter: ");
        string wanted = Console.ReadLine();
        Item found = list.Find(wanted);

        if (found == null)
        {
            Console.WriteLine("Varan finns inte i listan.");
        }
        else
        {
            Console.WriteLine($"Hittade: {found}");
        }
    }
    else if (choice == 5)
    {
        break;
    }
}
