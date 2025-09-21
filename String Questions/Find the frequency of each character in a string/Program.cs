namespace Find_the_frequency_of_each_character_in_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the String : ");
            string str = Console.ReadLine();
            Dictionary<char, int> freq = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (freq.ContainsKey(ch))
                {
                    freq[ch]++;
                }
                else
                {
                    freq[ch] = 1;
                }
            }
            foreach (var item in freq)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.ReadLine();
        }
    }
}
