using System;
using System.Collections;
using System.Collections.Generic;

namespace project1
{

	class Program
    {
        static void Main(string[] args)
        {
			//declarations
			List<string> AvailablePlayerList = new List<string>();
			List<string> SelectedPlayerList = new List<string>();
			int num = 0;
			int playerChoiceNumber = 0;
					
			Console.WriteLine(" ");

			Console.Write("Available Players: \n");

			// instantiating available players
			Player playerAvailable = new Player();

			AvailablePlayerList = playerAvailable.GetAvailablePlayer();

			// Displaying available players
			foreach (string k in AvailablePlayerList) 
			{
				num++;
				playerChoiceNumber = num;
				Console.WriteLine(num + ". " + k);
				//need to add multi-dimensional array like survey
			}

			Console.WriteLine();

			Console.Write("Chosen Players: \n");

			// instantiating chosen players
			Player playerSelected = new Player();

			SelectedPlayerList = playerSelected.ChooseAvailablePlayer("Choice");
			
			// Displaying chosen players
			foreach (string m in SelectedPlayerList)
			{
				Console.WriteLine(m);
			}

			Console.WriteLine("Who do you wish to draft from the Available Players? Enter the number of the player.");

			int PlayerChoice = Convert.ToInt16(Console.ReadLine());

			Console.WriteLine(PlayerChoice + num);

			Console.ReadLine();
		}
		}
	}



public class Player
{

	public Player()
	{
	}

	public Player(string ChosenPlayer)
	{
	}

	public List<string> GetAvailablePlayer()
	{
		// Adding player to List, maybe pull from JSON file later, and exclude any that have been selected already.

		List<string> AvailablePlayerList = new List<string>
		{
			"Billy",
			"Bobby",
			"Johnny",
			"Dougy",
			"Mikey"
		};

		return AvailablePlayerList;
	}


	// chosen player list...maybe store those selected

	public List<string> ChooseAvailablePlayer(string chosenPlayer)
	{
		List<string> ChosenPlayerList = new List<string>
		{
			"Julie",
			"Amy",
			"Sally",
			"Ally",
			"Kally"
		};

		return ChosenPlayerList;
	}

}




