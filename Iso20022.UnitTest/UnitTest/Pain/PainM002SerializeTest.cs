using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iso20022.Pain.Test
{
    public class PainM002SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Pain/pain.002.001.01.xml")]
        public void PainM002V00101(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM002V00101.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM002V00101.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.002.001.02_BusEx1.xml")]
        [InlineData("./Resources/Pain/pain.002.001.02_BusEx2.xml")]
        [InlineData("./Resources/Pain/pain.002.001.02_BusEx3.xml")]
        public void PainM002V00102(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM002V00102.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM002V00102.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.002.001.03_1.xml")]
        [InlineData("./Resources/Pain/pain.002.001.03_2.xml")]
        public void PainM002V00103(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM002V00103.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM002V00103.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/pain.002.001.04_sample1_PaymentsMaintenance2012.xml")]
        [InlineData("./Resources/Pain/pain.002.001.04_sample2_PaymentsMaintenance2012.xml")]
        public void PainM002V00104(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM002V00104.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM002V00104.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }

        [Theory]
        [InlineData("./Resources/Pain/Business sample 1 pain.002.xml")]
        [InlineData("./Resources/Pain/Business sample 2 pain.002.xml")]
        public void PainM002V00105(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.PainM002V00105.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.PainM002V00105.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
