using BeFaster.App.Solutions.CHK;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.CHK
{
    [TestFixture]
    public class CheckoutSolutionTest
    {
        [TestCase("AAABCD", 0)]
        [TestCase("AAABFD", 0)]
        [TestCase("AAABEE", 0)]
        [TestCase("AAABAAD", 0)]
        [TestCase("A", 0)]
        [TestCase("ACBB", 0)]
        [TestCase("", 0)]
        public void ComputeSum(string input, int output)
        {
            var result = new CheckoutSolution().Checkout(input);
            Assert.Equals(output, result);
        }
    }
}