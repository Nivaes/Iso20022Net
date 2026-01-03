# Iso20022Net

Implements .Net classes for the handling of files that comply with the ISO20022 standard, intended for banking transactions.

https://www.iso20022.org

Iso20022 Serialization 

### SEPA file serialization

```C#
    var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM001V00101.Document));
    using (var file = File.OpenRead(fileName))
    {
        var document = (Iso20022.Contracts.PainM001V00101.Document?)serializder?.Deserialize(file);
        Assert.NotNull(document);
    }
```
