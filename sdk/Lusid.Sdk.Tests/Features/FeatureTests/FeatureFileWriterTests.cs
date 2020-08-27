using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Features.FeatureTests
{    
    [TestFixture]
    public class FeatureFileWriterTests
    {

        [Test]
        public void CheckIfFilesWriteCorrectly()
        {
            var sep = Path.DirectorySeparatorChar;
            var fileWriteDirectory = $"{sep}Lusid.Sdk.Tests{sep}Features{sep}FeatureTests{sep}testFeatures.txt";
            const string nameSpace = "Lusid.Sdk.Tests.Features.FeatureTests.Dummy.valid";
            var ffw = new FeatureFileWriter(fileWriteDirectory);

            var featureList = FeatureExtractor.GetAllMethodAttributesInNamespace(nameSpace);
            var featuresFromMethod = string.Join("\n", featureList);
            ffw.CheckAndRemoveExistingFile();
            ffw.CreateAndWriteFile(featuresFromMethod);
            var featuresFromFile = ffw.ReadFile();

            Assert.AreEqual(featuresFromFile, featuresFromMethod);

        }
        
        [Test]
        public void WriteActualFeaturesToSdkFolder()
        {
            const string nameSpace = "Lusid.Sdk.Tests.Tutorials";
            var ffw = new FeatureFileWriter("features.txt");

            var featureList = FeatureExtractor.GetAllMethodAttributesInNamespace(nameSpace);
            var featuresFromMethod = string.Join("\n", featureList);
            ffw.CheckAndRemoveExistingFile();
            ffw.CreateAndWriteFile(featuresFromMethod);
            var featuresFromFile = ffw.ReadFile();

            Assert.AreEqual(featuresFromFile, featuresFromMethod);
        }

    }
}