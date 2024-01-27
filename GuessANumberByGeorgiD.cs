
using System.ComponentModel.Design;

class GuessANumberByGeorgiD
{
    static void Main(string[] args)
    {
        Random randomNum = new Random();
        int computerNum = randomNum.Next(1, 101);

        while (true)
        {
            Console.Write("Guess a number (1-100):");

            string playerInput = Console.ReadLine();

            bool isValid = int.TryParse(playerInput, out int playerNum);

            if (isValid)
            {
                if (playerNum == computerNum)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }

                else if (playerNum > computerNum)
                {
                    Console.WriteLine("Too Hight");
                }
                else
                {
                    Console.WriteLine("Too Low");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}

