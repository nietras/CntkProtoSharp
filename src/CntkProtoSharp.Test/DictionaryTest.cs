using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CNTK.Proto.Test
{
    [TestClass]
    public class DictionaryTest
    {
        readonly Func<Stream> m_createStream = () => AssemblyResourceLoader.GetStream("ResNet20_CIFAR10_CNTK.cntk.model");

        [TestMethod]
        public void ParseFrom()
        {
            // Act
            var model = Dictionary.Parser.ParseFrom(m_createStream);

            // Assert
            var Data = model.Data;
            Assert.AreEqual(6, Data.Count);
        }
    }
}
