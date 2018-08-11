using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Income_100000_Tax_5000()
        {
            var taxHelper = new TaxHelper();
            var taxResult = taxHelper.GetTaxResult(100000);
            Assert.AreEqual(5000, taxResult);
        }

        [TestMethod]
        public void Income_540000_Tax_27000()
        {
            var taxHelper = new TaxHelper();
            var taxResult = taxHelper.GetTaxResult(540000);
            Assert.AreEqual(27000, taxResult);
        }
    }
}