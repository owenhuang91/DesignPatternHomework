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

        [TestMethod]
        public void Income_1218000_Tax_109000()
        {
            var taxHelper = new TaxHelper();
            var taxResult = taxHelper.GetTaxResult(1218000);
            Assert.AreEqual(109000, taxResult);
        }

        [TestMethod]
        public void Income_2420000_Tax_349400()
        {
            var taxHelper = new TaxHelper();
            var taxResult = taxHelper.GetTaxResult(2420000);
            Assert.AreEqual(349400, taxResult);
        }

        [TestMethod]
        public void Income_2500000_Tax_373400()
        {
            var taxHelper = new TaxHelper();
            var taxResult = taxHelper.GetTaxResult(2500000);
            Assert.AreEqual(373400, taxResult);
        }

        [TestMethod]
        public void Income_4530000_Tax_982400()
        {
            var taxHelper = new TaxHelper();
            var taxResult = taxHelper.GetTaxResult(4530000);
            Assert.AreEqual(982400, taxResult);
        }

        [TestMethod]
        public void Income_5530000_Tax_1382400()
        {
            var taxHelper = new TaxHelper();
            var taxResult = taxHelper.GetTaxResult(5530000);
            Assert.AreEqual(1382400, taxResult);
        }
    }
}