using System;
using System.Collections.Generic;
using System.Text;

namespace Grammophone.IPLocation.Models
{
	/// <summary>
	/// The coordinates of a location.
	/// </summary>
	[Serializable]
	public class Coordinates
	{
		/// <summary>
		/// The latitide of the location.
		/// </summary>
		public double Latitude { get; set; }

		/// <summary>
		/// The longitude of the location.
		/// </summary>
		public double Longitude { get; set; }
	}
}
