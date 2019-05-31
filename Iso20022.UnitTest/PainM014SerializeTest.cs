using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Test
{
    public class PainM014SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Pain/pain.014.001.01.xml")]
        public void PainM014V00101(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM014V00101.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM014V00101.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
