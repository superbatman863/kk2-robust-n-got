// Holds the items and takes care of loading and saving them.
class ShoppingList
{
    private List<Item> items = new List<Item>();
    private string path;

    public ShoppingList(string path)
    {
        this.path = path;
    }

    public void Add(Item item)
    {
        items.Add(item);
    }

    // Removes the item the user sees as number 1, 2, 3 ...
    public void RemoveAt(int number)
    {
        if (number < 1 || number > items.Count)
        {
            Console.WriteLine("Det finns ingen vara med det numret.");
            return;
        }
        items.RemoveAt(number - 1);
    }

    // Adds up the price of every item on the list.
    public int Total()
    {
        int sum = 0;

        for (int i = 0; i < items.Count; i++)
        {
            sum += items[i].Price;
        }

        return sum;
    }

    // Looks up an item by its name. Returns null if there is no such item.
    public Item Find(string name)
    {
        foreach (Item item in items)
        {
            if (item.Name == name)
            {
                return item;
            }
        }

        return null;
    }

    public void Print()
    {
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }

        Console.WriteLine($"Totalt: {Total()} kr");
    }

    // Writes one item per line, as "price;name".
// Writes one item per line, as "price;name".
    public void Save()
    {
        List<string> lines = new List<string>();
        
        foreach (Item item in items)
        {
        lines.Add($"{item.Price};{item.Name}");
        }
        try
        {
            File.WriteAllText(path, string.Join("\r\n", lines) + "\r\n");
            Console.WriteLine("Listan är sparad.");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Listan kunde inte sparas (ingen åtkomst): {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Listan kunde inte sparas: {ex.Message}");
            }
    }

    // Reads the file back into the list.
    public void Load()
    { 
        string[] lines;
        try
        {
            lines = File.ReadAllLines(path);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Ingen sparad lista hittades. Börjar med en tom lista.");
            return;
        }


        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            items.Add(new Item(parts[1], int.Parse(parts[0])));
        }
    }
}
