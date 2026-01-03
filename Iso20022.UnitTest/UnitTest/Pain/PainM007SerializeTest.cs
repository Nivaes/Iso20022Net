using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Pain.Test
{
    public class PainM007SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Pain/pain.007.001.01.xml")]
        public void PainM007V00101(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM007V00101.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM007V00101.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.007.001.02.xml")]
        public void PainM007V00102(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM007V00102.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM007V00102.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.007.001.03.xml")]
        public void PainM007V00103(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM007V00103.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM007V00103.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
