
class Program
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title): this(title, "Unknown", DateTime.Now.Year) {}

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public void PrintInfo() =>
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year Published: {Year}");
    }

    static void Main(string[] args)
    {
        Book book1 = new("1984", "George Orwell", 1949);
        Book book2 = new("The Great Gatsby");

        book1.PrintInfo();
        book2.PrintInfo();
    }
}