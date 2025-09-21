// string str = "Anurag";
// string substr = "rag";


// if (str.Contains(substr))
// {
//     Console.WriteLine("The substring is present in the string.");
// }
// else
// {
//     Console.WriteLine("The substring is not present in the string.");
// }

// System.Console.ReadLine();

string str = "Anurag";
string substr = "rag";
bool found = false;

for (int i = 0; i <= str.Length - substr.Length; i++)
{
    int j;
    for (j = 0; j < substr.Length; j++)
    {
        if (str[i + j] != substr[j])
        {
            break; // match fail ho gaya
        }
    }

    if (j == substr.Length)
    {
        found = true;
        break; // substring mil gaya
    }
}

if (found)
{
    Console.WriteLine("The substring is present in the string.");
}
else
{
    Console.WriteLine("The substring is not present in the string.");
}