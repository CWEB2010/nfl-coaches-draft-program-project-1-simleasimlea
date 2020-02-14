using System;
using System.Collections.Generic;

namespace project1
{


	class Program
	{
		static void Main(string[] args)
		{

			//declarations		
			String primingValue; //priming value

			Console.WriteLine("Welcome to the draft.");
			Console.WriteLine("Press any key to get started. Enter X to exit.");

			primingValue = Console.ReadLine();

			while (primingValue != "X")
			{

				List<Player> Players = new List<Player>();
				List<DraftPick> PlayersChosen = new List<DraftPick>();

				//add players from JSON later
				Players.Add(new Player { PlayerId = 1234 });
				Players.Add(new Player { PlayerId = 1235 });
				Players.Add(new Player { PlayerId = 1236 });
				Players.Add(new Player { PlayerId = 1237 });
				Players.Add(new Player { PlayerId = 1238 });

				// Write out the Players in the list. This will call the overridden ToString method
				// in the Player class.
				Console.WriteLine("\nAll Players");
				foreach (Player aPlayer in Players)
				{
					int i = 1;

					Console.WriteLine(i + ".  " + aPlayer);
					i++;
				}

				// Check the list for chosen players. This calls the IEquatable.Equals method
				// of the Players class, which checks the PlayerId for equality.
				//Console.WriteLine("\nContains Chosen Players: (\"1234\"): {0}",
				//Players.Contains(new Player { PlayerId = 1234 }));

				//create chosen players as a different list
				PlayersChosen.Add(new DraftPick { PlayerId = 1234 });
				PlayersChosen.Add(new DraftPick { PlayerId = 1235 });
				PlayersChosen.Add(new DraftPick { PlayerId = 1236 });

				// Write out the Players in the list. This will call the overridden ToString method
				// in the Player class.
				Console.WriteLine("\nAll Picks");

				for (int i = 0; i < PlayersChosen.Count; i++)
				{
					DraftPick aPlayer = PlayersChosen[i];
					Console.WriteLine(aPlayer);
				}

				Console.WriteLine("\nDo You wish to add or remove a player? Type A for add and R for remove or X to exit. ");

				string answer = Convert.ToString(Console.ReadLine().ToUpper());

				if (answer == "A")
				{
					Console.WriteLine("\nSelect the player you wish to add to your draft picks: ");

					// Add player from list

					int a = Convert.ToInt32(Console.ReadLine());

					PlayersChosen.Add(new DraftPick { PlayerId = a });
				}
				else if (answer == "R")
				{
					Console.WriteLine("\nSelect the player you wish to remove from your draft picks: ");

					// Remove player from chosen list

					int r = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine(r);

					PlayersChosen.RemoveAt(r);
				}

				else if (answer == "X")
				{

					Environment.Exit(0); //exit

				}
				else
				{
					Console.WriteLine("\nYou must select A for add or R for remove or X to exit. ");
					Console.ReadLine();
					Console.Clear();

				};


				Console.WriteLine("\nYour Draft Picks are:\n");
				foreach (DraftPick dDraftPick in PlayersChosen)
				{
					Console.WriteLine(dDraftPick);
				}



				//PlayersChosen.Add(a);
				//PlayersChosen.Add(new DraftPick { PlayerId = 1234 });

				// Write out the Players in the list. 
				Console.WriteLine("\nThe Player List");

				for (int i = 0; i < Players.Count; i++)
				{
					Player aPlayer = Players[i];
					Console.WriteLine(aPlayer);
				}

				Console.WriteLine("\nDo You wish to continue adjusting your draft picks? Enter any key to continue, or X to exit. ");
				Console.ReadLine();
			}
		}
	}
}


