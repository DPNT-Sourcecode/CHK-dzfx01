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
                { 'E', 40 }
            };

            var offers = new Dictionary<char, List<int[]>> {

                { 'A', [ new int[] { 5, 200 }, new int[] { 3, 130 } ] },
                { 'B', [ new int[] { 2, 45 } ] },
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


