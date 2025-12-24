class Program
{
    record Passport(string Number, string Country) {}

    static void Main()
    {
        var passport1 = new Passport("123456789", "USA");
        var recordedPassport = passport1 with { Number = "123456788" };

        Console.WriteLine(passport1);          // Output: Passport { Number = 123456789, Country = USA }
        Console.WriteLine(recordedPassport);   // Output: Passport { Number = 123456788, Country = USA }
        Console.WriteLine(passport1.Country == recordedPassport.Country); // Output: True (Country is the same)
        Console.WriteLine(ReferenceEquals(passport1, recordedPassport)); // Output: False (Numbers are different)
    }
}