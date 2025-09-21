System.Console.Write("Enter The String : ");
string str = Console.ReadLine();
int n = str.Length;
int maxLength = 0;
int startIndex = 0;
int j = 0;

int[] freq = new int[256];

for (int i = 0; i < n; i++)
{
    char current = str[i];
    while (freq[current] > 0)
    {
        freq[str[j]]--;
        j++;
    }
    freq[current]++;

    int k = i - j + 1;
    if (k > maxLength)
    {
        maxLength = k;
        startIndex = j;
    }
}

string s = "";
for (int i = startIndex; i <= maxLength; i++)
{
    s += str[i];
}
System.Console.WriteLine("Maximum Length : " + maxLength);
System.Console.WriteLine("Sub-String : " + s);