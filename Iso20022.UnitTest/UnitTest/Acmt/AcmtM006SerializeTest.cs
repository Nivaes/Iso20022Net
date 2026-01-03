using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Acmt.Test
{
    public class AcmtM006SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Acmt/acmt.006.001.02.xml")]
        public void AcmtM006V00102(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.AcmtM006V00102.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.AcmtM006V00102.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
