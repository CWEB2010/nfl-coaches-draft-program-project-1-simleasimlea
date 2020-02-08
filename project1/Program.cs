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


	
			Console.WriteLine("Available Players:\n");
			
			// Displaying the elements of List 
			foreach (string k in AvailablePlayerList)
			{
				Console.WriteLine(k);
			}

			Console.WriteLine(" ");

			Console.Write("Chosen Players: \n");

			Player player1 = new Player();

			AvailablePlayerList = player1.SelectAvailablePlayer();
			AvailablePlayerList.ForEach(Console.WriteLine);

			Console.ReadLine();


		}
	}
}


public class Player
{


	public Player()
	{
	}

	public List<string> SelectAvailablePlayer()
	{
		// Adding elements to List, maybe pull from JSON file later, and remove any that have been selected already.

		List<string> AvailablePlayerList = new List<string>();

		AvailablePlayerList.Add("Billy");
		AvailablePlayerList.Add("Bobby");
		AvailablePlayerList.Add("Johnny");
		AvailablePlayerList.Add("Dougy");
		AvailablePlayerList.Add("Mikey");

		return AvailablePlayerList;
	}
}



