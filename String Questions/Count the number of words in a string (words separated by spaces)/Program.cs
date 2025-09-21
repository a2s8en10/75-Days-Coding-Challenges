// See https://aka.ms/new-console-template for more information
System.Console.Write("Enter a string:");
string str = Console.ReadLine();
int n = str.Length;
int count = 0;
bool word = false;
for (int i = 0; i < n; i++)
{
    if (str[i] != ' ' && !word)
    {
        count++;
        word = true;
    }
    else if (str[i] == ' ')
    {
        word = false;
    }
}
System.Console.WriteLine("Total Words: " + count);
System.Console.ReadLine();