namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgeCategorizer ageCategorizer = new AgeCategorizer();

            try
            {
                Console.Write("Enter the person's age: ");
                string ageInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ageInput))
                {
                    throw new InvalidAgeException("Age cannot be null or empty.");
                }

                if (int.TryParse(ageInput, out int age))
                {
                    string category = ageCategorizer.CategorizeAge(age);
                    Console.WriteLine($"Category: {category}");
                }
                else
                {
                    throw new InvalidAgeException("Invalid age input. Age must be a positive integer.");
                }
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}