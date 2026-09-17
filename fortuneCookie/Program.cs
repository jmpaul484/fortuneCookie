//Jonathan Paul
//RCET2265
// Fall 2026
//https://github.com/jmpaul484/fortuneCookie.git
namespace fortuneCookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int choice = 0;

            for (int i = 0; i < 1; i++)
            {
                choice = rnd.Next(1, 7);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"The love of your life is right in front of your eyes.");
                        break;
                    case 2:
                        Console.WriteLine($"You will find great success in the near future.");
                        break;
                    case 3:
                        Console.WriteLine($"Your creativity will lead you to unexpected opportunities.");
                        break;
                    case 4:
                        Console.WriteLine($"A pleasant surprise is waiting for you.");
                        break;
                    case 5:
                        Console.WriteLine($"Your kindness will be rewarded in unexpected ways.");
                        break;
                    case 6:
                        Console.WriteLine($"You have a hidden talent that will soon be discovered.");
                        break;
                }
            }
            //pause
            Console.ReadLine();
        }
    }
}
