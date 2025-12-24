class Program
{
    class University
    {
        public const string Country = "Aqtobe";
        public readonly int FoundedYear;

        public University(int foundedYear) =>
            FoundedYear = foundedYear;
    }

    static void Main()
    {
        var uni = new University(1636);
        Console.WriteLine($"Country: {University.Country}, Founded Year: {uni.FoundedYear}");
    }
}
