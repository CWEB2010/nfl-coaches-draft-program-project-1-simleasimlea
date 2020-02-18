using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace project1
{
	public class Player //: IEquatable<Player>
	{
		internal readonly object PlayerId;

		//Declarations

		public int playerId { get; set; }
		public string playerName { get; set; }
		public double salary { get; set; }

		public Player(int playerId, string playerName, double salary)
		{
			this.playerId = playerId;
			this.playerName = playerName;
			this.salary = salary;

		}
		public Player(int playerId)
		{
			this.playerId = playerId;
		}

		//public int EvaluateDraftPick()
		//{
		//	//this.playerId = playerId;
		//	//this.playerName = playerName;
		//	//this.salary = salary;

		//	for (var x = 0; x < 3; x++) //inner loop controls columns, creating object instances by passing to constructor and
		//								//adding object to a list, and outputting the objects
		//	{
		//		if aDraftPick.potentialPlayer > 1{
		//			;
		//		}
		//	}
		//	return playerId;
		//}

		//public override string ToString()
		//{
		//	return String.Format("This player: " + playerName + ", number " + playerId + " will run you $" + salary);
		//}

		//public List<Player> LatestPlayers = new List<Player>();
		//private static string Path1 => Path;

		//private const string Path = @"C:\Users\simlea\Desktop\MyAssignments\nfl-coaches-draft-program-project-1-simleasimlea\project1\PlayerList.txt";


		//public string PlayerName { get; set; }

		//public int PlayerId { get; set; }

		//public override string ToString()
		//{
		//	return "ID: " + PlayerId;
		//}
		//public override bool Equals(object obj)
		//{
		//	if (obj == null)
		//	{
		//		return false;
		//	}

		//	if (!(obj is Player objAsPlayer))
		//	{
		//		return false;
		//	}
		//	else
		//	{
		//		return Equals(objAsPlayer);
		//	}
		//}
		//public override int GetHashCode()
		//{
		//	return PlayerId;
		//}
		//public bool Equals(Player other)
		//{
		//	if (other == null)
		//	{
		//		return false;
		//	}

		//	return (Equals(other.PlayerId));
		//}
		//should also override == and != operators.

		//public List<string> GetLatestPlayers()
		//{
		//private List<Player> LatestPlayers = new List<Player>();
		//readonly string[] LatestPlayers = System.IO.File.ReadAllLines(Path1);
		//LatestPlayers = System.IO.File.ReadAllLines(Path1);
		//return LatestPlayers;

		//}
		//Console.WriteLine("\nTesting");

		//public Player(IEnumerable<T> LatestPlayers)
		//{

		//	ICollection<T> c = LatestPlayers as ICollection<T>;
		//	if (c != null)
		//	{
		//		int count = c.Count;
		//		if (count == 0)
		//		{
		//			_items = _emptyArray;
		//		}
		//		else
		//		{
		//			_items = new T[count];
		//			c.CopyTo(_items, 0);
		//			_size = count;
		//		}
		//	}

		//}
		//LatestPlayers.Add(new Player { PlayerId = 1235});
		//Players.Add(new Player { PlayerId = 1235 });
		//Players.Add(new Player { PlayerId = 1236 });
		//Players.Add(new Player { PlayerId = 1237 });
		//Players.Add(new Player { PlayerId = 1238 });

	}
}





