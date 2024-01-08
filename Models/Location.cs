using System;
using System.Collections.Generic;
using System.Text;

namespace Grammophone.IPLocation.Models
{
	/// <summary>
	/// Location estimated for a specified IP address.
	/// </summary>
	[Serializable]
	public class Location
	{
		/// <summary>
		/// Optional city of the location, if found, else null.
		/// </summary>
		public City City { get; set; }

		/// <summary>
		/// Optional country of the location, if found, else null.
		/// </summary>
		public Country Country { get; set; }

		/// <summary>
		/// Optional continent of the location, if found, else null.
		/// </summary>
		public Continent Continent { get; set; }

		/// <summary>
		/// Optional time zone of the location, if found, else null.
		/// </summary>
		public string TimeZone { get; set; }

		/// <summary>
		/// Optional coordinates of the location, if available, else null.
		/// </summary>
		public Coordinates Coordinates { get; set; }

		/// <summary>
		/// The name of the implementation of <see cref="ILocationProvider"/> which provides this location result.
		/// </summary>
		public string ProviderName { get; set; }

		/// <summary>
		/// The query time, in UTC.
		/// </summary>
		public DateTime Timestamp { get; set; }

		/// <summary>
		/// The raw rsponse from the provider.
		/// </summary>
		public string Response { get; set; }
	}
}
