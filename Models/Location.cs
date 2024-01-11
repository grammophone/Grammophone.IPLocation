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
		#region Private fields

		private IReadOnlyList<Subdivision> subdivisions;

		#endregion

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

		/// <summary>
		/// The collection of subdivisions of the location.
		/// </summary>
		public IReadOnlyList<Subdivision> Subdivisions
		{
			get
			{
				return subdivisions ??= new List<Subdivision>();
			}
			set
			{
				if (value == null) throw new ArgumentNullException(nameof(value));

				subdivisions = value;

				if (subdivisions.Count > 0)
				{
					this.LastSubdivision = subdivisions[subdivisions.Count - 1];
				}
				else
				{
					this.LastSubdivision = null;
				}
			}
		}

		/// <summary>
		/// The last <see cref="Subdivision"/> in <see cref="Subdivisions"/>.
		/// </summary>
		public Subdivision LastSubdivision { get; private set; }
	}
}
