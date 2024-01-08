using System;
using System.Collections.Generic;
using System.Text;

namespace Grammophone.IPLocation.Models
{
	/// <summary>
	/// Country of the location.
	/// </summary>
	[Serializable]
	public class Country
	{
		/// <summary>
		/// The ISO code of the country.
		/// </summary>
		public string IsoCode { get; set; }

		/// <summary>
		/// The name of the country.
		/// </summary>
		public string Name { get; set; }
	}
}
