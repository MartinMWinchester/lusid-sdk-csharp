/* 
 * LUSID API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.10.1392
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
    /// A list of scopes.
    /// </summary>
    [DataContract]
    public partial class ScopeDefinition :  IEquatable<ScopeDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScopeDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeDefinition" /> class.
        /// </summary>
        /// <param name="scope">The unique identifier for the scope. (required).</param>
        public ScopeDefinition(string scope = default(string))
        {
            // to ensure "scope" is required (not null)
            if (scope == null)
            {
                throw new InvalidDataException("scope is a required property for ScopeDefinition and cannot be null");
            }
            else
            {
                this.Scope = scope;
            }
            
        }
        
        /// <summary>
        /// The unique identifier for the scope.
        /// </summary>
        /// <value>The unique identifier for the scope.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScopeDefinition {\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(input as ScopeDefinition);
        }

        /// <summary>
        /// Returns true if ScopeDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of ScopeDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScopeDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
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
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                return hashCode;
            }
        }
    }

}
