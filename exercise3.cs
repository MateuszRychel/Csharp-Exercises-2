using System;
using System.Collections.Generic;

class PhoneBook
{
    private readonly Dictionary<string, List<string>> book = new();

    public void AddNumber(string surname, string number)
    {
        if (string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(number))
        {
            Console.WriteLine("Nazwisko i numer nie mogą być puste.");
            return;
        }

        if (!book.ContainsKey(surname))
        {
            book[surname] = new List<string>();
        }

        if (!book[surname].Contains(number))
        {
            book[surname].Add(number);
            Console.WriteLine($"Dodałeś numer {number} dla nazwiska {surname}");
        }
        else
        {
            Console.WriteLine($"Numer {number} już istnieje dla nazwiska {surname}");
        }
    }

    public void RemoveNumber(string surname, string number)
    {
        if (book.ContainsKey(surname) && book[surname].Contains(number))
        {
            book[surname].Remove(number);
            Console.WriteLine($"Usunięto numer {number} dla nazwiska {surname}");

            if (book[surname].Count == 0)
            {
                book.Remove(surname);
                Console.WriteLine($"Usunięto całkowicie wpis dla nazwiska {surname} (brak numerów)");
            }
        }
        else
        {
            Console.WriteLine($"Nie znaleziono numeru {number} dla nazwiska {surname}");
        }
    }

    public void Search(string surname)
    {
        if (book.ContainsKey(surname))
        {
            Console.WriteLine($"Numery dla {surname}:");
            foreach (var number in book[surname])
            {
                Console.WriteLine($"{number}");
            }
        }
        else
        {
            Console.WriteLine($"Brak wpisu dla nazwiska {surname}");
        }
    }
}
