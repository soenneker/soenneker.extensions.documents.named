using Soenneker.Documents.Named.Abstract;
using Soenneker.Dtos.IdNamePair;
using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Soenneker.Extensions.Documents.Named;

/// <summary>
/// A collection of helpful NamedDocument extension methods
/// </summary>
public static class NamedDocumentsExtension
{
    /// <summary>
    /// Creates an <see cref="IdNamePair"/> from an <see cref="INamedDocument"/>'s Id and Name.
    /// </summary>
    /// <typeparam name="T">A type implementing <see cref="INamedDocument"/>.</typeparam>
    /// <param name="value">The document to convert.</param>
    /// <returns>A new <see cref="IdNamePair"/> containing the document's Id and Name.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
    [Pure]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IdNamePair ToIdNamePair<T>(this T value) where T : INamedDocument
    {
        ArgumentNullException.ThrowIfNull(value);

        // Cache to locals to avoid multiple interface dispatches / property reads.
        string id = value.Id;
        string name = value.Name;

        return new IdNamePair { Id = id, Name = name };
    }
}