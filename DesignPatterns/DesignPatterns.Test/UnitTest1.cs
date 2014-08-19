using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.FactoryPattern;

namespace DesignPatterns.Test
{
    [TestClass]
    public class InvoiceFactoryTest
    {
        [TestMethod]
        public void GetInvoiceTest()
        {
            IInvoice ifactory= InvoiceFactory.GetInvoice("1");
            ifactory.Print();
            Assert.AreEqual("1", "1");
        }
    }
}
