using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RPSLS
{
    public class MainProgram
    {
		static void Main(string[] args)
		{
			// display the input rules
			string startMessage = "Choose your weapon by typing in a valid number (1 for Rock);\npress ENTER to see the result;\ntype in 'exit' to quit the game.\n";
			Console.WriteLine(startMessage);

			// accept input data and proceed the game
			string Run()
			{
				string userInput = "";
				string systemOutput = "";
				string inputValidationResult = "";
				void exit (string exitOrder)
				{
					if (exitOrder == "exit program")
					{
						Environment.Exit(0);
					}
				}

				// check the input validation
				userInput = Console.ReadLine();
				inputValidationResult = InputValidation(userInput);

				// quit the program if exit is typed
				exit(inputValidationResult);

				// give the output of the game
				return systemOutput = GameRun(inputValidationResult, userInput);
			}

			// ready for one or more input requests
			while (true)
			{
				// proceed the first request
				Console.WriteLine(Run());

				// ready for the next request
				string endMessage = "\nContinue game by typing in another valid number (1 for Rock); press ENTER to see the result; type in 'exit' to quit the game.\n";
				Console.WriteLine(endMessage);
			}
		}

		public static string InputValidation(string userInput)
		{
			string inputValidationResult = "exit program";
			if (userInput == "exit")
			{
				return inputValidationResult;
			}

			else
			{
				string pattern = @"^[1-5]$";
				inputValidationResult = (Regex.IsMatch(userInput, pattern)) ? "Valid input" : "Invalid input!";
			}
			return inputValidationResult;
		}

		public static string GameRun(string inputValidationResult, string userInput)
		{
			string systemOutput = "";
			if (inputValidationResult == "Invalid input!")
			{
				return systemOutput = "Invalid input!";
			}

			else
			{
				return systemOutput = userInput;
			}
		}
	}
}
