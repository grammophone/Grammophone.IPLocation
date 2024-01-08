using System;
using System.Collections.Generic;
using System.Text;

namespace Grammophone.IPLocation
{
	/// <summary>
	/// Exception for errors in the system of location providers.
	/// </summary>
  [Serializable]
  public class LocationException : Exception
  {
		/// <inheritdoc/>
		public LocationException(string message) : base(message) { }

		/// <inheritdoc/>
		public LocationException(string message, Exception inner) : base(message, inner) { }

		/// <inheritdoc/>
		protected LocationException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
  }
}
