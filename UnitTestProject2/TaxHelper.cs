using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject2
{
    public class TaxHelper
    {
        private Dictionary<int, decimal> _percentLookup = new Dictionary<int, decimal>
        {
            {540000,0.05m},
            {1210000,0.12m},
            {2420000,0.2m},
            {Int32.MaxValue,0.3m},
        };

        public decimal GetTaxResult(decimal income)
        {
            var maxLevel = _percentLookup.FirstOrDefault(m => m.Key >= income);
            return maxLevel.Key == _percentLookup.FirstOrDefault().Key
                ? maxLevel.Value * income
                : maxLevel.Value * maxLevel.Key - income + GetTaxResult(maxLevel.Key);

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