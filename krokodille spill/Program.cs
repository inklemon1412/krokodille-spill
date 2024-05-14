namespace krokodille_spill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Krokodillespillet");
            {
                Random n = new Random();
                int points = 0;
                bool game = true;

                Console.WriteLine("Guess the right value of a number by typing < > or = ");

                krokospill();
                void krokospill()

                {
                    while (game)
                    {
                        int number1 = n.Next(1,11);
                        int number2 = n.Next(1,11);

                        Console.WriteLine($"points: {points}");
                        Console.WriteLine($"{number1} _ {number2}");

                        string input = Console.ReadLine();

                        if(input == "=")
                        {
                            if (number1 == number2) points++;
                            else points--;
                        }
                        else if(input == "<")
                        {
                            if (number1 < number2) points++;
                            else points--;
                        }
                        else if (input == ">")
                        {
                            if (number1 > number2) points++;
                            else points--;
                        }
                        else
                        {
                            game = false;
                            Console.WriteLine($"Thank you for playing. Your final score is {points}");
                        }

                        Console.WriteLine();
                        krokospill();
                    }
                }


            }
        }
    }
}
