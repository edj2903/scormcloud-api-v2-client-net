/* 
 * SCORM Cloud Rest API
 *
 * REST API used for SCORM Cloud integrations.
 *
 * OpenAPI spec version: 2.0
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
using SwaggerDateConverter = Com.RusticiSoftware.Cloud.V2.Client.SwaggerDateConverter;

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// SettingListSchema
    /// </summary>
    [DataContract]
    public partial class SettingListSchema :  IEquatable<SettingListSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingListSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SettingListSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingListSchema" /> class.
        /// </summary>
        /// <param name="settingItems">settingItems (required).</param>
        public SettingListSchema(List<SettingItem> settingItems = default(List<SettingItem>))
        {
            // to ensure "settingItems" is required (not null)
            if (settingItems == null)
            {
                throw new InvalidDataException("settingItems is a required property for SettingListSchema and cannot be null");
            }
            else
            {
                this.SettingItems = settingItems;
            }
        }
        
        /// <summary>
        /// Gets or Sets SettingItems
        /// </summary>
        [DataMember(Name="settingItems", EmitDefaultValue=false)]
        public List<SettingItem> SettingItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingListSchema {\n");
            sb.Append("  SettingItems: ").Append(SettingItems).Append("\n");
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
            return this.Equals(input as SettingListSchema);
        }

        /// <summary>
        /// Returns true if SettingListSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of SettingListSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingListSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SettingItems == input.SettingItems ||
                    this.SettingItems != null &&
                    this.SettingItems.SequenceEqual(input.SettingItems)
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
                if (this.SettingItems != null)
                    hashCode = hashCode * 59 + this.SettingItems.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
