System.Console.Write("Enter the first string: ");
string str1 = System.Console.ReadLine();
System.Console.Write("Enter the second string: ");
string str2 = System.Console.ReadLine();

if (str1.Length != str2.Length)
{
    System.Console.WriteLine("Not an anagram because length are not same");
    return;
}

foreach (var item1 in str1)
{
    bool anagram = false;
    foreach (var item2 in str2)
    {
        if (item1 == item2)
        {
            anagram = true;
            break;
        }
    }
    if (!anagram)
    {
        Console.WriteLine("Not an anagram");
        return;
    }
}
Console.WriteLine("It is an Anagram");
System.Console.ReadLine();
