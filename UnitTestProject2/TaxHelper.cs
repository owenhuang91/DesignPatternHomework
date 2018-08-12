using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject2
{
    public class TaxHelper
    {
        private Dictionary<int, decimal> _percentLookup = new Dictionary<int, decimal>
        {
            {0,0.05m},
            {540000,0.12m},
            {1210000,0.2m},
            {2420000,0.3m},
            {4530000,0.4m},
            {10310000,0.5m},
        };

        public decimal GetTaxResult(decimal income)
        {
            var maxLevel = _percentLookup.LastOrDefault(m => m.Key < income);
            return maxLevel.Key == _percentLookup.FirstOrDefault().Key
                ? maxLevel.Value * income
                : maxLevel.Value * (income - maxLevel.Key) + GetTaxResult(maxLevel.Key);

            if (income > 2420000)
            {
                return 540000 * 0.05m + (1210000 - 540000) * 0.12m + (2420000 - 1210000) * 0.2m + (income - 2420000) * 0.3m;
            }
            if (income > 1210000)
            {
                return 540000 * 0.05m + (1210000 - 540000) * 0.12m + (income - 1210000) * 0.2m;
            }
            if (income > 540000)
            {
                return 540000 * 0.05m + (income - 540000) * 0.12m;
            }
            return income * 0.05m;
        }
    }
}