using BeFaster.App.Solutions.CHK;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.CHK
{
    [TestFixture]
    public class CheckoutSolutionTest
    {
        [TestCase("AAABC", 180)]
        [TestCase("AAABFD", -1)]
        [TestCase("AABEE", 180)]
        [TestCase("AAABAAD", 245)]
        [TestCase("A", 50)]
        [TestCase("ACBB", 115)]
        [TestCase("", 0)]
        public void ComputeCheckout(string input, int output)
        {
            var result = new CheckoutSolution().Checkout(input);
            Assert.That(result, Is.EqualTo(output));
        }
    }
}


