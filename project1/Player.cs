using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace project1
{
	public class Player 
	{


		//Declarations

		public int playerId { get; set; }
		public string playerName { get; set; }
		public double salary { get; set; }
		public string rank { get; set; }

		public Player(int playerId, string playerName, double salary, string rank)
		{
			this.playerId = playerId;
			this.playerName = playerName;
			this.salary = salary;
			this.rank = rank;

		}
		public Player(int playerId)
		{
			this.playerId = playerId;
		}
	}
}





