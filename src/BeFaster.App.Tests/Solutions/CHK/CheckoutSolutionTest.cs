using BeFaster.App.Solutions.CHK;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.CHK
{
    [TestFixture]
    public class CheckoutSolutionTest
    {
        [TestCase("AAABC", 180)]
        [TestCase("AAABFD", -1)]
        [TestCase("AAABEE", 210)]
        [TestCase("AAABAAD", 245)]
        [TestCase("A", 50)]
        [TestCase("ACBB", 130)]
        [TestCase("", 0)]
        public void ComputeSum(string input, int output)
        {
            var result = new CheckoutSolution().Checkout(input);
            Assert.Equals(output, result);
        }
    }
}
