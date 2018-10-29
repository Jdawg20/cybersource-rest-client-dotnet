/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// V2paymentsProcessingInformationIssuer
    /// </summary>
    [DataContract]
    public partial class V2paymentsProcessingInformationIssuer :  IEquatable<V2paymentsProcessingInformationIssuer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2paymentsProcessingInformationIssuer" /> class.
        /// </summary>
        /// <param name="DiscretionaryData">Data defined by the issuer. The value for this reply field will probably be the same as the value that you submitted in the authorization request, but it is possible for the processor, issuer, or acquirer to modify the value.  This field is supported only for Visa transactions on **CyberSource through VisaNet**. .</param>
        public V2paymentsProcessingInformationIssuer(string DiscretionaryData = default(string))
        {
            this.DiscretionaryData = DiscretionaryData;
        }
        
        /// <summary>
        /// Data defined by the issuer. The value for this reply field will probably be the same as the value that you submitted in the authorization request, but it is possible for the processor, issuer, or acquirer to modify the value.  This field is supported only for Visa transactions on **CyberSource through VisaNet**. 
        /// </summary>
        /// <value>Data defined by the issuer. The value for this reply field will probably be the same as the value that you submitted in the authorization request, but it is possible for the processor, issuer, or acquirer to modify the value.  This field is supported only for Visa transactions on **CyberSource through VisaNet**. </value>
        [DataMember(Name="discretionaryData", EmitDefaultValue=false)]
        public string DiscretionaryData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2paymentsProcessingInformationIssuer {\n");
            sb.Append("  DiscretionaryData: ").Append(DiscretionaryData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V2paymentsProcessingInformationIssuer);
        }

        /// <summary>
        /// Returns true if V2paymentsProcessingInformationIssuer instances are equal
        /// </summary>
        /// <param name="other">Instance of V2paymentsProcessingInformationIssuer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2paymentsProcessingInformationIssuer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DiscretionaryData == other.DiscretionaryData ||
                    this.DiscretionaryData != null &&
                    this.DiscretionaryData.Equals(other.DiscretionaryData)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.DiscretionaryData != null)
                    hash = hash * 59 + this.DiscretionaryData.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // DiscretionaryData (string) maxLength
            if(this.DiscretionaryData != null && this.DiscretionaryData.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiscretionaryData, length must be less than 255.", new [] { "DiscretionaryData" });
            }

            yield break;
        }
    }

}