namespace UnitTestProject2
{
    public class TaxHelper
    {
        public decimal GetTaxResult(decimal tax)
        {
            if (tax > 2420000)
            {
                return 540000 * 0.05m + (1210000 - 540000) * 0.12m + (2420000 - 1210000) * 0.2m + (tax - 2420000) * 0.3m;
            }
            if (tax > 1210000)
            {
                return 540000 * 0.05m + (1210000 - 540000) * 0.12m + (tax - 1210000) * 0.2m;
            }
            if (tax > 540000)
            {
                return 540000 * 0.05m + (tax - 540000) * 0.12m;
            }
            return tax * 0.05m;
        }
    }
}