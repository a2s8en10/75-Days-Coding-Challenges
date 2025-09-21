string s = "babad";
string LongestPalindrom = s[0].ToString();

for (int i = 0; i < s.Length - 1; i++)
{
    if (s.Length - i < LongestPalindrom.Length) break;

    string currentStr = s[i].ToString();
    for (int j = i + 1; j < s.Length; j++)
    {
        currentStr += s[j].ToString();

        if (currentStr.Length <= LongestPalindrom.Length) continue;

        bool palindrom = true;
        for (int index = 0; index < currentStr.Length / 2; index++)
        {
            if (currentStr[index] != currentStr[currentStr.Length - 1 - index])
            {
                palindrom = false;
                break;
            }
        }
        if (palindrom) LongestPalindrom = currentStr;
    }
}
Console.WriteLine("Longest Substring Palindrom : " + LongestPalindrom);