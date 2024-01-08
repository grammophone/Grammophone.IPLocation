using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Grammophone.IPLocation.Models;

namespace Grammophone.IPLocation
{
	/// <summary>
	/// A location provider that evaluates queries for a location going through a list of location providers until success.
	/// </summary>
	public class AggregateLocationProvider : ILocationProvider
	{
		#region Construction

		/// <summary>
		/// Create.
		/// </summary>
		/// <param name="locationProviders"></param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public AggregateLocationProvider(IEnumerable<ILocationProvider> locationProviders)
		{
			if (locationProviders == null) throw new ArgumentNullException(nameof(locationProviders));
			if (!locationProviders.Any()) throw new ArgumentException(nameof(locationProviders), "The locationProvider collection must not be empty.");

			this.LocationProviders = locationProviders;
		}

		#endregion

		#region Public properties

		/// <summary>
		/// The location providers to be consulted for the location result.
		/// </summary>
		public IEnumerable<ILocationProvider> LocationProviders { get; }

		/// <inheritdoc/>
		public string ProviderName => nameof(AggregateLocationProvider);

		#endregion

		#region Public methods

		/// <inheritdoc/>
		public void Dispose()
		{
			foreach (var locationProvider in this.LocationProviders)
			{
				locationProvider.Dispose();
			}
		}

		/// <inheritdoc/>
		public async Task<Location> GetLocationAsync(IPAddress ipAddress)
		{
			var exceptionsList = new List<Exception>(this.LocationProviders.Count());

			foreach (var locationProvider in this.LocationProviders)
			{
				try
				{
					var location = await locationProvider.GetLocationAsync(ipAddress);

					return location;
				}
				catch (Exception exception)
				{
					exceptionsList.Add(exception);

					System.Diagnostics.Trace.TraceWarning(exception.ToString());
				}
			}

			throw new LocationAggregateException("No provider was able to provide a location for the given IP address.", exceptionsList);
		}

		#endregion
	}
}
