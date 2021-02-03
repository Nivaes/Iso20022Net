# Iso20022Net

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

### Actions

![CI](https://github.com/Nivaes/Iso20022Net/workflows/CI/badge.svg)

![Build Release](https://github.com/Nivaes/Iso20022Net/workflows/Build%20Release/badge.svg)

![Publish Release](https://github.com/Nivaes/Iso20022Net/workflows/Publish%20Release/badge.svg)
