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
    /// ExecutionRequest
    /// </summary>
    [DataContract]
    public partial class ExecutionRequest :  IEquatable<ExecutionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExecutionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionRequest" /> class.
        /// </summary>
        /// <param name="executionId">The unique identifier of the Execution Report (8) message as assigned by sell-side. FIX field 17. (required).</param>
        /// <param name="side">The side of the order. FIX field 54. (required).</param>
        /// <param name="instrumentIdentifiers">A set of instrument identifiers to use to resolve the execution to a unique instrument. (required).</param>
        /// <param name="transactionTime">Time of execution/order creation. FIX field 60. (required).</param>
        /// <param name="lastShares">Quantity (e.g. shares) bought/sold on this (last) fill. FIX field 32. (required).</param>
        /// <param name="lastPx">Price of this (last) fill. FIX field 31. (required).</param>
        /// <param name="currency">The currency used for the price. FIX field 15. (required).</param>
        public ExecutionRequest(string executionId = default(string), string side = default(string), Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), DateTimeOffset? transactionTime = default(DateTimeOffset?), decimal? lastShares = default(decimal?), decimal? lastPx = default(decimal?), string currency = default(string))
        {
            // to ensure "executionId" is required (not null)
            if (executionId == null)
            {
                throw new InvalidDataException("executionId is a required property for ExecutionRequest and cannot be null");
            }
            else
            {
                this.ExecutionId = executionId;
            }
            
            // to ensure "side" is required (not null)
            if (side == null)
            {
                throw new InvalidDataException("side is a required property for ExecutionRequest and cannot be null");
            }
            else
            {
                this.Side = side;
            }
            
            // to ensure "instrumentIdentifiers" is required (not null)
            if (instrumentIdentifiers == null)
            {
                throw new InvalidDataException("instrumentIdentifiers is a required property for ExecutionRequest and cannot be null");
            }
            else
            {
                this.InstrumentIdentifiers = instrumentIdentifiers;
            }
            
            // to ensure "transactionTime" is required (not null)
            if (transactionTime == null)
            {
                throw new InvalidDataException("transactionTime is a required property for ExecutionRequest and cannot be null");
            }
            else
            {
                this.TransactionTime = transactionTime;
            }
            
            // to ensure "lastShares" is required (not null)
            if (lastShares == null)
            {
                throw new InvalidDataException("lastShares is a required property for ExecutionRequest and cannot be null");
            }
            else
            {
                this.LastShares = lastShares;
            }
            
            // to ensure "lastPx" is required (not null)
            if (lastPx == null)
            {
                throw new InvalidDataException("lastPx is a required property for ExecutionRequest and cannot be null");
            }
            else
            {
                this.LastPx = lastPx;
            }
            
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for ExecutionRequest and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            
        }
        
        /// <summary>
        /// The unique identifier of the Execution Report (8) message as assigned by sell-side. FIX field 17.
        /// </summary>
        /// <value>The unique identifier of the Execution Report (8) message as assigned by sell-side. FIX field 17.</value>
        [DataMember(Name="executionId", EmitDefaultValue=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The side of the order. FIX field 54.
        /// </summary>
        /// <value>The side of the order. FIX field 54.</value>
        [DataMember(Name="side", EmitDefaultValue=false)]
        public string Side { get; set; }

        /// <summary>
        /// A set of instrument identifiers to use to resolve the execution to a unique instrument.
        /// </summary>
        /// <value>A set of instrument identifiers to use to resolve the execution to a unique instrument.</value>
        [DataMember(Name="instrumentIdentifiers", EmitDefaultValue=false)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// Time of execution/order creation. FIX field 60.
        /// </summary>
        /// <value>Time of execution/order creation. FIX field 60.</value>
        [DataMember(Name="transactionTime", EmitDefaultValue=false)]
        public DateTimeOffset? TransactionTime { get; set; }

        /// <summary>
        /// Quantity (e.g. shares) bought/sold on this (last) fill. FIX field 32.
        /// </summary>
        /// <value>Quantity (e.g. shares) bought/sold on this (last) fill. FIX field 32.</value>
        [DataMember(Name="lastShares", EmitDefaultValue=false)]
        public decimal? LastShares { get; set; }

        /// <summary>
        /// Price of this (last) fill. FIX field 31.
        /// </summary>
        /// <value>Price of this (last) fill. FIX field 31.</value>
        [DataMember(Name="lastPx", EmitDefaultValue=false)]
        public decimal? LastPx { get; set; }

        /// <summary>
        /// The currency used for the price. FIX field 15.
        /// </summary>
        /// <value>The currency used for the price. FIX field 15.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionRequest {\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  TransactionTime: ").Append(TransactionTime).Append("\n");
            sb.Append("  LastShares: ").Append(LastShares).Append("\n");
            sb.Append("  LastPx: ").Append(LastPx).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as ExecutionRequest);
        }

        /// <summary>
        /// Returns true if ExecutionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecutionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecutionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.TransactionTime == input.TransactionTime ||
                    (this.TransactionTime != null &&
                    this.TransactionTime.Equals(input.TransactionTime))
                ) && 
                (
                    this.LastShares == input.LastShares ||
                    (this.LastShares != null &&
                    this.LastShares.Equals(input.LastShares))
                ) && 
                (
                    this.LastPx == input.LastPx ||
                    (this.LastPx != null &&
                    this.LastPx.Equals(input.LastPx))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                if (this.TransactionTime != null)
                    hashCode = hashCode * 59 + this.TransactionTime.GetHashCode();
                if (this.LastShares != null)
                    hashCode = hashCode * 59 + this.LastShares.GetHashCode();
                if (this.LastPx != null)
                    hashCode = hashCode * 59 + this.LastPx.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }
    }

}
