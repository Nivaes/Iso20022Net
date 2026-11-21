# Iso20022


.NET library providing C# contracts for reading and writing XML messages based on the [ISO 20022](https://www.iso20022.org/) standard. The contracts are used with `System.Xml.Serialization.XmlSerializer`.

The library provides data models; it does not validate business rules, SEPA rules, or document conformance against an XSD. To validate a message, separately apply the XSD and business rules for the relevant schema and version.

## Supported message families

The project contains generated contracts for these message families:

| Family | General purpose |
| --- | --- |
| `Acmt` | Account management |
| `Admi` | Administrative messages |
| `Camt` | Cash management and account reporting |
| `Pain` | Payment initiation |

Multiple message versions are available in each family. Class and namespace names include the schema version identifier; use the contract that exactly matches the XSD for your files. For example, `PainM001V00101.Document` represents `pain.001.001.01`.

## Compatibility

The library targets `.NET Standard 2.0`, `.NET Standard 2.1`, `.NET 9`, `.NET 10`, and `.NET 11`.

## Installation

Install the NuGet package:

```shell
dotnet add package Iso20022
```

## Read and write XML

This example reads a `pain.001.001.01` message and writes a copy. Change the contract type to match your message schema.

```csharp
using System.IO;
using System.Xml.Serialization;
using Iso20022.Contracts.PainM001V00101;

var serializer = new XmlSerializer(typeof(Document));
Document document;

using (var input = File.OpenRead("payment.xml"))
{
    document = (Document?)serializer.Deserialize(input)
        ?? throw new InvalidOperationException("The XML message could not be deserialized.");
}

using (var output = File.Create("payment-copy.xml"))
{
    serializer.Serialize(output, document);
}
```

`XmlSerializer` may throw exceptions if the XML does not match the expected contract. Deserialization does not replace schema validation or business-rule checks.

