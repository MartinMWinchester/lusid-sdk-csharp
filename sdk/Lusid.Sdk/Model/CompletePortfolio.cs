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
    /// CompletePortfolio
    /// </summary>
    [DataContract]
    public partial class CompletePortfolio :  IEquatable<CompletePortfolio>
    {
        /// <summary>
        /// The type of the portfolio.
        /// </summary>
        /// <value>The type of the portfolio.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Transaction for value: Transaction
            /// </summary>
            [EnumMember(Value = "Transaction")]
            Transaction = 1,

            /// <summary>
            /// Enum Reference for value: Reference
            /// </summary>
            [EnumMember(Value = "Reference")]
            Reference = 2,

            /// <summary>
            /// Enum DerivedTransaction for value: DerivedTransaction
            /// </summary>
            [EnumMember(Value = "DerivedTransaction")]
            DerivedTransaction = 3

        }

        /// <summary>
        /// The type of the portfolio.
        /// </summary>
        /// <value>The type of the portfolio.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletePortfolio" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompletePortfolio() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletePortfolio" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="parentPortfolioId">parentPortfolioId.</param>
        /// <param name="version">version (required).</param>
        /// <param name="properties">The requested portfolio properties. These will be from the &#39;Portfolio&#39; domain..</param>
        /// <param name="baseCurrency">If the portfolio is a transaction portfolio or derived transaction portfolio, this is the base currency of the portfolio..</param>
        /// <param name="links">links.</param>
        public CompletePortfolio(ResourceId id = default(ResourceId), ResourceId parentPortfolioId = default(ResourceId), Version version = default(Version), List<Property> properties = default(List<Property>), string baseCurrency = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CompletePortfolio and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for CompletePortfolio and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            
            this.ParentPortfolioId = parentPortfolioId;
            this.Properties = properties;
            this.BaseCurrency = baseCurrency;
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; private set; }

        /// <summary>
        /// The long form description of the portfolio.
        /// </summary>
        /// <value>The long form description of the portfolio.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }

        /// <summary>
        /// The name of the portfolio.
        /// </summary>
        /// <value>The name of the portfolio.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// The effective datetime at which the portfolio was created. No transactions or constituents can be added to the portfolio before this date.
        /// </summary>
        /// <value>The effective datetime at which the portfolio was created. No transactions or constituents can be added to the portfolio before this date.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTimeOffset? Created { get; private set; }

        /// <summary>
        /// Gets or Sets ParentPortfolioId
        /// </summary>
        [DataMember(Name="parentPortfolioId", EmitDefaultValue=false)]
        public ResourceId ParentPortfolioId { get; set; }

        /// <summary>
        /// Whether or not this is a derived portfolio.
        /// </summary>
        /// <value>Whether or not this is a derived portfolio.</value>
        [DataMember(Name="isDerived", EmitDefaultValue=false)]
        public bool? IsDerived { get; private set; }


        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public Version Version { get; set; }

        /// <summary>
        /// The requested portfolio properties. These will be from the &#39;Portfolio&#39; domain.
        /// </summary>
        /// <value>The requested portfolio properties. These will be from the &#39;Portfolio&#39; domain.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// If the portfolio is a transaction portfolio or derived transaction portfolio, this is the base currency of the portfolio.
        /// </summary>
        /// <value>If the portfolio is a transaction portfolio or derived transaction portfolio, this is the base currency of the portfolio.</value>
        [DataMember(Name="baseCurrency", EmitDefaultValue=false)]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompletePortfolio {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ParentPortfolioId: ").Append(ParentPortfolioId).Append("\n");
            sb.Append("  IsDerived: ").Append(IsDerived).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as CompletePortfolio);
        }

        /// <summary>
        /// Returns true if CompletePortfolio instances are equal
        /// </summary>
        /// <param name="input">Instance of CompletePortfolio to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompletePortfolio input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.ParentPortfolioId == input.ParentPortfolioId ||
                    (this.ParentPortfolioId != null &&
                    this.ParentPortfolioId.Equals(input.ParentPortfolioId))
                ) && 
                (
                    this.IsDerived == input.IsDerived ||
                    (this.IsDerived != null &&
                    this.IsDerived.Equals(input.IsDerived))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.BaseCurrency == input.BaseCurrency ||
                    (this.BaseCurrency != null &&
                    this.BaseCurrency.Equals(input.BaseCurrency))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.ParentPortfolioId != null)
                    hashCode = hashCode * 59 + this.ParentPortfolioId.GetHashCode();
                if (this.IsDerived != null)
                    hashCode = hashCode * 59 + this.IsDerived.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.BaseCurrency != null)
                    hashCode = hashCode * 59 + this.BaseCurrency.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
