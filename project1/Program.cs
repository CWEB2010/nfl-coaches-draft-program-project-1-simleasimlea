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
			List<Player> Players = new List<Player>();

			Players.Add(new Player { PlayerName = " player1", PlayerId = 1234 });
			Players.Add(new Player { PlayerName = " player2", PlayerId = 1235 });
			Players.Add(new Player { PlayerName = " player3", PlayerId = 1236 });
			Players.Add(new Player { PlayerName = " player4", PlayerId = 1237 });
			Players.Add(new Player { PlayerName = " player5", PlayerId = 1238 });

			// Write out the Players in the list. This will call the overridden ToString method
			// in the Player class.
			Console.WriteLine();
			foreach (Player aPlayer in Players)
			{
				Console.WriteLine("Available PLayers: " + aPlayer);
			}

			// Check the list for Player #1734. This calls the IEquatable.Equals method
			// of the Player class, which checks the PlayerId for equality.
			Console.WriteLine("\nContains(\"1734\"): {0}",
			Players.Contains(new Player { PlayerId = 1734, PlayerName = "" }));

			// Insert a new item at position 2.
			Console.WriteLine("\nInsert(2, \"1834\")");
			Players.Insert(2, new Player { PlayerName = "brake lever", PlayerId = 1834 });

			//Console.WriteLine();
			foreach (Player aPlayer in Players)
			{
				Console.WriteLine(aPlayer);
			}

			Console.WriteLine("\nPlayers[3]: {0}", Players[3]);

			Console.WriteLine("\nRemove(\"1534\")");

			// This will remove Player 1534 even though the PlayerName is different,
			// because the Equals method only checks PlayerId for equality.
			Players.Remove(new Player { PlayerId = 1534, PlayerName = "cogs" });

			Console.WriteLine();
			foreach (Player aPlayer in Players)
			{
				Console.WriteLine(aPlayer);
			}
			Console.WriteLine("\nRemoveAt(3)");
			// This will remove the Player at index 3.
			Players.RemoveAt(3);

			Console.WriteLine();
			foreach (Player aPlayer in Players)
			{
				Console.WriteLine(aPlayer);
			}

			//List<string> AvailablePlayerList = new List<string>();
			//List<string> SelectedPlayerList = new List<string>();
			//int num = 0;
			//int playerChoiceNumber = 0;

			//Console.WriteLine(" ");

			//Console.Write("Available Players: \n");

			//// instantiating available Players
			//Player playerAvailable = new Player();

			//AvailablePlayerList = playerAvailable.GetAvailablePlayer();

			//// Displaying available Players
			//foreach (string k in AvailablePlayerList) 
			//{
			//	num++;
			//	playerChoiceNumber = num;
			//	Console.WriteLine(num + ". " + k);
			//	//need to add multi-dimensional array like survey
			//}

			//Console.WriteLine();

			//Console.Write("Chosen Players: \n");

			//// instantiating chosen Players
			//Player Playerselected = new Player();

			//SelectedPlayerList = Playerselected.ChooseAvailablePlayer("Choice");

			//// Displaying chosen Players
			//foreach (string m in SelectedPlayerList)
			//{
			//	Console.WriteLine(m);
			//}

			//Console.WriteLine("Who do you wish to draft from the Available Players? Enter the number of the player.");

			//int PlayerChoice = Convert.ToInt16(Console.ReadLine());

			//Console.WriteLine(PlayerChoice + num);

			Console.ReadLine();
		}
		}
	}



//public class Player
//{

//	public Player()
//	{
//	}

//	public Player(string ChosenPlayer)
//	{
//	}

//	public List<string> GetAvailablePlayer()
//	{
//		// Adding player to List, maybe pull from JSON file later, and exclude any that have been selected already.

//		List<string> AvailablePlayerList = new List<string>
//		{
//			"Billy",
//			"Bobby",
//			"Johnny",
//			"Dougy",
//			"Mikey"
//		};

//		return AvailablePlayerList;
//	}


//	// chosen player list...maybe store those selected

//	public List<string> ChooseAvailablePlayer(string chosenPlayer)
//	{
//		List<string> ChosenPlayerList = new List<string>
//		{
//			"Julie",
//			"Amy",
//			"Sally",
//			"Ally",
//			"Kally"
//		};

//		return ChosenPlayerList;
//	}

//}




