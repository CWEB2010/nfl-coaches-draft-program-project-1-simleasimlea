using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
	public class DraftPick : IEquatable<Player>
	{
		//public string PlayerName { get; set; }

		public int PlayerId { get; set; }

		public override string ToString()
		{
			return "ID: " + PlayerId;
		}
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}

			if (!(obj is Player objAsPlayer))
			{
				return false;
			}
			else
			{
				return Equals(objAsPlayer);
			}
		}
		public override int GetHashCode()
		{
			return PlayerId;
		}
		public bool Equals(Player other)
		{
			if (other == null)
			{
				return false;
			}

			return (Equals(other.PlayerId));
		}
		//should also override == and != operators.
	}

}
