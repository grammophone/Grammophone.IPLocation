using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grammophone.IPLocation.Models;

namespace Grammophone.IPLocation
{
	/// <summary>
	/// Interface contract for querying locations.
	/// </summary>
	public interface ILocationProvider : IDisposable
	{
		/// <summary>
		/// The name of the provider.
		/// </summary>
		string ProviderName { get; }

		/// <summary>
		/// Get the estimated location for the given IP address.
		/// </summary>
		/// <param name="ipAddress">The IP address.</param>
		Task<Location> GetLocationAsync(System.Net.IPAddress ipAddress);
	}
}
