namespace Remove_all_vowels_from_a_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string s = Console.ReadLine();
            string vowels = "aeiouAEIOU";
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (!vowels.Contains(s[i]))
                {
                    result += s[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
