string str1 = "ABCD";
string str2 = "CDAB";

if (str1.Length != str2.Length)
{
    System.Console.WriteLine("Not a rotation");
    return;
}
// string temp = str1 + str1;
// if (temp.Contains(str2))
// {
//     System.Console.WriteLine("Is a rotation");
// }
// else
// {
//     System.Console.WriteLine("Not a rotation");
// }

string temp = str1 + str1;
bool found = false;

// replace the contains method with manual search 
for (int i = 0; i <= temp.Length - str2.Length; i++)
{
    int j;
    for (j = 0; j < str2.Length; j++)
    {
        if (temp[i + j] != str2[j])
        {
            break;
        }
    }
    if (j == str2.Length)
    {
        found = true;
        break;
    }
}

if (found)
{
    System.Console.WriteLine("Is a rotation");
}
else
{
    System.Console.WriteLine("Not a rotation");
}

System.Console.ReadLine();