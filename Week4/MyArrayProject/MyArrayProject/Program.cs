namespace MyArrayProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initializing the char array to store the alphabets
            char[] alphabet = new char[26];
            for(int i = 0; i < alphabet.Length; i++) // initializing the for loop 
            {
                alphabet[i] = (char)('a' + i); //storing the alphabets in the array with each loop and then converting the numeric value back to character
                if (alphabet[i] != 'z') //checking if the alphabet is not equal to 'z'
                {
                    Console.Write(alphabet[i] + ", "); //adding a coma in between the alphabets in the array
                }
                else
                {
                    Console.WriteLine(alphabet[i]);//finishing the array with the last alphabet without any comma
                }
            }

            for (int i = (alphabet.Length - 1);i >= 0; i--) //Initializing a second for loop
            {
                if (alphabet[i] != 'a') //checking if the alphabet is not equal to 'a'
                {
                    Console.Write(alphabet[i] + ", "); //adding a coma in between the alphabets in the array
                }
                else
                {
                    Console.WriteLine(alphabet[i]);//finishing the array with the alphabet without any comma
                }
            }
        }
    }
}