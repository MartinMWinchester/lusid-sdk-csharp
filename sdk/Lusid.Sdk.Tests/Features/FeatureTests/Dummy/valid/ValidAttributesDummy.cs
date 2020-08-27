using NUnit.Framework;

namespace Lusid.Sdk.Tests.Features.FeatureTests.Dummy.valid
{    
    [TestFixture]
    public class ValidAttributesTests
    {
        
        [LusidFeature("F1")]
        [Test]
        public void DummyMethod()
        {
            Assert.Ignore();
        }
        
        [LusidFeature("F2")]
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