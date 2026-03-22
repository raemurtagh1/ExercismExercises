using ExercismCalculator;

namespace ExercismMainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new instance of class Calculator
            var runCalculator = new Calculator();
            // Add in the parameters
            var sum_v1 = runCalculator.Add(1, 2);
            // Invoking the method
            Console.WriteLine(sum_v1);
        }
    }
}