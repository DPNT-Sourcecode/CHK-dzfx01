using System.Diagnostics.CodeAnalysis;
using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public class CheckoutSolution
    {
        public int Checkout(string? skus)
        {
            var info = new Dictionary<char, int>
            {
                { 'A', 50 },
                { 'B', 30 },
                { 'C', 20 },
                { 'D', 15 },
                { 'E', 40 },
                { 'F', 10 },
                { 'G', 20 },
                { 'H', 10 },
                { 'I', 35 },
                { 'J', 60 },
                { 'K', 80 },
                { 'L', 90 },
                { 'M', 15 },
                { 'N', 40 },
                { 'O', 10 },
                { 'P', 50 },
                { 'Q', 30 },
                { 'R', 50 },
                { 'S', 30 },
                { 'T', 20 },
                { 'U', 40 },
                { 'V', 50 },
                { 'W', 20 },
                { 'X', 90 },
                { 'Y', 10 },
                { 'Z', 50 }
            };

            info.TryGetValue('F', out var fValue);
            info.TryGetValue('U', out var uValue);
            var offers = new Dictionary<char, List<int[]>> {

                { 'A', [ new int[] { 5, 200 }, new int[] { 3, 130 } ] },
                { 'B', [ new int[] { 2, 45 } ] },
                { 'F', [ new int[] { 3, fValue * 2 } ] },
                { 'H', [ new int[] { 10, 80 }, new int[] { 5, 45 } ] },
                { 'K', [ new int[] { 2, 150 } ] },
                { 'P', [ new int[] { 5, 200 } ] },
                { 'Q', [ new int[] { 3, 80 } ] },
                { 'U', [ new int[] { 4, uValue * 3 } ] },
                { 'V', [ new int[] { 3, 130 }, new int[] { 2, 90 } ] }
            };
            var combinedOffers = new Dictionary<(char, int), char, int)>
            {
                { ('E', 2), ('B', 1) }
            };
            

            if (skus != null)
            {
                var counts = new Dictionary<char, int>();
                foreach (var key in skus.ToCharArray())
                {
                    if (!info.TryGetValue(key, out _)) return -1;
                    var item = counts.GetValueOrDefault(key);
                    if (item == 0)
                    {
                        counts.Add(key, 1);
                    }
                    else
                    {
                        counts[key]++;
                    }
                }
                if (counts.TryGetValue('E', out var eValue))
                {
                    var result = eValue / 2;

                    if (counts.TryGetValue('B', out var bValue))
                    {
                        counts['B'] = bValue - result;
                    }
                }
                if (counts.TryGetValue('N', out var nValue))
                {
                    var result = nValue / 3;

                    if (counts.TryGetValue('M', out var mValue))
                    {
                        counts['M'] = mValue - result;
                    }
                }
                if (counts.TryGetValue('R', out var rValue))
                {
                    var result = rValue / 3;

                    if (counts.TryGetValue('Q', out var qValue))
                    {
                        counts['Q'] = qValue - result;
                    }
                }
                var total = 0;
                foreach (var entry in counts)
                {
                    var item = entry.Key;
                    var count = entry.Value;
                    var price = info.GetValueOrDefault(item);

                    if (offers.TryGetValue(item, out var discounts))
                    {
                        foreach (var offer in discounts)
                        {
                            total += count / offer[0] * offer[1];
                            count %= offer[0];
                        }
                    }

                    total += count * price;
                }
                return total;
            }
            else
            {
                return -1;
            }
        }
    }
}



