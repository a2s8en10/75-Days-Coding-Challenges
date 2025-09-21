string str = "Anuragsahu";
string result = "";

Dictionary<char, int> freq = new Dictionary<char, int>();
foreach (char ch in str)
{
    if (freq.ContainsKey(ch))
    {
        freq[ch]++;
    }
    else
    {
        freq[ch] = 1;
    }
}
System.Console.WriteLine("Character Frequencies Check:");
foreach (var ch in freq)
{
    System.Console.WriteLine($"{ch.Key}: {ch.Value}");
}

foreach (var item in freq)
{
    if (item.Value == 1)
    {
        result = result + item.Key;
    }
}

System.Console.WriteLine("Remove the duplicates Characters : " + result);

System.Console.ReadLine();