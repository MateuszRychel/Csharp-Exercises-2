List<string> emails = new List<string>
        {
            "anna@example.com",
            "bob@example.com",
            "anna@example.com",
            "carol@example.com",
            "bob@example.com"
        };

HashSet<string> unikalne_emaile = new HashSet<string>(emails);

List<string> sortedEmails = unikalne_emaile.OrderBy(email => email).ToList();

Console.WriteLine($"Liczba unikalnych adresów: {sortedEmails.Count}");
Console.WriteLine("Adresy email:");
foreach (var email in sortedEmails)
{
    Console.WriteLine(email);
}
