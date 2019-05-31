using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Test
{
    public class PainM006SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Pain/pain.006.001.01_BusEx1.xml")]
        [InlineData("./Resources/Pain/pain.006.001.01_BusEx2.xml")]
        public void PainM006V00101(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM006V00101.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM006V00101.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
