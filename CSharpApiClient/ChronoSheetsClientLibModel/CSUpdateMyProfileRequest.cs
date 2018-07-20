/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 5 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = ChronoSheetsAPI.Client.SwaggerDateConverter;

namespace ChronoSheetsAPI.ChronoSheetsClientLibModel
{
    /// <summary>
    /// CSUpdateMyProfileRequest
    /// </summary>
    [DataContract]
    public partial class CSUpdateMyProfileRequest :  IEquatable<CSUpdateMyProfileRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSUpdateMyProfileRequest" /> class.
        /// </summary>
        /// <param name="EmailAddress">EmailAddress.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="OldPassword">OldPassword.</param>
        /// <param name="NewPassword">NewPassword.</param>
        /// <param name="ConfirmNewPassword">ConfirmNewPassword.</param>
        /// <param name="IsSubscribedToNewsletter">IsSubscribedToNewsletter.</param>
        /// <param name="WantsToChangePassword">WantsToChangePassword.</param>
        public CSUpdateMyProfileRequest(string EmailAddress = default(string), string FirstName = default(string), string LastName = default(string), string OldPassword = default(string), string NewPassword = default(string), string ConfirmNewPassword = default(string), bool? IsSubscribedToNewsletter = default(bool?), bool? WantsToChangePassword = default(bool?))
        {
            this.EmailAddress = EmailAddress;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.OldPassword = OldPassword;
            this.NewPassword = NewPassword;
            this.ConfirmNewPassword = ConfirmNewPassword;
            this.IsSubscribedToNewsletter = IsSubscribedToNewsletter;
            this.WantsToChangePassword = WantsToChangePassword;
        }
        
        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets OldPassword
        /// </summary>
        [DataMember(Name="OldPassword", EmitDefaultValue=false)]
        public string OldPassword { get; set; }

        /// <summary>
        /// Gets or Sets NewPassword
        /// </summary>
        [DataMember(Name="NewPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmNewPassword
        /// </summary>
        [DataMember(Name="ConfirmNewPassword", EmitDefaultValue=false)]
        public string ConfirmNewPassword { get; set; }

        /// <summary>
        /// Gets or Sets IsSubscribedToNewsletter
        /// </summary>
        [DataMember(Name="IsSubscribedToNewsletter", EmitDefaultValue=false)]
        public bool? IsSubscribedToNewsletter { get; set; }

        /// <summary>
        /// Gets or Sets WantsToChangePassword
        /// </summary>
        [DataMember(Name="WantsToChangePassword", EmitDefaultValue=false)]
        public bool? WantsToChangePassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSUpdateMyProfileRequest {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  ConfirmNewPassword: ").Append(ConfirmNewPassword).Append("\n");
            sb.Append("  IsSubscribedToNewsletter: ").Append(IsSubscribedToNewsletter).Append("\n");
            sb.Append("  WantsToChangePassword: ").Append(WantsToChangePassword).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CSUpdateMyProfileRequest);
        }

        /// <summary>
        /// Returns true if CSUpdateMyProfileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CSUpdateMyProfileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSUpdateMyProfileRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.OldPassword == input.OldPassword ||
                    (this.OldPassword != null &&
                    this.OldPassword.Equals(input.OldPassword))
                ) && 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.ConfirmNewPassword == input.ConfirmNewPassword ||
                    (this.ConfirmNewPassword != null &&
                    this.ConfirmNewPassword.Equals(input.ConfirmNewPassword))
                ) && 
                (
                    this.IsSubscribedToNewsletter == input.IsSubscribedToNewsletter ||
                    (this.IsSubscribedToNewsletter != null &&
                    this.IsSubscribedToNewsletter.Equals(input.IsSubscribedToNewsletter))
                ) && 
                (
                    this.WantsToChangePassword == input.WantsToChangePassword ||
                    (this.WantsToChangePassword != null &&
                    this.WantsToChangePassword.Equals(input.WantsToChangePassword))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.OldPassword != null)
                    hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                if (this.ConfirmNewPassword != null)
                    hashCode = hashCode * 59 + this.ConfirmNewPassword.GetHashCode();
                if (this.IsSubscribedToNewsletter != null)
                    hashCode = hashCode * 59 + this.IsSubscribedToNewsletter.GetHashCode();
                if (this.WantsToChangePassword != null)
                    hashCode = hashCode * 59 + this.WantsToChangePassword.GetHashCode();
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
