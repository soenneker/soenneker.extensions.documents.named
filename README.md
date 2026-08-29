[![](https://img.shields.io/nuget/v/soenneker.extensions.documents.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.documents.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.documents.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.documents.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.documents.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.documents.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.documents.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.documents.named/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Documents.Named
Extension methods for projecting and transforming documents that implement `INamedDocument`, especially when callers need compact identity and display data.

## Installation

```bash
dotnet add package Soenneker.Extensions.Documents.Named
```

## Usage

```csharp
using Soenneker.Extensions.Documents.Named;

INamedDocument document = GetDocument();
IdNamePair pair = document.ToIdNamePair();

// pair.Id == document.Id
// pair.Name == document.Name
```

`ToIdNamePair()` always creates a new `IdNamePair`; later changes to the document are not reflected in the pair. Passing null throws `ArgumentNullException`.
