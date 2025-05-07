namespace konsoll_app;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Hva heter du?");
       var input = Console.ReadLine();
       Console.WriteLine($"Velkommen {input}!");
       Console.WriteLine("Hvor gammel er du?");
       var input2 = Console.ReadLine();
       Console.WriteLine($"Jeg er {input2} år gammel!");
    }
}