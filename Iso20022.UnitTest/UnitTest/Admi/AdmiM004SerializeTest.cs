using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Admi.Test
{
    public class AdmiM004SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Admi/admi.004.001.01.xml")]
        public void AdmiM004V00102(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.AdmiM004V00101.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.AdmiM004V00101.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
