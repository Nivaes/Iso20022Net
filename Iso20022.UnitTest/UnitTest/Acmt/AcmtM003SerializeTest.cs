using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Acmt.Test
{
    public class AcmtM003SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Acmt/acmt.003.001.02.xml")]
        public void AcmtM003V00102(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.AcmtM003V00102.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.AcmtM003V00102.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Acmt/acmt.003.001.05_Ex1.xml")]
        [InlineData("./Resources/Acmt/acmt.003.001.05_Ex2.xml")]
        public void AcmtM003V00105(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.AcmtM003V00105.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.AcmtM003V00105.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
