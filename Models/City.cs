using System;
using System.Collections.Generic;
using System.Text;

namespace Grammophone.IPLocation.Models
{
	/// <summary>
	/// City of the location.
	/// </summary>
	[Serializable]
	public class City
	{
		/// <summary>
		/// The name of the city.
		/// </summary>
		public string Name { get; set; }
	}
}
