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
    /// XapiCredentialPutSchema
    /// </summary>
    [DataContract]
    public partial class XapiCredentialPutSchema :  IEquatable<XapiCredentialPutSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XapiCredentialPutSchema" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="info">info.</param>
        /// <param name="secret">secret.</param>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="auth">auth.</param>
        /// <param name="permissionsLevel">permissionsLevel.</param>
        public XapiCredentialPutSchema(string id = default(string), string name = default(string), string info = default(string), string secret = default(string), bool? isEnabled = default(bool?), XapiCredentialAuthTypeSchema auth = default(XapiCredentialAuthTypeSchema), XapiCredentialPermissionsLevelSchema permissionsLevel = default(XapiCredentialPermissionsLevelSchema))
        {
            this.Id = id;
            this.Name = name;
            this.Info = info;
            this.Secret = secret;
            this.IsEnabled = isEnabled;
            this.Auth = auth;
            this.PermissionsLevel = permissionsLevel;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public string Info { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Auth
        /// </summary>
        [DataMember(Name="auth", EmitDefaultValue=false)]
        public XapiCredentialAuthTypeSchema Auth { get; set; }

        /// <summary>
        /// Gets or Sets PermissionsLevel
        /// </summary>
        [DataMember(Name="permissionsLevel", EmitDefaultValue=false)]
        public XapiCredentialPermissionsLevelSchema PermissionsLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XapiCredentialPutSchema {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Auth: ").Append(Auth).Append("\n");
            sb.Append("  PermissionsLevel: ").Append(PermissionsLevel).Append("\n");
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
            return this.Equals(input as XapiCredentialPutSchema);
        }

        /// <summary>
        /// Returns true if XapiCredentialPutSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of XapiCredentialPutSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XapiCredentialPutSchema input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.Auth == input.Auth ||
                    (this.Auth != null &&
                    this.Auth.Equals(input.Auth))
                ) && 
                (
                    this.PermissionsLevel == input.PermissionsLevel ||
                    (this.PermissionsLevel != null &&
                    this.PermissionsLevel.Equals(input.PermissionsLevel))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.Auth != null)
                    hashCode = hashCode * 59 + this.Auth.GetHashCode();
                if (this.PermissionsLevel != null)
                    hashCode = hashCode * 59 + this.PermissionsLevel.GetHashCode();
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
