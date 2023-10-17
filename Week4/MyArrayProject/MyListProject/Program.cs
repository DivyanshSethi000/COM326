namespace MyListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> months = new List<string>(); //initializing a new list of string type
            //adding and populating the list with the months 
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");

            string[] monthNames = months.ToArray(); //converting the list to an array

            //removing 2 of the months from the list
            months.Remove("September");
            months.Remove("November");
            Console.WriteLine($"Length of List: {months.Count}"); //printing to the console the length of the remaining list
            Console.WriteLine($"Index Of December: {months.IndexOf("December")}"); //printing to the console the index of a month
        }
    }
}