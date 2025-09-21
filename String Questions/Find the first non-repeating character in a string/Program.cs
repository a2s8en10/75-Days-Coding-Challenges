System.Console.Write("Enter a string:");
string str = System.Console.ReadLine();
char result = ' ';
bool flag = true;
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

foreach (var item in freq)
{
    if (item.Value == 1 && flag == true)
    {
        result = item.Key;
        flag = false;
    }
}
System.Console.WriteLine("First non-repeating character is : " + result);
System.Console.ReadLine();