

public class GuessANumber
{
	using System;
	using System.Numeric;
	public static void Main(string[] args)
	{
		Random random = new Random();
		int compurterNumber = randomNumber.Next(1, 101);

		while (true)
		{
			Console.Write("Guess a number (1-100): ");
			string playerInput = Console.ReadLine();
		bool isValid = int.TryParse(playerInput, out int playerNumber);
		if (isValid)
		{
			if (playerNumber == compurterNumber)
			{
				Console.WriteLine("You guessed it!");
				break;
			}
			else if (playerNumber>compurterNumber)
			{
				Console.WriteLine("Too High");
			}
			else if (playerNumber<compurterNumber)
			{
				Console.WriteLine("Too Low");
			}
			else
			{
				Console.WriteLine("Invalid input. ");
			}
		}
		}
	}
}
