using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Pain.Test
{
    public class PainM013SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Pain/pain.013.001.01.xml")]
        public void PainM013V00101(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM013V00101.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM013V00101.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
