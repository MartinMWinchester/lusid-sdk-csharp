using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Features
{

    public static class FeatureExtractor
    {
        public static IEnumerable<string> GetAllMethodAttributesInNamespace(string nameSpace)
        {
            var featureList = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.Namespace != null && t.Namespace.ToLower().StartsWith(nameSpace.ToLower()))
                .SelectMany(t => t.GetMethods()
                    .Where(m => m.GetCustomAttributes(typeof(LusidFeature), true)?.Length > 0)
                    .Select(m => m.GetCustomAttributes(typeof(LusidFeature)).Cast<LusidFeature>().First().Code)
                );
            
            var duplicatesEnumerable = featureList
                .GroupBy(g => g)
                .Where(x => x.Count() > 1)
                .Select(k => k.Key);
            var duplicateValues = string.Join(", ", duplicatesEnumerable.ToList());
            if(duplicateValues.Length > 0){
                throw new DuplicateFeatureException($"LusidFeature annotations with duplicate values {duplicateValues} have been found. " +
                                                    "Please make sure no LusidFeature annotations duplicates are present.");
            }
    
            return featureList;
        }

    }
}