using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Xunit;

namespace Iso20022.UnitTest.UnitTest.Camt
{
    public class Camt053SerializeTest
    {
        [Theory]
        [InlineData("./Resources/Camt/camt.053.001.03_sample1_SR2012.xml")]
        public void Camt05300103(string fileName)
        {
            var serializder = new XmlSerializer(typeof(Iso20022.Contracts.Camt05300103.Document));
            using (var file = File.OpenRead(fileName))
            {
                var document = (Iso20022.Contracts.Camt05300103.Document?)serializder?.Deserialize(file);
                Assert.NotNull(document);
            }
        }
    }
}
