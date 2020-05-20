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
    /// UpdateInstrumentIdentifierRequest
    /// </summary>
    [DataContract]
    public partial class UpdateInstrumentIdentifierRequest :  IEquatable<UpdateInstrumentIdentifierRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInstrumentIdentifierRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateInstrumentIdentifierRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInstrumentIdentifierRequest" /> class.
        /// </summary>
        /// <param name="type">The allowable instrument identifier to update, insert or remove e.g. &#39;Figi&#39;. (required).</param>
        /// <param name="value">The new value of the allowable instrument identifier. If unspecified the identifier will be removed from the instrument..</param>
        /// <param name="effectiveAt">The effective datetime from which the identifier should be updated, inserted or removed. Defaults to the current LUSID system datetime if not specified..</param>
        public UpdateInstrumentIdentifierRequest(string type = default(string), string value = default(string), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for UpdateInstrumentIdentifierRequest and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            this.Value = value;
            this.EffectiveAt = effectiveAt;
        }
        
        /// <summary>
        /// The allowable instrument identifier to update, insert or remove e.g. &#39;Figi&#39;.
        /// </summary>
        /// <value>The allowable instrument identifier to update, insert or remove e.g. &#39;Figi&#39;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The new value of the allowable instrument identifier. If unspecified the identifier will be removed from the instrument.
        /// </summary>
        /// <value>The new value of the allowable instrument identifier. If unspecified the identifier will be removed from the instrument.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// The effective datetime from which the identifier should be updated, inserted or removed. Defaults to the current LUSID system datetime if not specified.
        /// </summary>
        /// <value>The effective datetime from which the identifier should be updated, inserted or removed. Defaults to the current LUSID system datetime if not specified.</value>
        [DataMember(Name="effectiveAt", EmitDefaultValue=false)]
        public DateTimeOrCutLabel EffectiveAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstrumentIdentifierRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
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
            return this.Equals(input as UpdateInstrumentIdentifierRequest);
        }

        /// <summary>
        /// Returns true if UpdateInstrumentIdentifierRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateInstrumentIdentifierRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateInstrumentIdentifierRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.EffectiveAt != null)
                    hashCode = hashCode * 59 + this.EffectiveAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
