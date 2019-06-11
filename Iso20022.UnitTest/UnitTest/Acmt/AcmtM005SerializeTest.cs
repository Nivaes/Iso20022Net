using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Acmt.Test
{
    public class AcmtM005SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Acmt/acmt.005.001.02.xml")]
        public void AcmtM005V00102(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.AcmtM005V00102.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.AcmtM005V00102.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Acmt/acmt.005.001.03.xml")]
        public void AcmtM005V00103(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.AcmtM005V00103.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.AcmtM005V00103.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
