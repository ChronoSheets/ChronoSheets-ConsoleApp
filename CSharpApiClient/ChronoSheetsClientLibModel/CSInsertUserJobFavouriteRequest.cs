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
    /// Used to mark a JobCode as a Favourite.  Favourites can be used in the Mobile app and on the ChronoSheets website
    /// </summary>
    [DataContract]
    public partial class CSInsertUserJobFavouriteRequest :  IEquatable<CSInsertUserJobFavouriteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSInsertUserJobFavouriteRequest" /> class.
        /// </summary>
        /// <param name="JobId">The Id of the JobCode that is being marked as a favourite.</param>
        public CSInsertUserJobFavouriteRequest(int? JobId = default(int?))
        {
            this.JobId = JobId;
        }
        
        /// <summary>
        /// The Id of the JobCode that is being marked as a favourite
        /// </summary>
        /// <value>The Id of the JobCode that is being marked as a favourite</value>
        [DataMember(Name="JobId", EmitDefaultValue=false)]
        public int? JobId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSInsertUserJobFavouriteRequest {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
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
            return this.Equals(input as CSInsertUserJobFavouriteRequest);
        }

        /// <summary>
        /// Returns true if CSInsertUserJobFavouriteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CSInsertUserJobFavouriteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSInsertUserJobFavouriteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
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
