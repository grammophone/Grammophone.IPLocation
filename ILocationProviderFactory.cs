using System;
using System.Collections.Generic;
using System.Text;

namespace Grammophone.IPLocation
{
	/// <summary>
	/// Interface for creating a <see cref="ILocationProvider"/> instance.
	/// </summary>
	public interface ILocationProviderFactory
	{
		/// <summary>
		/// Create an IP location provider.
		/// </summary>
		ILocationProvider CreateLocationProvider();
	}
}
