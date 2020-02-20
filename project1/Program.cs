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

			int playerCount = 0;
			double salaryTotal = 0;
			int rankBank = 0;

			//Player objects declaring and initializing all in one step
			List<Player> Players = new List<Player>();
			List<Player> PlayersChosen = new List<Player>();

			Console.WriteLine("\nWelcome to the draft.");
			Console.WriteLine("\nIf you wish to exit at any time, type 'X', then enter. \n\nWhat is your name?\n");

			primingValue = Convert.ToString(Console.ReadLine().ToUpper());//using primingValue for user name and also to exit out

			Console.WriteLine("\n" + primingValue + "!\n\nAre you ready to select your draft picks?\n" +
				"\nView the choices in the table below," + "\nand then follow the instructions below the table.\n\n");



			String[,] Roster =          {
												{ "1234", "Joe Burrow", "180100", "best" },
												{ "3456", "Tua Tagovailoa", "430100", "second best" },
												{ "9999", "Tua Tag", "800100", "third best" },
												{ "3333", "Joe Baxter", "400100", "tenth best" },
												{ "1111", "Tua Vailoa", "800100", "eleventh best"},
												{ "2222", "Tua Jones", "784300100", "twelth best" },
												{ "6666", "Jax Vailoa", "32300100", "eleventh best"},
												{ "5555", "Jill Jones", "676300100", "twelth best" },
										};


			//Iterate through the multi-Array and populate the list
			for (int i = 0; i < Roster.GetLength(0); i++) //outer loop control rows
			{
				Player aPlayer = new Player(Convert.ToInt32(Roster[i, 0]), Roster[i, 1], Convert.ToDouble(Roster[i, 2]), Roster[i, 3]);
				Players.Add(aPlayer);
			}

			while (primingValue != "X")

			{

				foreach (Player cPlayer in Players)
				{

					Console.WriteLine(cPlayer.playerId + " " + cPlayer.playerName + "is available.");

				}


				Console.WriteLine("\nWho do you wish to draft? Enter the player's number + enter," +
						"\nand then your selection will be evaluated.\n");

				string selection = Console.ReadLine();

				{
					//Iterate and evaluation match
					for (int i = 0; i < Roster.GetLength(0); i++) //outer loop control rows
					{

						if (selection == Roster[i, 0])
						{
							Player bPlayer = new Player(Convert.ToInt32(Roster[i, 0]), Roster[i, 1], Convert.ToDouble(Roster[i, 2]), Roster[i, 3]);
							PlayersChosen.Add(bPlayer);
							playerCount = playerCount + 1;
							salaryTotal = salaryTotal + bPlayer.salary;

							var itemToRemove = Players.Single(r => r.playerId == Convert.ToInt32(selection));
							Players.Remove(itemToRemove);

							if (bPlayer.rank == "best" | bPlayer.rank == "second best" | bPlayer.rank == "third best")
							{
								rankBank = rankBank + 1;
							};
	
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

					if (playerCount < 5 & salaryTotal < 95000000)

					{

						Console.WriteLine(playerCount + "\nEnter any key to pick again. Enter 'X' to quit.\n");


					}

					else if (playerCount == 5 & salaryTotal < 6500000 & rankBank > 2)

					{
						Console.WriteLine(playerCount + "\nYou have selected 5 players.\n");
						Console.WriteLine(playerCount + "\nHey, hey! Cost effective!\n");
					}

					else if (playerCount == 5 & salaryTotal < 95000000 & (salaryTotal > 650000 | rankBank < 3 ))

					{

						Console.WriteLine(playerCount + "\nYou have selected 5 players.\n");
					}

					else if (playerCount < 5 & salaryTotal > 95000000)

					{

						Console.WriteLine(playerCount + "\nYou have exceeded the $95 million cap. You will need to adjust your players.\n");
					}
					else
					{
					}

					primingValue = Convert.ToString(Console.ReadLine().ToUpper());//using primingValue for user name and also to exit out

				}

			}
		}
	}
}




	

	
	



