/* 
 * LocationIQ
 *
 * LocationIQ provides flexible enterprise-grade location based solutions. We work with developers, startups and enterprises worldwide serving billions of requests everyday. This page provides an overview of the technical aspects of our API and will help you get started.
 *
 * The version of the OpenAPI document: 1.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = locationiq.Client.OpenAPIDateConverter;

namespace locationiq.Model
{
    /// <summary>
    /// Matchquality
    /// </summary>
    [DataContract]
    public partial class Matchquality :  IEquatable<Matchquality>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Matchquality" /> class.
        /// </summary>
        /// <param name="matchcode">matchcode.</param>
        /// <param name="matchtype">matchtype.</param>
        /// <param name="matchlevel">matchlevel.</param>
        public Matchquality(string matchcode = default(string), string matchtype = default(string), string matchlevel = default(string))
        {
            this.Matchcode = matchcode;
            this.Matchtype = matchtype;
            this.Matchlevel = matchlevel;
        }
        
        /// <summary>
        /// Gets or Sets Matchcode
        /// </summary>
        [DataMember(Name="matchcode", EmitDefaultValue=false)]
        public string Matchcode { get; set; }

        /// <summary>
        /// Gets or Sets Matchtype
        /// </summary>
        [DataMember(Name="matchtype", EmitDefaultValue=false)]
        public string Matchtype { get; set; }

        /// <summary>
        /// Gets or Sets Matchlevel
        /// </summary>
        [DataMember(Name="matchlevel", EmitDefaultValue=false)]
        public string Matchlevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Matchquality {\n");
            sb.Append("  Matchcode: ").Append(Matchcode).Append("\n");
            sb.Append("  Matchtype: ").Append(Matchtype).Append("\n");
            sb.Append("  Matchlevel: ").Append(Matchlevel).Append("\n");
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
            return this.Equals(input as Matchquality);
        }

        /// <summary>
        /// Returns true if Matchquality instances are equal
        /// </summary>
        /// <param name="input">Instance of Matchquality to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Matchquality input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Matchcode == input.Matchcode ||
                    (this.Matchcode != null &&
                    this.Matchcode.Equals(input.Matchcode))
                ) && 
                (
                    this.Matchtype == input.Matchtype ||
                    (this.Matchtype != null &&
                    this.Matchtype.Equals(input.Matchtype))
                ) && 
                (
                    this.Matchlevel == input.Matchlevel ||
                    (this.Matchlevel != null &&
                    this.Matchlevel.Equals(input.Matchlevel))
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
                if (this.Matchcode != null)
                    hashCode = hashCode * 59 + this.Matchcode.GetHashCode();
                if (this.Matchtype != null)
                    hashCode = hashCode * 59 + this.Matchtype.GetHashCode();
                if (this.Matchlevel != null)
                    hashCode = hashCode * 59 + this.Matchlevel.GetHashCode();
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
