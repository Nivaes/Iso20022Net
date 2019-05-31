using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Test
{
    public class PainM008SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Pain/pain.008.001.01_BusEx1.xml")]
        [InlineData("./Resources/Pain/pain.008_001.01_BusEx2.xml")]
        public void PainM008V00101(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM008V00101.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM008V00101.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.008.001.02.xml")]
        public void PainM008V00102(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM008V00102.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM008V00102.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.008.001.03.xml")]
        public void PainM008V00103(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM008V00103.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM008V00103.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/Business sample 1 pain.008.xml")]
        public void PainM008V00104(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM008V00104.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM008V00104.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
