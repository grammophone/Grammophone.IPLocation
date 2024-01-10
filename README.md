# Grammophone.IPLocation
This library abstracts IP location services and provides a caching layer for querying locations by IP addresses.

A session for querying locations by IP addresses is defined in the `ILocationProvider` interface, which derives from the `IDisposable` interface.
This interface is not intended to cache results, as this library already provides for uniform caching
via the related [Grammophone.IPLocation.Caching](https://github.com/grammophone/Grammophone.IPLocation.Caching) library
for all IP location providers conforming to the interfaces described here.

The library also contains  `AggregateLocationProvider` as an implementation of `ILocationProvider` for aggreegating other `ILocationProviders`, following the 'Composite' design pattern.
The intent of `AggregateLocationProvider` is to use a priority list of `ILocationProvider` implementations for quering locations by IP addresses,
falling back to the next `ILocationProvider` implementation in the list if the previous one fails.

In order to support caching, an implementation of `ILocationProvider` should come with a corresponding `ILocationProviderFactory`. This interface has a single method `CreateLocationProvider`,
whose purpose is to create the corresponding `ILocationprovider`. The factory will be called by the cache to create a provider whenever there is a cache miss.

Consequently, the library contains a corresponding `AggregateLocationProviderFactory` implementation of `ILocationProviderFactory` to create `AggreegateLocationProvider` instances. 

This library has no project dependencies.
