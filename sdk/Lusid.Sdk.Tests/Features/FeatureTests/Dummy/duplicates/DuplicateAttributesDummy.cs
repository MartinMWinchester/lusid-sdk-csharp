using NUnit.Framework;

namespace Lusid.Sdk.Tests.Features.FeatureTests.Dummy.duplicates
{    
    [TestFixture]
    public class DuplicateAttributesTests
    {
        
        [LusidFeature("F1")]
        [Test]
        public void DummyMethod()
        {
            Assert.Ignore();
        }
        
        [LusidFeature("F1")]
        [Test]
        public void DummyMethod2()
        {
            Assert.Ignore();
        }
        
        [LusidFeature("F2")]
        [Test]
        public void DummyMethod3()
        {
            Assert.Ignore();
        }
        
    }
}