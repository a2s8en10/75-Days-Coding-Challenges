using System.Text;

string str = "000111";
int n = str.Length;
StringBuilder sb = new StringBuilder(str);
for (int i = 0; i < n - 1; i++)
{
    if (sb[i] == sb[i + 1])
    {
        sb[i + 1] = (sb[i + 1] == '0') ? '1' : '0';
    }
}

System.Console.WriteLine(sb.ToString());