string[] arrString =
{ "Anurag",
 "An",
 "Anu" };

if (arrString.Length == 0)
{
    Console.WriteLine("");
    return;
}

string prefix = arrString[0];

for (int i = 1; i < arrString.Length; i++)
{
    string currentPrefix = "";
    for (int j = 0; j < arrString[i].Length; j++)
    {
        if (j >= prefix.Length)
            break;
        if (arrString[i][j] == prefix[j])
        {
            currentPrefix += arrString[i][j];
        }
        else
        {
            break;
        }
    }
    prefix = currentPrefix;
}

System.Console.WriteLine("Longest Common Prefix is : " + prefix);
System.Console.ReadLine();
