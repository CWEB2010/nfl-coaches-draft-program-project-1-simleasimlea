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
		private static bool match;

		//public static object PlayersChosen { get; private set; }

		static void Main(string[] args)
		{

			//declarations		


			String primingValue; //priming value
								 //int selectedPlayerId;

			Console.WriteLine("\nWelcome to the draft.");
			Console.WriteLine("\nIf you wish to exit at any time, type 'X', then enter. \n\nWhat is your name?\n");

			primingValue = Convert.ToString(Console.ReadLine().ToUpper());//using primingValue for user name and also to exit out


			Console.WriteLine("\n" + primingValue + "!\n\nAre you ready to select your draft picks?\n" +
				"\nView the choices in the table below," + "\nand then follow the instructions below the table.\n\n");

			while (primingValue != "X")
			{

				//playerId
				//Two dimensional array
				//int[,] playerId =           {
				//								 { 1234 , 5678 , 9123 ,
				//								   1232 , 5558 , 9823 ,
				//								   1231 , 5668 , 9723 }
				//							};
				//salary requirement
				//string[,] playerName =      {
				//								{ "Joe" , "Jim" , "John" ,
				//								  "Gene" , "Jesse" , "Jerry" ,
				//								 "Joseph" , "Jesus" , "James"}
				//							};

				//salary requirement
				//double[,] salary =          {
				//								{ 1111111 ,  1111111 ,  1111111 ,
				//								  1111111 , 1111111 , 1111111 ,
				//								  1111111 , 1111111 ,  1111111 }
				//							};

				String[,] Roster =          {
												{ "1234", "Joe Burrow", "26400100" },
												{ "3456", "Tua Tagovailoa", "20300100"},
												{ "3488", "Tua Tag", "29300100"},
												{ "0000", "Joe Burrow", "26400100" },
												{ "1111", "Tua Tagovailoa", "20300100"},
												{ "2222", "Tua Tag", "29300100"}
										};

				//Player objects declaring and initializing all in one step

				List<Player> Players = new List<Player>();

				//Iterate through the multi-Array and populate the list

				for (int i = 0; i < Roster.GetLength(0); i++) //outer loop control rows
				{
					//Console.WriteLine("testa " + i);

					//System.Collections.IList list = Players;
					//for (int i1 = 0; i1 < 1; i1++) //inner loop controls columns, creating object instances by passing to constructor and
					//adding object to a list, and outputting the objects

					//{
					//Console.WriteLine("testb " + i);
					Player aPlayer = new Player(Convert.ToInt32(Roster[i, 0]), Roster[i, 1], Convert.ToDouble(Roster[i, 2]));
					Players.Add(aPlayer);
					Console.WriteLine("Player ID:  " + Roster[i, 0] + " Player Name: " + (Roster[i, 1])
						+ "Salary: " + Convert.ToDouble(Roster[i, 2]).ToString("c"));
					//}

				}







				//if (int.TryParse(selection, out int value))

				//{


				//selectedPlayerId = Convert.ToInt32(selection);

				Console.WriteLine("\nWho do you wish to draft? Enter the player's number + enter," +
						"\nand then your selection will be evaluated.\n");

				string selection = Console.ReadLine();
				int caseSwitch = 0;
				List<Player> PlayersChosen = new List<Player>();

				//Iterate through the multi-Array and evaluation match
				for (int i = 0; i < Roster.GetLength(0); i++) //outer loop control rows
				{

					if (selection == Roster[i, 0])
					{
						//int match = i;
						caseSwitch = 1;
						Player bPlayer = new Player(Convert.ToInt32(Roster[i, 0]), Roster[i, 1], Convert.ToDouble(Roster[i, 2]));
						PlayersChosen.Add(bPlayer);

						Console.WriteLine("You have chosen " + selection + " who matches a player available on the roster: " + Roster[i, 0]);
						Console.WriteLine(value: "Good Choice! " + bPlayer.playerId + " " + bPlayer.playerName + "has been added to your draft picks list.");
						break;
					}
					else
					//(selection != Roster[i, 0])
					{

					}
				}
					foreach (var item in PlayersChosen.OrderBy(Player => Player.PlayerId)) Console.WriteLine(item);

					//System.Collections.IList list = Players;
					//for (i1 = 0; i1 < list.Count; i1++) //inner loop controls columns
					//{

					//switch (caseSwitch)
					//{
					//	case 1:

					//		Console.WriteLine("match!");
					//		break;
					//	//Console.WriteLine("You have chosen " + selection + " who matches a player available on the roster: " + Roster[i, 0]);

					//	//Player aPlayer = new Player(Convert.ToInt32(Roster[i, 0]), Roster[i, 1], Convert.ToDouble(Roster[i, 2]));
					//	//PlayersChosen.Add(aPlayer);

					//	//Console.WriteLine(value: "Good Choice! " + aPlayer.playerId + " " + aPlayer.playerName + "has been added to your draft picks list.");
					//	//			break;
					//	//	}

					//	case 0:
					//		Console.WriteLine("Sorry, no match!");
					//		break;
					//}

					//foreach (Player drafted in PlayersChosen)
					//{

					//	Console.WriteLine("You've selected:" + drafted.playerId + " " + drafted.playerName);
					//}




					//Console.WriteLine("\nDo you wish to pick another available player? Enter the player's number + enter," +
					//	"\nand then your selection will be evaluated.\n");

					// selection = Console.ReadLine();


					//if (PlayersChosen.Count < 3) ;

					//			Console.WriteLine("You have chosen " + PlayersChosen.Count + "players.");

					//				break;

					//			case 3: if (PlayersChosen.Count == 4);

					//			Console.WriteLine("Good Choice:" + aPlayer.playerId + " " + aPlayer.playerName);
					//			Console.WriteLine("You have chosen " + PlayersChosen.Count + "players. You have one more choice.");

					//				break;
					//		}
					//		else if (PlayersChosen.Count >= 5)
					//		{

					//			Console.WriteLine("You have chosen the max of " + PlayersChosen.Count + "players.");
					//			Console.WriteLine("Would you like to lock in on these " + PlayersChosen.Count + "players?");

					//		}

					//	}
					//		else
					//		{
					//		Console.WriteLine("You did not match.");
					//	}
					//}

					//	}
					//Console.WriteLine(PlayersChosen.Count);





					//Console.WriteLine("You did not match.");





			


				////Draft pick list
				//for (int i = 0; i < 2; i++) //outer loop control rows
				//{

				//	Console.WriteLine("Player ID:  " + PlayersChosen.playerId + " Player Name: " + PlayersChosen.playerName
				//		+ "Salary: " + Convert.ToDouble(salary.ToString("c"));
				//	//}

				//}


				//for (int j = 0; j < Players.Count(); j++)

				//{
				//	//if (selectedPlayerId = Players[j, 0].playerId)
				//	{
				//	};

				//if (exists is true)



				//PlayersChosen.Add(potentialPlayer);
				//Console.WriteLine("Success! "); //+ PlayersChosen.playerId + " " + playersChosen.playerName + "has been added to your picks.");




				//else
				//{
				//	Console.WriteLine("Your choice did not match an existing available player.");
				//}



				//Console.WriteLine("Success! " + aDraftPick.playerId + " " + aDraftPick.playerName + "has been added to your picks.");
				//}
				//else
				//{
				//Console.WriteLine("You must enter a player number and only the number to select a player to draft.");
				//}



				//selectedPlayerId = Convert.ToInt32(Console.ReadLine());//getting ID

				//PlayersChosen.Add(new DraftPick { selectedPlayerId });

				// Check the list for chosen players. This calls the IEquatable.Equals method
				// of the Players class, which checks the PlayerId for equality.
				//Console.WriteLine("\nContains Chosen Players: (\"1234\"): {0}",
				//Players.Contains(new Player { PlayerId = 1234 }));

				//GetLatestPlayers();

				////create chosen players as a different list
				//PlayersChosen.Add(new DraftPick { PlayerId = 1234 });
				//PlayersChosen.Add(new DraftPick { PlayerId = 1235 });
				//PlayersChosen.Add(new DraftPick { PlayerId = 1236 });

				// Write out the Players in the list. This will call the overridden ToString method
				// in the Player class.
				//Console.WriteLine("\nAll Picks");

				//for (int i = 0; i < PlayersChosen.Count; i++)
				//{
				//	DraftPick aPlayer = PlayersChosen[i];
				//	Console.WriteLine(aPlayer);
				//}

				//Console.WriteLine("\nDo You wish to add or remove a player? Type A for add and R for remove or X to exit. ");

				//string answer = Convert.ToString(Console.ReadLine().ToUpper());

				//if (answer == "A")
				//{
				//	Console.WriteLine("\nSelect the player you wish to add to your draft picks: ");

				//	// Add player from list

				//	int a = Convert.ToInt32(Console.ReadLine());

				//	PlayersChosen.Add(new DraftPick { PlayerId = a });
				//}
				//else if (answer == "R")
				//{
				//	Console.WriteLine("\nSelect the player you wish to remove from your draft picks: ");

				//	// Remove player from chosen list

				//	int r = Convert.ToInt32(Console.ReadLine());
				//	Console.WriteLine(r);

				//	PlayersChosen.RemoveAt(r);
				//}

				//else if (answer == "X")
				//{

				//	Environment.Exit(0); //exit

				//}
				//else
				//{
				//	Console.WriteLine("\nYou must select A for add or R for remove or X to exit. ");
				//	Console.ReadLine();
				//	Console.Clear();

				//};


				//Console.WriteLine("\nYour Draft Picks are:\n");
				//foreach (DraftPick dDraftPick in PlayersChosen)
				//{
				//	Console.WriteLine(dDraftPick);
				//}



				////PlayersChosen.Add(a);
				////PlayersChosen.Add(new DraftPick { PlayerId = 1234 });

				//// Write out the Players in the list. 
				//Console.WriteLine("\nThe Player List");

				//for (int i = 0; i < Players.Count; i++)
				//{
				//	Player aPlayer = Players[i];
				//	Console.WriteLine(aPlayer);
				//}

				//Console.WriteLine("\nDo You wish to continue adjusting your draft picks?" +
				//	"\nEnter any key to continue, or X + 'enter' to exit. ");

				primingValue = Convert.ToString(Console.ReadLine().ToUpper());//using primingValue for user name and also to exit out

			}

		}
	}
}




	

	
	



