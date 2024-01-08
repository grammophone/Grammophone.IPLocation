using System;
using System.Collections.Generic;
using System.Text;

namespace Grammophone.IPLocation.Models
{
	/// <summary>
	/// Continent of the location.
	/// </summary>
	[Serializable]
	public class Continent
	{
		/// <summary>
		/// The code of the continent, for example, "EU".
		/// </summary>
		public string Code { get; set; }

		/// <summary>
		/// The name of the continent.
		/// </summary>
		public string Name { get; set; }
	}
}
