using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Pain.Test
{
    public class PainM001SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Pain/pain.001.001.01.c1.xml")]
        [InlineData("./Resources/Pain/pain.001.001.01.c2.xml")]
        public void PainM001V00101(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM001V00101.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM001V00101.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.001.001.02.xml")]
        public void PainM001V00102(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM001V00102.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM001V00102.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.001.001.03.xml")]
        public void PainM001V00103(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM001V00103.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM001V00103.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.001.001.04.xml")]
        public void PainM001V00104(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM001V00104.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM001V00104.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/Business sample 1 pain.001.xml")]
        public void PainM001V00105(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM001V00105.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM001V00105.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.001.002.01.xml")]
        public void PainM001V00201(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM001V00201.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM001V00201.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.001.003.01.xml")]
        public void PainM001V00301(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM001V00301.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM001V00301.Document)serializder.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
