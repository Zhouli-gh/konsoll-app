namespace konsoll_app;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Hva heter du?");
       var input = Console.ReadLine();
       Console.WriteLine($"Velkommen {input}!");
    }
}