namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first name: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter second name: ");
            string name2 = Console.ReadLine();
            Console.Write("Enter number 1: ");
            string number1 = Console.ReadLine();
            Console.Write("Enter number 2: ");
            string number2 = Console.ReadLine();

            double a = double.Parse(number1);
            double b = double.Parse(number2);

            Console.WriteLine("\nName Formats\n------------");
            Console.Write("Using concatenation: ");
            Console.WriteLine(name2 + ", " + name1);
            Console.WriteLine($"Using interpolation: {name2}, {name1}\n");
            Console.WriteLine("Results\n-------");
            Console.WriteLine($"Sum: {a + b}");
            Console.WriteLine($"Average: {(a + b) / 2.0}");
            Console.WriteLine($"Difference: {a - b}");
            Console.WriteLine($"Product: {a * b}");
            Console.WriteLine($"Quotient: {a / b}");

            Console.WriteLine("\nComparisons\n-----------");
            bool aGreaterThanb = a > b;
            bool aEqualb = a == b;
            bool aNotEqualb = a != b;
            Console.WriteLine($"{a} > {b} " + aGreaterThanb);
			Console.WriteLine($"{a} == {b} " + aEqualb);
			Console.WriteLine($"{a} != {b} " + aNotEqualb);
		}
    }
}
