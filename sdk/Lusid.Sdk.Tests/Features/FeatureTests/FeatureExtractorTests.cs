using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Features.FeatureTests
{    
    [TestFixture]
    public class FeatureExtractorTests
    {
        
        [Test]
        public void CheckIfValidFeaturesAreReturnedCorrectly()
        {
            var expectedAttributes = new List<string> {"F1", "F2", "F3", "F4", "F5", "F6"};
            const string nameSpace = "Lusid.Sdk.Tests.Features.FeatureTests.Dummy.valid";
            
            var classAttributes = FeatureExtractor.GetAllMethodAttributesInNamespace(nameSpace);

            Assert.That(classAttributes.Count(), Is.EqualTo(6));
            Assert.That(classAttributes, Is.EquivalentTo(expectedAttributes));
        }
        
        [Test]
        public void CheckIfThrowsErrorWithDuplicateFeatureCodes()
        {
            const string nameSpace = "Lusid.Sdk.Tests.Features.FeatureTests.Dummy.duplicates";
            const string duplicateValue = "F1";
            
            Assert.That(
                () => FeatureExtractor.GetAllMethodAttributesInNamespace(nameSpace),
                Throws.InstanceOf<DuplicateFeatureException>().With.Message
                    .EqualTo($"LusidFeature annotations with duplicate values {duplicateValue} have been found. " +
                             "Please make sure no LusidFeature annotations duplicates are present."));
        }
        
        
        [Test]
        public void CheckIfReturnsEmptyListWithNoAnnotations()
        {
            const string nameSpace = "Lusid.Sdk.Tests.Features.FeatureTests.Dummy.notannotated";

            var returnedFeatures = FeatureExtractor.GetAllMethodAttributesInNamespace(nameSpace);

            Assert.That(returnedFeatures, Is.Empty);
        }
        
        

    }
}