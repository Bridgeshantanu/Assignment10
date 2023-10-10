using Exceptions;

namespace PersonAge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgeCategory()
        {
            AgeCategorizer ageCategorizer = new AgeCategorizer();
            string expected = "Seniors";

            try
            {
                int ageInput = 100;

                if (string.IsNullOrWhiteSpace(ageInput.ToString()))
                {
                    throw new InvalidAgeException("Age cannot be null or empty.");
                }

                int age = ageInput;

                string actual = ageCategorizer.CategorizeAge(age);
                Console.WriteLine($"Category: {actual}");

                Assert.AreEqual(expected, actual);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}