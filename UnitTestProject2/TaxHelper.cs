namespace UnitTestProject2
{
    public class TaxHelper
    {
        public decimal GetTaxResult(decimal tax)
        {
            if (tax > 540000)
            {
                return 540000 * 0.05m + (tax - 540000) * 0.12m;
            }
            return tax * 0.05m;
        }
    }
}