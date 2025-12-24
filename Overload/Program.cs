class Program
{
    class Printer
    {
        public static void Print(string text) =>
           Console.WriteLine(text);
        
        public static void Print(string text, int repeat)
        {
            for (int i = 0; i < repeat; i++)
                Print(text);
        }
    }

    static void Main()
    {
        Printer.Print("Hello, World!");
        Printer.Print("Repeat this line", 3);
    }
}