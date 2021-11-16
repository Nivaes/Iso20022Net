# Iso20022Net

Implements .Net classes for the handling of files that comply with the ISO20022 standard, intended for banking transactions.

https://www.iso20022.org

Iso20022 Serialization 

### Contract file generation

xsd.exe /c /l:CS pain.001.001.01.xsd /eld /n:Iso20022.Contracts.PainM001V00101

### SEPA file serialization

    var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM001V00101.Document));
    using (var file = File.OpenRead(fileName))
    {
        var document = (Iso20022.Contracts.PainM001V00101.Document)serializder.Deserialize(file);
        Assert.NotNull(document);
    }

## Packages

| NuGet Package | Latest Versions |
| --- | --- |
| [Nivaes.Guid](https://www.nuget.org/packages/Iso20022) | [![latest stable version](https://img.shields.io/nuget/v/Iso20022.svg)](https://www.nuget.org/packages/Iso20022) |

## Integration

![CI](https://github.com/Nivaes/Iso20022Net/workflows/CI/badge.svg)

![Build Release](https://github.com/Nivaes/Iso20022Net/workflows/Build%20Release/badge.svg)

![Publish Release](https://github.com/Nivaes/Iso20022Net/workflows/Publish%20Release/badge.svg)
