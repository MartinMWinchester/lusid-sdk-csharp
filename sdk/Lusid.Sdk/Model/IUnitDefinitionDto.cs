/* 
 * LUSID API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.10.1389
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// IUnitDefinitionDto
    /// </summary>
    [DataContract]
    public partial class IUnitDefinitionDto :  IEquatable<IUnitDefinitionDto>
    {
        /// <summary>
        /// Defines Schema
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SchemaEnum
        {
            /// <summary>
            /// Enum NoUnits for value: NoUnits
            /// </summary>
            [EnumMember(Value = "NoUnits")]
            NoUnits = 1,

            /// <summary>
            /// Enum Basic for value: Basic
            /// </summary>
            [EnumMember(Value = "Basic")]
            Basic = 2,

            /// <summary>
            /// Enum Iso4217Currency for value: Iso4217Currency
            /// </summary>
            [EnumMember(Value = "Iso4217Currency")]
            Iso4217Currency = 3

        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public SchemaEnum? Schema { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IUnitDefinitionDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public IUnitDefinitionDto()
        {
        }
        

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; private set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IUnitDefinitionDto {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IUnitDefinitionDto);
        }

        /// <summary>
        /// Returns true if IUnitDefinitionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of IUnitDefinitionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IUnitDefinitionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }

}
