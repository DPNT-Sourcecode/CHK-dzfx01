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

                { 'A', [ new int[] { 3, 120 }, new int[] { 5, 200 } ] },
                { 'B', [ new int[] { 2, 45 } ] },
            };

            if (skus != null)
            {
                var count = new Dictionary<char, int>();
                foreach (var key in skus.ToCharArray())
                {
                    var item = count.GetValueOrDefault(key);
                    if (item == 0)
                    {
                        count.Add(key, 1);
                    }
                    else
                    {
                        count[key]++;
                    }
                }
                }
            else
            {
                return -1;
            }
        }
    }
}





