using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GSW.BPO.Common;

namespace GSW.BPO.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ExportXmlFile.Processamento("Reinf");
        }
    }
}
