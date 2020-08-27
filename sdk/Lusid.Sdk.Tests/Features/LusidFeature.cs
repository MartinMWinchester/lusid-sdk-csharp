using System;

namespace Lusid.Sdk.Tests.Features
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class LusidFeature : Attribute
    {
        public LusidFeature(string code)
        {
            if(code == "") {
                throw new EmptyFeatureValueException("One of the LusidFeature annotations has not been assigned a value. " +
                                                     "Please assign it a value in the form \"[LusidFeature(\"<code-value>\")]");
            }
            Code = code;
        }
        
        public string Code { get; }
    }
}