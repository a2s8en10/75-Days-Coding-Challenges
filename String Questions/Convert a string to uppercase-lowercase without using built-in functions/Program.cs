using System;

string str = "Anurag Sahu";
string lowerCase = "";
string upperCase = "";
foreach (char ch in str)
{
    if (ch >= 'a' && ch <= 'z')
    {
        lowerCase += ch;
        upperCase += (char)(ch - 32); // Convert to uppercase and cast to char
    }
    else if (ch >= 'A' && ch <= 'Z')
    {
        upperCase += ch;
        lowerCase += (char)(ch + 32); // Convert to lowercase and cast to char
    }
}
Console.WriteLine("Original String: " + str);
Console.WriteLine("Lowercase: " + lowerCase);
Console.WriteLine("Uppercase: " + upperCase);

System.Console.ReadLine();