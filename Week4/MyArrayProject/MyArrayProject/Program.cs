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
                    Console.Write(alphabet[i] + ", "); //adding a comma in between the alphabets in the array
                }
                else
                {
                    Console.WriteLine(alphabet[i]);//finishing the array with the alphabet without any comma
                }
            }
            for(int i = 0;i < alphabet.Length;i++) //Initializing a third for loop
            {
                alphabet[i] = char.ToUpper(alphabet[i]); //converting the alphabets to uppercase
                if (alphabet[i] != 'Z') //checking if the alphabet is not equal to 'Z'
                {
                    Console.Write(alphabet[i] + ", "); //adding a comma in between the alphabets in the array
                }
                else
                {
                    Console.Write(alphabet[i]); //finishing the array with the alphabet without any comma
                }
            }

            int[] fibonacci = { 13, 1, 2, 3, 5, 8, 1, 34, 21, 55 }; //initializing the array with a set of values
            int max = 0; //initializing a max value to 0
            foreach (int i in fibonacci) //starting a for each loop
            {
                if (i > max) //checking if index is greater than max value
                {
                    max = i; //replacing max value with index 
                }
            }
            Console.WriteLine($"Max value is: {max}"); //printing out the max value
            Array.Sort(fibonacci); //sorting the array in ascending order
            foreach (int i in fibonacci) //starting a for each loop
            {
                Console.Write(i + " "); //printing the values with space in between
            }
            int numToFind = 34; //number to find in the array
            int index = -1; //setting the index to -1 if the number is not found
            foreach (int i in fibonacci) //starting a for each loop
            {
                if (fibonacci[i] == numToFind) //checking if the values in the array match the number to find
                {
                    index = i; //setting the index to the index value of the number
                    break;
                }
            }
            Console.WriteLine($"\nIndex of number: {index}"); //printing out the index of the number in the array
        }
    }
}