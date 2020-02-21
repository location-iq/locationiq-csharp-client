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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// DirectionsMatrix
    /// </summary>
    [DataContract]
    public partial class DirectionsMatrix :  IEquatable<DirectionsMatrix>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectionsMatrix" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="distances">distances.</param>
        /// <param name="fallbackSpeedCells">fallbackSpeedCells.</param>
        /// <param name="sources">sources.</param>
        /// <param name="destinations">destinations.</param>
        public DirectionsMatrix(string code = default(string), List<decimal> distances = default(List<decimal>), List<decimal> fallbackSpeedCells = default(List<decimal>), List<DirectionsMatrixSources> sources = default(List<DirectionsMatrixSources>), List<DirectionsMatrixSources> destinations = default(List<DirectionsMatrixSources>))
        {
            this.Code = code;
            this.Distances = distances;
            this.FallbackSpeedCells = fallbackSpeedCells;
            this.Sources = sources;
            this.Destinations = destinations;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Distances
        /// </summary>
        [DataMember(Name="distances", EmitDefaultValue=false)]
        public List<decimal> Distances { get; set; }

        /// <summary>
        /// Gets or Sets FallbackSpeedCells
        /// </summary>
        [DataMember(Name="fallback_speed_cells", EmitDefaultValue=false)]
        public List<decimal> FallbackSpeedCells { get; set; }

        /// <summary>
        /// Gets or Sets Sources
        /// </summary>
        [DataMember(Name="sources", EmitDefaultValue=false)]
        public List<DirectionsMatrixSources> Sources { get; set; }

        /// <summary>
        /// Gets or Sets Destinations
        /// </summary>
        [DataMember(Name="destinations", EmitDefaultValue=false)]
        public List<DirectionsMatrixSources> Destinations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirectionsMatrix {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Distances: ").Append(Distances).Append("\n");
            sb.Append("  FallbackSpeedCells: ").Append(FallbackSpeedCells).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
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
            return this.Equals(input as DirectionsMatrix);
        }

        /// <summary>
        /// Returns true if DirectionsMatrix instances are equal
        /// </summary>
        /// <param name="input">Instance of DirectionsMatrix to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirectionsMatrix input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Distances == input.Distances ||
                    this.Distances != null &&
                    input.Distances != null &&
                    this.Distances.SequenceEqual(input.Distances)
                ) && 
                (
                    this.FallbackSpeedCells == input.FallbackSpeedCells ||
                    this.FallbackSpeedCells != null &&
                    input.FallbackSpeedCells != null &&
                    this.FallbackSpeedCells.SequenceEqual(input.FallbackSpeedCells)
                ) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    input.Sources != null &&
                    this.Sources.SequenceEqual(input.Sources)
                ) && 
                (
                    this.Destinations == input.Destinations ||
                    this.Destinations != null &&
                    input.Destinations != null &&
                    this.Destinations.SequenceEqual(input.Destinations)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Distances != null)
                    hashCode = hashCode * 59 + this.Distances.GetHashCode();
                if (this.FallbackSpeedCells != null)
                    hashCode = hashCode * 59 + this.FallbackSpeedCells.GetHashCode();
                if (this.Sources != null)
                    hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.Destinations != null)
                    hashCode = hashCode * 59 + this.Destinations.GetHashCode();
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
