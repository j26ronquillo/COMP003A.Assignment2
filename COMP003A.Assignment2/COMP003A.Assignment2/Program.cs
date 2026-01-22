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
            string value1 = Console.ReadLine();
            Console.Write("Enter number 2: ");
            string value2 = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Name Formats\n------------");
            Console.Write("Using concatenation: ");
            Console.Write(name1 + ", " + name2);

            
        }
    }
}
