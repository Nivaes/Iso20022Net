# Iso20022Net
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
