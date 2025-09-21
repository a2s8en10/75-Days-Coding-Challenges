string str1 = "Anurag";
string str2 = "rag";
bool found = false;

int n = str1.Length - str2.Length;

for (int i = 0; i <= n; i++)
{
    int j = 0;
    while (j < str2.Length && str1[i + j] == str2[j])
    {
        j++;
    }
    if (j == str2.Length)
    {
        found = true;
        // System.Console.WriteLine("it is found at index " + i);
    }
}
if (found == false)
{
    System.Console.WriteLine("not found");
}
else
{
    System.Console.WriteLine("found at index " + str2);
}

System.Console.ReadLine();