namespace My2DArrayProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] alphabet = new int[26, 2]; //initializing a new 2D Array 

            for (int i = 0; i < alphabet.GetLength(0); i++) //1st for loop for rows in 2d array
            {
                for (int j = 0; j < alphabet.GetLength(1); j++) //2nd for loop for columns in 2d array
                {
                    //filling out the array with alphabets 
                    alphabet[i, 0] = (char)('A' + i); //first column has uppercase alphabets
                    alphabet[i, 1] = (char)('a' + i); //second column has lowercase alphabets
                }
            }
            for (int i = 0;i < alphabet.GetLength(0);i++)
            {
                Console.WriteLine($"{(char)(alphabet[i, 0])}   {(char)(alphabet[i, 1])}"); //printing the 2d array out to the console
            }
        }
    }
}