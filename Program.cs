using System;


namespace ProgrammingAssignment1_CSIS209
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // We would normally use floating data types
            // but the assignment is only concerned with integer types             
            int numOne, numTwo, sum, diff, prod, quo, rem, larger, smaller;
            
            // * TODO: Intercept all nonnumeric keys,
            // *       catch attempts to divide by zero operations,
            // *       catch overflow, etc.
            
            // Get the first input number
            Console.Write("Enter the first integer: ");
            numOne = int.Parse(Console.ReadLine());

            // Get the second input number
            Console.Write("Enter the second integer: ");
            numTwo = int.Parse(Console.ReadLine());

            // Get the larger and smaller of the two
            larger = Math.Max(numOne, numTwo);
            smaller = Math.Min(numOne, numTwo);

            // Display the user's numbers entered
            Console.WriteLine();
            Console.WriteLine("The two numbers you entered are: {0} and {1}", numOne, numTwo);

            // Add the two numbers and display the sum
            sum = (numOne + numTwo);
            Console.WriteLine("The sum of the two numbers is: {0}", sum);

            // Get the difference between the two numbers and display it
            diff = (larger - smaller);
            Console.WriteLine("The difference of the two numbers is: {0}", diff);

            // Get the product of the two numbers and display it
            prod = (numOne * numTwo);
            Console.WriteLine("The product of the two numbers is: {0}", prod);

            // Get the quotient of the two numbers and display it            
             quo = (numOne / numTwo);
             Console.WriteLine("The quotient of the two numbers is: {0}", quo);            
            
            // Get the remainder from the subtraction of the two numbers and display it
            rem = (numOne % numTwo);
            Console.WriteLine("The remainder of the two numbers is: {0}", rem);

            // Display the larger number of the two or if they are equal
            Console.WriteLine();
            if (larger != smaller) 
            {
                Console.WriteLine("The larger of the two numbers is: {0}", larger);
            }

            else
            {
                Console.WriteLine("The two numbers are equal.");
            }

            // Wait for user to press the enter key before exiting
            Console.WriteLine("Press the [enter] key to continue.");
            // Intercept all other keys except enter key
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}

        }        
    }
}
