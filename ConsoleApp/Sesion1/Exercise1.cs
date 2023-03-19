// See https://aka.ms/new-console-template for more information

class Exercise1
{

    public void execute()
    {
        Console.WriteLine("Write your name");

        string? name = Console.ReadLine();

        string value = name is not null && name.Count() > 0 ? name : "world";

        Console.WriteLine($"Hello {value}");
    }

}

