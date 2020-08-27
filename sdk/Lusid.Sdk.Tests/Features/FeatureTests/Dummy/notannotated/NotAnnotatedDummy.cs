using NUnit.Framework;

namespace Lusid.Sdk.Tests.Features.FeatureTests.Dummy.notannotated
{    
    [TestFixture]
    public class NotAnnotatedTests
    {
        
        [Test]
        public void DummyMethod()
        {
            Assert.Ignore();
        }
        
        [Test]
        public void DummyMethod2()
        {
            Assert.Ignore();
        }
        
        [Test]
        public void DummyMethod3()
        {
            Assert.Ignore();
        }
        
    }
}