namespace fortuneCookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int choice = 0;

            for (int i = 0; i < 1000; i++)
            {
                choice = rnd.Next(1, 7);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"{choice} is 1");
                        break;
                    case 2:
                        Console.WriteLine($"{choice} is 2");
                        break;
                    case 3:
                        Console.WriteLine($"{choice} is 3");
                        break;
                    case 4:
                        Console.WriteLine($"{choice} is 4");
                        break;
                    case 5:
                        Console.WriteLine($"{choice} is 5");
                        break;
                    case 6:
                        Console.WriteLine($"{choice} is 6");
                        break;
                }
            }
            Console.WriteLine("All done");
            //pause
            Console.ReadLine();
        }
    }
}
