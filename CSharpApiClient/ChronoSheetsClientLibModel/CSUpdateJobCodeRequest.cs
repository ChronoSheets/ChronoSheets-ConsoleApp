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
    /// Fields used to update an existing JobCode
    /// </summary>
    [DataContract]
    public partial class CSUpdateJobCodeRequest :  IEquatable<CSUpdateJobCodeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSUpdateJobCodeRequest" /> class.
        /// </summary>
        /// <param name="Id">The Id of the JobCode to be updated.</param>
        /// <param name="Code">The new JobCode to be set.</param>
        /// <param name="ProjectId">The Id of the Project to be associated to.</param>
        /// <param name="ClientId">The Id of the Client to be associated to.</param>
        /// <param name="LinkedTaskIds">A collection of Task Ids to be available when choosing this JobCode.</param>
        /// <param name="LinkedOrgGroupIds">Restrict the access to this JobCode by specifying which Organisation Groups can have access.  Only employees in these Organisation Groups will be able to access this JobCode.</param>
        /// <param name="IsDeleted">Whether or not this JobCode is to be marked as deleted.</param>
        public CSUpdateJobCodeRequest(int? Id = default(int?), string Code = default(string), int? ProjectId = default(int?), int? ClientId = default(int?), List<int?> LinkedTaskIds = default(List<int?>), List<int?> LinkedOrgGroupIds = default(List<int?>), bool? IsDeleted = default(bool?))
        {
            this.Id = Id;
            this.Code = Code;
            this.ProjectId = ProjectId;
            this.ClientId = ClientId;
            this.LinkedTaskIds = LinkedTaskIds;
            this.LinkedOrgGroupIds = LinkedOrgGroupIds;
            this.IsDeleted = IsDeleted;
        }
        
        /// <summary>
        /// The Id of the JobCode to be updated
        /// </summary>
        /// <value>The Id of the JobCode to be updated</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The new JobCode to be set
        /// </summary>
        /// <value>The new JobCode to be set</value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The Id of the Project to be associated to
        /// </summary>
        /// <value>The Id of the Project to be associated to</value>
        [DataMember(Name="ProjectId", EmitDefaultValue=false)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// The Id of the Client to be associated to
        /// </summary>
        /// <value>The Id of the Client to be associated to</value>
        [DataMember(Name="ClientId", EmitDefaultValue=false)]
        public int? ClientId { get; set; }

        /// <summary>
        /// A collection of Task Ids to be available when choosing this JobCode
        /// </summary>
        /// <value>A collection of Task Ids to be available when choosing this JobCode</value>
        [DataMember(Name="LinkedTaskIds", EmitDefaultValue=false)]
        public List<int?> LinkedTaskIds { get; set; }

        /// <summary>
        /// Restrict the access to this JobCode by specifying which Organisation Groups can have access.  Only employees in these Organisation Groups will be able to access this JobCode
        /// </summary>
        /// <value>Restrict the access to this JobCode by specifying which Organisation Groups can have access.  Only employees in these Organisation Groups will be able to access this JobCode</value>
        [DataMember(Name="LinkedOrgGroupIds", EmitDefaultValue=false)]
        public List<int?> LinkedOrgGroupIds { get; set; }

        /// <summary>
        /// Whether or not this JobCode is to be marked as deleted
        /// </summary>
        /// <value>Whether or not this JobCode is to be marked as deleted</value>
        [DataMember(Name="IsDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSUpdateJobCodeRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  LinkedTaskIds: ").Append(LinkedTaskIds).Append("\n");
            sb.Append("  LinkedOrgGroupIds: ").Append(LinkedOrgGroupIds).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return this.Equals(input as CSUpdateJobCodeRequest);
        }

        /// <summary>
        /// Returns true if CSUpdateJobCodeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CSUpdateJobCodeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSUpdateJobCodeRequest input)
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.LinkedTaskIds == input.LinkedTaskIds ||
                    this.LinkedTaskIds != null &&
                    this.LinkedTaskIds.SequenceEqual(input.LinkedTaskIds)
                ) && 
                (
                    this.LinkedOrgGroupIds == input.LinkedOrgGroupIds ||
                    this.LinkedOrgGroupIds != null &&
                    this.LinkedOrgGroupIds.SequenceEqual(input.LinkedOrgGroupIds)
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.LinkedTaskIds != null)
                    hashCode = hashCode * 59 + this.LinkedTaskIds.GetHashCode();
                if (this.LinkedOrgGroupIds != null)
                    hashCode = hashCode * 59 + this.LinkedOrgGroupIds.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
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