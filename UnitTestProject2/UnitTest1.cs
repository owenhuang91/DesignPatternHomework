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

        [TestMethod]
        public void Income_540001_Tax_27000p12()
        {
            var taxHelper = new TaxHelper();
            var taxResult = taxHelper.GetTaxResult(540001);
            Assert.AreEqual(27000.12m, taxResult);
        }

        [TestMethod]
        public void Income_1210000_Tax_107400()
        {
            var taxHelper = new TaxHelper();
            var taxResult = taxHelper.GetTaxResult(1210000);
            Assert.AreEqual(107400, taxResult);
        }
    }
}