namespace Q2
{
    internal class Program
    {
        //This is a method which returns the number of words in the string provided. It is an int return type with a string input arguement.
        static int CountWords(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0; //checking if string is null.
            int count = 1; //initializing the word count of the string.
            foreach (char c in input)
            {
                if (char.IsUpper(c)) count++; //if the character is a upper case in the string, then increase the word count.
            }
            return count; //return the word count at end.
        }
        //This method encrypts the string entered using the encryption key value.
        static string Encryption(string S, int K)
        {
            string encodedText = ""; //initializing encoded string
            foreach (char c in S) //for each char in string S
            {
                if (!char.IsUpper(c)) //checking if the char is uppercase
                {
                    encodedText += c; //a symbol so don't encrypt
                }
                else //else, must be a letter/alphabet so encrypt
                {
                    int encodedChar = c + K;
                    if (char.IsLower(c))
                    {
                        if (encodedChar > 'z')
                        {
                            encodedChar -= 26; //looping back to 'a'
                        }
                    }
                    else if (char.IsUpper(c))
                    {
                        if (encodedChar > 'Z')
                        {
                            encodedChar -= 26; //looping back to 'A'
                        }
                    }
                    encodedText += (char)encodedChar; //concatenate char to string
                }
            }
            return encodedText;
        }
        public static string Decryption(string S, int K)
        {
            string decodedText = "";
            foreach (char c in S)
            {
                if (!char.IsUpper(c))
                {
                    decodedText += c; //a symbol so don't decrypt
                }
                else
                {
                    int decodedChar = c - K;
                    if (char.IsUpper(c))
                    {
                        if (decodedChar < 'A')
                        {
                            decodedChar += 26; //looping back to 'Z'
                        }
                    }
                    else
                    {
                        if (decodedChar < 'a')
                        {
                            decodedChar += 26; //looping back to 'z'
                        }
                    }
                    decodedText += (char)decodedChar; //concatenate char to string
                }
            }
            return decodedText;
        }
        static void Main(string[] args)
        {
            // Task 1
            // Get user input
            Console.WriteLine("Enter your string in Camel Case: ");
            string statement = Console.ReadLine();
            int wordCount = CountWords(statement);
            // Print number of words
            Console.WriteLine($"Number of words = {wordCount}");
            /* Task 2
            * Caesar Cipher
            */
            Console.WriteLine("Enter a message to encode: ");
            string S = Console.ReadLine();
            Console.WriteLine("Enter the encryption key value: ");
            int K = Convert.ToInt32(Console.ReadLine);
            string encrypted = Encryption(S, K);
            Console.WriteLine($"Original string: {S}, Encrypted: {encrypted}");
            string decrypted = Decryption(encrypted, K);
            Console.WriteLine($"Encrypted String: {encrypted}, Decrypted: {decrypted}");
        }
    }
}