using System;
using System.Collections.Generic;
using System.Text;

namespace Grammophone.IPLocation.Models
{
	/// <summary>
	/// A subdivision of a <see cref="Location"/>.
	/// </summary>
	[Serializable]
	public class Subdivision
	{
		/// <summary>
		/// The name of the subdivision.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The ISO 3166-2 code of the subdivision, if it exists, else null.
		/// </summary>
		public string IsoCide { get; set; }
	}
}
