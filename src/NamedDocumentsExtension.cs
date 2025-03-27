using Soenneker.Documents.Named.Abstract;
using Soenneker.Dtos.IdNamePair;

namespace Soenneker.Extensions.Documents.Named;

/// <summary>
/// A collection of helpful NamedDocument extension methods
/// </summary>
public static class NamedDocumentsExtension
{
    public static IdNamePair ToIdNamePair<T>(this T value) where T : INamedDocument
    {
        return new IdNamePair { Id = value.Id, Name = value.Name };
    }
}
