using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Acmt.Test
{
    public class AcmtM001SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Acmt/acmt.001.001.02.xml")]
        public void AcmtM001V00102(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.AcmtM001V00102.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.AcmtM001V00102.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Acmt/acmt.001.001.05 Ex 1.xml")]
        public void AcmtM001V00105(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.AcmtM001V00105.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.AcmtM001V00105.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
