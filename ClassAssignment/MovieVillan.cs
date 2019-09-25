using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
	class MovieVillan: Person
	{
		public string signatureMove;
		public int scareIndex;

		public MovieVillan()
		{
			firstName = "Jason";
			lastName = "Vorhees";
			signatureMove = "Walking really slow";
			scareIndex = 8;
		}
	}
}
