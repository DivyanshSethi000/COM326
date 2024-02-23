namespace Q2
{
    internal class Program
    {
        static int CountWords(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;
            int count = 1;
            foreach (char c in input)
            {
                if (char.IsUpper(c)) count++;
            }
            return count;
        }
        static string Encryption(string input, int key)
        {
            char[] result = input.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i]))
                {
                    char shift = char.IsUpper(result[i]) ? 'A' : 'a';
                    result[i] = (char)(shift + (result[i] - shift + key) % 26);
                }
            }
            return new string(result);
        }
        public static string Decryption(string input, int key)
        {
            char[] result = input.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i]))
                {
                    char shift = char.IsUpper(result[i]) ? 'A' : 'a';
                    result[i] = (char)(shift + (result[i] - shift - key + 26) % 26);
                }
            }

            return new string(result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string in Camel Case: ");
            string statement = Console.ReadLine();
            int wordCount = CountWords(statement);
            Console.WriteLine(wordCount);
            string encrypted = Encryption(statement, wordCount);
            Console.WriteLine(encrypted);
            string decrypted = Decryption(encrypted, wordCount);
            Console.WriteLine(decrypted);
        }
    }
}