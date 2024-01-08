using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grammophone.IPLocation
{
	/// <summary>
	/// Factory for an <see cref="AggregateLocationProvider"/>.
	/// </summary>
	public class AggregateLocationProviderFactory : ILocationProviderFactory
	{
		#region Construction

		/// <summary>
		/// Create.
		/// </summary>
		/// <param name="locationProviderFactories">The factories used to construct an <see cref="AggregateLocationProvider"/>.</param>
		public AggregateLocationProviderFactory(IEnumerable<ILocationProviderFactory> locationProviderFactories)
		{
			if (locationProviderFactories == null) throw new ArgumentNullException(nameof(locationProviderFactories));
			if (!locationProviderFactories.Any()) throw new ArgumentException("The collection of provider factories must not be empty.", nameof(locationProviderFactories));

			this.LocationProviderFactories = locationProviderFactories;
		}

		#endregion

		#region Public properties

		/// <summary>
		/// The factories used to construct an <see cref="AggregateLocationProvider"/>.
		/// </summary>
		public IEnumerable<ILocationProviderFactory> LocationProviderFactories { get; }

		#endregion

		#region Public methods

		/// <inheritdoc/>
		public ILocationProvider CreateLocationProvider()
			=> new AggregateLocationProvider(this.LocationProviderFactories.Select(f => f.CreateLocationProvider()));

		#endregion
	}
}
