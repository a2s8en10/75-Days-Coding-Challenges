using System.Runtime.CompilerServices;

string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };

Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

foreach (string item in words)
{
    char[] chars = item.ToCharArray();
    Array.Sort(chars);
    string str = new string(chars);
    if (!dic.ContainsKey(str))
    {
        dic[str] = new List<string>();
    }
    dic[str].Add(item);
}

foreach (var group in dic.Values)
{
    Console.WriteLine("[" + string.Join(", ", group) + "]");
}