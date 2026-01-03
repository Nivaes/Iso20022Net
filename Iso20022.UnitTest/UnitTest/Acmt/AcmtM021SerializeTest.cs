using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Acmt.Test
{
    public class AcmtM021SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Acmt/acmt.021.001.01.xml")]
        public void AcmtM007V00102(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.AcmtM021V00101.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.AcmtM021V00101.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
