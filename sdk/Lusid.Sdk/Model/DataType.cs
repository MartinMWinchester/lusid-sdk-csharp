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
    /// DataType
    /// </summary>
    [DataContract]
    public partial class DataType :  IEquatable<DataType>
    {
        /// <summary>
        /// Defines TypeValueRange
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeValueRangeEnum
        {
            /// <summary>
            /// Enum Open for value: Open
            /// </summary>
            [EnumMember(Value = "Open")]
            Open = 1,

            /// <summary>
            /// Enum Closed for value: Closed
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed = 2

        }

        /// <summary>
        /// Gets or Sets TypeValueRange
        /// </summary>
        [DataMember(Name="typeValueRange", EmitDefaultValue=false)]
        public TypeValueRangeEnum TypeValueRange { get; set; }
        /// <summary>
        /// Defines ValueType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueTypeEnum
        {
            /// <summary>
            /// Enum String for value: String
            /// </summary>
            [EnumMember(Value = "String")]
            String = 1,

            /// <summary>
            /// Enum Int for value: Int
            /// </summary>
            [EnumMember(Value = "Int")]
            Int = 2,

            /// <summary>
            /// Enum Decimal for value: Decimal
            /// </summary>
            [EnumMember(Value = "Decimal")]
            Decimal = 3,

            /// <summary>
            /// Enum DateTime for value: DateTime
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTime = 4,

            /// <summary>
            /// Enum Boolean for value: Boolean
            /// </summary>
            [EnumMember(Value = "Boolean")]
            Boolean = 5,

            /// <summary>
            /// Enum Map for value: Map
            /// </summary>
            [EnumMember(Value = "Map")]
            Map = 6,

            /// <summary>
            /// Enum List for value: List
            /// </summary>
            [EnumMember(Value = "List")]
            List = 7,

            /// <summary>
            /// Enum PropertyArray for value: PropertyArray
            /// </summary>
            [EnumMember(Value = "PropertyArray")]
            PropertyArray = 8,

            /// <summary>
            /// Enum Percentage for value: Percentage
            /// </summary>
            [EnumMember(Value = "Percentage")]
            Percentage = 9,

            /// <summary>
            /// Enum BenchmarkType for value: BenchmarkType
            /// </summary>
            [EnumMember(Value = "BenchmarkType")]
            BenchmarkType = 10,

            /// <summary>
            /// Enum Code for value: Code
            /// </summary>
            [EnumMember(Value = "Code")]
            Code = 11,

            /// <summary>
            /// Enum Id for value: Id
            /// </summary>
            [EnumMember(Value = "Id")]
            Id = 12,

            /// <summary>
            /// Enum Uri for value: Uri
            /// </summary>
            [EnumMember(Value = "Uri")]
            Uri = 13,

            /// <summary>
            /// Enum ArrayOfIds for value: ArrayOfIds
            /// </summary>
            [EnumMember(Value = "ArrayOfIds")]
            ArrayOfIds = 14,

            /// <summary>
            /// Enum ArrayOfTransactionAliases for value: ArrayOfTransactionAliases
            /// </summary>
            [EnumMember(Value = "ArrayOfTransactionAliases")]
            ArrayOfTransactionAliases = 15,

            /// <summary>
            /// Enum ArrayofTransactionMovements for value: ArrayofTransactionMovements
            /// </summary>
            [EnumMember(Value = "ArrayofTransactionMovements")]
            ArrayofTransactionMovements = 16,

            /// <summary>
            /// Enum ArrayofUnits for value: ArrayofUnits
            /// </summary>
            [EnumMember(Value = "ArrayofUnits")]
            ArrayofUnits = 17,

            /// <summary>
            /// Enum StringArray for value: StringArray
            /// </summary>
            [EnumMember(Value = "StringArray")]
            StringArray = 18,

            /// <summary>
            /// Enum CurrencyAndAmount for value: CurrencyAndAmount
            /// </summary>
            [EnumMember(Value = "CurrencyAndAmount")]
            CurrencyAndAmount = 19,

            /// <summary>
            /// Enum TradePrice for value: TradePrice
            /// </summary>
            [EnumMember(Value = "TradePrice")]
            TradePrice = 20,

            /// <summary>
            /// Enum UnitCreation for value: UnitCreation
            /// </summary>
            [EnumMember(Value = "UnitCreation")]
            UnitCreation = 21,

            /// <summary>
            /// Enum Currency for value: Currency
            /// </summary>
            [EnumMember(Value = "Currency")]
            Currency = 22,

            /// <summary>
            /// Enum UserId for value: UserId
            /// </summary>
            [EnumMember(Value = "UserId")]
            UserId = 23,

            /// <summary>
            /// Enum MetricValue for value: MetricValue
            /// </summary>
            [EnumMember(Value = "MetricValue")]
            MetricValue = 24,

            /// <summary>
            /// Enum QuoteId for value: QuoteId
            /// </summary>
            [EnumMember(Value = "QuoteId")]
            QuoteId = 25,

            /// <summary>
            /// Enum QuoteSeriesId for value: QuoteSeriesId
            /// </summary>
            [EnumMember(Value = "QuoteSeriesId")]
            QuoteSeriesId = 26,

            /// <summary>
            /// Enum ResourceId for value: ResourceId
            /// </summary>
            [EnumMember(Value = "ResourceId")]
            ResourceId = 27,

            /// <summary>
            /// Enum ResultValue for value: ResultValue
            /// </summary>
            [EnumMember(Value = "ResultValue")]
            ResultValue = 28,

            /// <summary>
            /// Enum CutLocalTime for value: CutLocalTime
            /// </summary>
            [EnumMember(Value = "CutLocalTime")]
            CutLocalTime = 29,

            /// <summary>
            /// Enum DateOrCutLabel for value: DateOrCutLabel
            /// </summary>
            [EnumMember(Value = "DateOrCutLabel")]
            DateOrCutLabel = 30,

            /// <summary>
            /// Enum Transition for value: Transition
            /// </summary>
            [EnumMember(Value = "Transition")]
            Transition = 31,

            /// <summary>
            /// Enum StructuredData for value: StructuredData
            /// </summary>
            [EnumMember(Value = "StructuredData")]
            StructuredData = 32,

            /// <summary>
            /// Enum StructuredDataId for value: StructuredDataId
            /// </summary>
            [EnumMember(Value = "StructuredDataId")]
            StructuredDataId = 33,

            /// <summary>
            /// Enum ConfigurationRecipe for value: ConfigurationRecipe
            /// </summary>
            [EnumMember(Value = "ConfigurationRecipe")]
            ConfigurationRecipe = 34,

            /// <summary>
            /// Enum ConfigurationRecipeSnippet for value: ConfigurationRecipeSnippet
            /// </summary>
            [EnumMember(Value = "ConfigurationRecipeSnippet")]
            ConfigurationRecipeSnippet = 35,

            /// <summary>
            /// Enum StructuredResultDataId for value: StructuredResultDataId
            /// </summary>
            [EnumMember(Value = "StructuredResultDataId")]
            StructuredResultDataId = 36,

            /// <summary>
            /// Enum StructuredResultData for value: StructuredResultData
            /// </summary>
            [EnumMember(Value = "StructuredResultData")]
            StructuredResultData = 37,

            /// <summary>
            /// Enum DataMapping for value: DataMapping
            /// </summary>
            [EnumMember(Value = "DataMapping")]
            DataMapping = 38,

            /// <summary>
            /// Enum LusidInstrument for value: LusidInstrument
            /// </summary>
            [EnumMember(Value = "LusidInstrument")]
            LusidInstrument = 39,

            /// <summary>
            /// Enum WeightedInstrument for value: WeightedInstrument
            /// </summary>
            [EnumMember(Value = "WeightedInstrument")]
            WeightedInstrument = 40,

            /// <summary>
            /// Enum Tenor for value: Tenor
            /// </summary>
            [EnumMember(Value = "Tenor")]
            Tenor = 41,

            /// <summary>
            /// Enum CdsDetailSpecifications for value: CdsDetailSpecifications
            /// </summary>
            [EnumMember(Value = "CdsDetailSpecifications")]
            CdsDetailSpecifications = 42,

            /// <summary>
            /// Enum FlowConventions for value: FlowConventions
            /// </summary>
            [EnumMember(Value = "FlowConventions")]
            FlowConventions = 43,

            /// <summary>
            /// Enum OrderId for value: OrderId
            /// </summary>
            [EnumMember(Value = "OrderId")]
            OrderId = 44

        }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public ValueTypeEnum ValueType { get; set; }
        /// <summary>
        /// Defines UnitSchema
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitSchemaEnum
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
        /// Gets or Sets UnitSchema
        /// </summary>
        [DataMember(Name="unitSchema", EmitDefaultValue=false)]
        public UnitSchemaEnum? UnitSchema { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataType" /> class.
        /// </summary>
        /// <param name="href">href.</param>
        /// <param name="typeValueRange">typeValueRange (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="valueType">valueType (required).</param>
        /// <param name="acceptableValues">acceptableValues.</param>
        /// <param name="unitSchema">unitSchema.</param>
        /// <param name="acceptableUnits">acceptableUnits.</param>
        /// <param name="links">links.</param>
        public DataType(string href = default(string), TypeValueRangeEnum typeValueRange = default(TypeValueRangeEnum), ResourceId id = default(ResourceId), string displayName = default(string), string description = default(string), ValueTypeEnum valueType = default(ValueTypeEnum), List<string> acceptableValues = default(List<string>), UnitSchemaEnum? unitSchema = default(UnitSchemaEnum?), List<IUnitDefinitionDto> acceptableUnits = default(List<IUnitDefinitionDto>), List<Link> links = default(List<Link>))
        {
            // to ensure "typeValueRange" is required (not null)
            if (typeValueRange == null)
            {
                throw new InvalidDataException("typeValueRange is a required property for DataType and cannot be null");
            }
            else
            {
                this.TypeValueRange = typeValueRange;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for DataType and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for DataType and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for DataType and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            
            // to ensure "valueType" is required (not null)
            if (valueType == null)
            {
                throw new InvalidDataException("valueType is a required property for DataType and cannot be null");
            }
            else
            {
                this.ValueType = valueType;
            }
            
            this.Href = href;
            this.AcceptableValues = acceptableValues;
            this.UnitSchema = unitSchema;
            this.AcceptableUnits = acceptableUnits;
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Gets or Sets AcceptableValues
        /// </summary>
        [DataMember(Name="acceptableValues", EmitDefaultValue=false)]
        public List<string> AcceptableValues { get; set; }


        /// <summary>
        /// Gets or Sets AcceptableUnits
        /// </summary>
        [DataMember(Name="acceptableUnits", EmitDefaultValue=false)]
        public List<IUnitDefinitionDto> AcceptableUnits { get; set; }

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
            sb.Append("class DataType {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  TypeValueRange: ").Append(TypeValueRange).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  AcceptableValues: ").Append(AcceptableValues).Append("\n");
            sb.Append("  UnitSchema: ").Append(UnitSchema).Append("\n");
            sb.Append("  AcceptableUnits: ").Append(AcceptableUnits).Append("\n");
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
            return this.Equals(input as DataType);
        }

        /// <summary>
        /// Returns true if DataType instances are equal
        /// </summary>
        /// <param name="input">Instance of DataType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.TypeValueRange == input.TypeValueRange ||
                    (this.TypeValueRange != null &&
                    this.TypeValueRange.Equals(input.TypeValueRange))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.AcceptableValues == input.AcceptableValues ||
                    this.AcceptableValues != null &&
                    input.AcceptableValues != null &&
                    this.AcceptableValues.SequenceEqual(input.AcceptableValues)
                ) && 
                (
                    this.UnitSchema == input.UnitSchema ||
                    (this.UnitSchema != null &&
                    this.UnitSchema.Equals(input.UnitSchema))
                ) && 
                (
                    this.AcceptableUnits == input.AcceptableUnits ||
                    this.AcceptableUnits != null &&
                    input.AcceptableUnits != null &&
                    this.AcceptableUnits.SequenceEqual(input.AcceptableUnits)
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.TypeValueRange != null)
                    hashCode = hashCode * 59 + this.TypeValueRange.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.AcceptableValues != null)
                    hashCode = hashCode * 59 + this.AcceptableValues.GetHashCode();
                if (this.UnitSchema != null)
                    hashCode = hashCode * 59 + this.UnitSchema.GetHashCode();
                if (this.AcceptableUnits != null)
                    hashCode = hashCode * 59 + this.AcceptableUnits.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
