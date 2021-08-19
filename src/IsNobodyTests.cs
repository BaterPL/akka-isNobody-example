using Akka.Actor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Akka.IsNobody.NRE
{
    [TestClass]
    public class IsNobodyTests
    {
        [TestMethod]
        public void IsNobody_ShouldReturnTrue_WhenPathIsNull()
        {
            var sut = Substitute.For<IActorRef>();

            Assert.IsTrue(sut.IsNobody());
        }
    }
}
