string str = "Anurag";
for (int i = 0; i < str.Length; i++)
{
    string temp = "";
    for (int j = i; j < str.Length; j++)
    {
        temp += str[j];
        Console.WriteLine(temp);
    }
}
System.Console.ReadLine();