using System;

class Program
{
    static void Main(string[] args)
    {

        //int magicNumber = 5;
        //int guess = -1;
        //while(guess != magicNumber){
        //    Console.WriteLine("What is your guess? ");
        //    guess = int.Parse(Console.ReadLine());

        //}

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}