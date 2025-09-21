namespace Check_if_a_string_is_a_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aaabaaa";
            int n = str.Length;
            char[] chars = str.ToCharArray();
            bool isPalindrome = true;

            int start = 0;
            int end = n - 1;

            while (start < end)
            {
                if (chars[start] != chars[end])
                {
                    isPalindrome = false;
                    break;
                }
                start++;
                end--;
            }
            if (isPalindrome)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");

            }
            Console.ReadLine();
        }
    }
}
