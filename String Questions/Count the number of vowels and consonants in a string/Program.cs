System.Console.Write("Enter a string: ");
string str = System.Console.ReadLine();
string vowels = "aeiouAEIOU";
int count = 0, consonants = 0, spaces = 0;

foreach (var ch in str)
{
    if (vowels.Contains(ch))
    {
        count++;
    }
    else if (char.IsLetter(ch))
    {
        consonants++;
    }
    else if (ch == ' ')
    {
        spaces++;
    }
}

System.Console.WriteLine($"Vowels: {count}, Consonants: {consonants}");
System.Console.ReadLine();