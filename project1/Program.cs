using System;
using System.Collections.Generic;
using System.Linq;


using System.IO;

using System.Text;
using System.Threading.Tasks;


namespace project1
{


	class Program
	{
		static void Main(string[] args)
		{

		//declarations		
			String primingValue; //priming value
								 //int selectedPlayerId;

			//Player objects declaring and initializing all in one step
			List<Player> Players = new List<Player>();
			List<Player> PlayersChosen = new List<Player>();

			Console.WriteLine("\nWelcome to the draft.");
			Console.WriteLine("\nIf you wish to exit at any time, type 'X', then enter. \n\nWhat is your name?\n");

			primingValue = Convert.ToString(Console.ReadLine().ToUpper());//using primingValue for user name and also to exit out

			Console.WriteLine("\n" + primingValue + "!\n\nAre you ready to select your draft picks?\n" +
				"\nView the choices in the table below," + "\nand then follow the instructions below the table.\n\n");

			while (primingValue != "X")
			{

				String[,] Roster =          {
												{ "1234", "Joe Burrow", "26400100" },
												{ "3456", "Tua Tagovailoa", "20300100"},
												{ "3488", "Tua Tag", "29300100"},
												{ "0000", "Joe Burrow", "26400100" },
												{ "1111", "Tua Tagovailoa", "20300100"},
												{ "2222", "Tua Tag", "29300100"}
										};



				//Iterate through the multi-Array and populate the list
				for (int i = 0; i < Roster.GetLength(0); i++) //outer loop control rows
				{
					Player aPlayer = new Player(Convert.ToInt32(Roster[i, 0]), Roster[i, 1], Convert.ToDouble(Roster[i, 2]));
					Players.Add(aPlayer);
					Console.WriteLine("Player ID:  " + Roster[i, 0] + " Player Name: " + (Roster[i, 1])
						+ "Salary: " + Convert.ToDouble(Roster[i, 2]).ToString("c"));
				}

				Console.WriteLine("\nWho do you wish to draft? Enter the player's number + enter," +
						"\nand then your selection will be evaluated.\n");

				string selection = Console.ReadLine();
				

				//Iterate through the multi-Array and evaluation match
				for (int i = 0; i < Roster.GetLength(0); i++) //outer loop control rows
				{

					if (selection == Roster[i, 0])
					{
						Player bPlayer = new Player(Convert.ToInt32(Roster[i, 0]), Roster[i, 1], Convert.ToDouble(Roster[i, 2]));
						PlayersChosen.Add(bPlayer);

						//Console.WriteLine("You have chosen " + selection + " who matches a player available on the roster: " + Roster[i, 0]);
						//Console.WriteLine(value: "Good Choice! " + bPlayer.playerId + " " + bPlayer.playerName + "has been added to your draft picks list.");
						
					}
					else
					{
						//do nothing
					}
				}


				foreach (Player dDraftPick in PlayersChosen)
				{

					Console.WriteLine(dDraftPick.playerId + " " + dDraftPick.playerName + "has been added to your draft picks list.");

				}

				Console.WriteLine("\nHit any key to pick again. Enter 'X' to quit.\n");
				//	Console.WriteLine("\nSelect the player you wish to remove from your draft picks: ");

				//	// Remove player from chosen list

				//	int r = Convert.ToInt32(Console.ReadLine());
				//	Console.WriteLine(r);

				//	PlayersChosen.RemoveAt(r);
				//}



				primingValue = Convert.ToString(Console.ReadLine().ToUpper());//using primingValue for user name and also to exit out

			}

		}
	}
}




	

	
	



