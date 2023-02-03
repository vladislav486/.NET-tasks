namespace NotationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Insert a number for converting: ");
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("The number should be above zero. Try again please:");
                        continue;
                    }
                        

                    Console.Write("Insert the notation for convertion: ");
                    int notation = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Your number in chosen notation looks like this: {Convert.ToString(number, notation)}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That's not a number. Please try again: ");
                    continue;
                }
                catch (Exception e) 
                {
                    Console.WriteLine("You've inserted the wrong notation. It could be 2, 8 or 16. Please try again: ");
                    continue;
                }

            }
        }
    }
}
