using NUnit.Framework;

namespace Lusid.Sdk.Tests.Features.FeatureTests.Dummy.valid.validnested
{    
    [TestFixture]
    public class ValidAttributes3Tests
    {
        
        [LusidFeature("F5")]
        [Test]
        public void DummyMethod()
        {
            Assert.Ignore();
        }
        
        [LusidFeature("F6")]
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