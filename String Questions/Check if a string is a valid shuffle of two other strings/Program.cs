string str1 = "abc";
string str2 = "AB1C";
string result = str1 + str2;

int str1Len = str1.Length;
int str2Len = str2.Length;
int resultLen = result.Length;

if (str1Len + str2Len != resultLen)
{
    System.Console.WriteLine("Not Valid");
    return;
};
int k = 0, i = 0, j = 0;
while (k < resultLen)
{
    if (i < str1Len && str1[i] == result[k])
    {
        i++;
    }
    else if (j < str2Len && str2[j] == result[k])
    {
        j++;
    }
    else
    {
        // isValid = false;
        break;
    }
    k++;
}
if (i == str1Len && j == str2Len)
{
    System.Console.WriteLine("Valid");
}
else
{
    System.Console.WriteLine("Not Valid");
}

System.Console.ReadLine();