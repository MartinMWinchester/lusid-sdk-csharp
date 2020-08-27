using NUnit.Framework;

namespace Lusid.Sdk.Tests.Features.FeatureTests.Dummy.valid
{    
    [TestFixture]
    public class ValidAttributes2Tests
    {
        
        [LusidFeature("F3")]
        [Test]
        public void DummyMethod()
        {
            Assert.Ignore();
        }
        
        [LusidFeature("F4")]
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