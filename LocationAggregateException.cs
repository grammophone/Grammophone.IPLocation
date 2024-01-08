using System;
using System.Collections.Generic;
using System.Text;

namespace Grammophone.IPLocation
{
  /// <summary>
  /// Aggregate exception for location roviders.
  /// </summary>
  [Serializable]
  public class LocationAggregateException : AggregateException
  {
    /// <inheritdoc/>
    public LocationAggregateException(string message, IEnumerable<Exception> innerExceptions)
      : base(message, innerExceptions)
    {
    }

		/// <inheritdoc/>
		protected LocationAggregateException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context) : base(info, context)
    {
    }
  }
}
