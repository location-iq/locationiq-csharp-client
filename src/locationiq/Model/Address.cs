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
    /// Address
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="houseNumber">houseNumber.</param>
        /// <param name="road">road.</param>
        /// <param name="residential">residential.</param>
        /// <param name="borough">borough.</param>
        /// <param name="neighbourhood">neighbourhood.</param>
        /// <param name="quarter">quarter.</param>
        /// <param name="hamlet">hamlet.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="island">island.</param>
        /// <param name="village">village.</param>
        /// <param name="town">town.</param>
        /// <param name="city">city.</param>
        /// <param name="cityDistrict">cityDistrict.</param>
        /// <param name="county">county.</param>
        /// <param name="state">state.</param>
        /// <param name="stateDistrict">stateDistrict.</param>
        /// <param name="postcode">postcode.</param>
        /// <param name="country">country.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="stateCode">stateCode.</param>
        public Address(string houseNumber = default(string), string road = default(string), string residential = default(string), string borough = default(string), string neighbourhood = default(string), string quarter = default(string), string hamlet = default(string), string suburb = default(string), string island = default(string), string village = default(string), string town = default(string), string city = default(string), string cityDistrict = default(string), string county = default(string), string state = default(string), string stateDistrict = default(string), string postcode = default(string), string country = default(string), string countryCode = default(string), string stateCode = default(string))
        {
            this.HouseNumber = houseNumber;
            this.Road = road;
            this.Residential = residential;
            this.Borough = borough;
            this.Neighbourhood = neighbourhood;
            this.Quarter = quarter;
            this.Hamlet = hamlet;
            this.Suburb = suburb;
            this.Island = island;
            this.Village = village;
            this.Town = town;
            this.City = city;
            this.CityDistrict = cityDistrict;
            this.County = county;
            this.State = state;
            this.StateDistrict = stateDistrict;
            this.Postcode = postcode;
            this.Country = country;
            this.CountryCode = countryCode;
            this.StateCode = stateCode;
        }
        
        /// <summary>
        /// Gets or Sets HouseNumber
        /// </summary>
        [DataMember(Name="house_number", EmitDefaultValue=false)]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Gets or Sets Road
        /// </summary>
        [DataMember(Name="road", EmitDefaultValue=false)]
        public string Road { get; set; }

        /// <summary>
        /// Gets or Sets Residential
        /// </summary>
        [DataMember(Name="residential", EmitDefaultValue=false)]
        public string Residential { get; set; }

        /// <summary>
        /// Gets or Sets Borough
        /// </summary>
        [DataMember(Name="borough", EmitDefaultValue=false)]
        public string Borough { get; set; }

        /// <summary>
        /// Gets or Sets Neighbourhood
        /// </summary>
        [DataMember(Name="neighbourhood", EmitDefaultValue=false)]
        public string Neighbourhood { get; set; }

        /// <summary>
        /// Gets or Sets Quarter
        /// </summary>
        [DataMember(Name="quarter", EmitDefaultValue=false)]
        public string Quarter { get; set; }

        /// <summary>
        /// Gets or Sets Hamlet
        /// </summary>
        [DataMember(Name="hamlet", EmitDefaultValue=false)]
        public string Hamlet { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name="suburb", EmitDefaultValue=false)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets Island
        /// </summary>
        [DataMember(Name="island", EmitDefaultValue=false)]
        public string Island { get; set; }

        /// <summary>
        /// Gets or Sets Village
        /// </summary>
        [DataMember(Name="village", EmitDefaultValue=false)]
        public string Village { get; set; }

        /// <summary>
        /// Gets or Sets Town
        /// </summary>
        [DataMember(Name="town", EmitDefaultValue=false)]
        public string Town { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets CityDistrict
        /// </summary>
        [DataMember(Name="city_district", EmitDefaultValue=false)]
        public string CityDistrict { get; set; }

        /// <summary>
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets StateDistrict
        /// </summary>
        [DataMember(Name="state_district", EmitDefaultValue=false)]
        public string StateDistrict { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets StateCode
        /// </summary>
        [DataMember(Name="state_code", EmitDefaultValue=false)]
        public string StateCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
            sb.Append("  Road: ").Append(Road).Append("\n");
            sb.Append("  Residential: ").Append(Residential).Append("\n");
            sb.Append("  Borough: ").Append(Borough).Append("\n");
            sb.Append("  Neighbourhood: ").Append(Neighbourhood).Append("\n");
            sb.Append("  Quarter: ").Append(Quarter).Append("\n");
            sb.Append("  Hamlet: ").Append(Hamlet).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  Island: ").Append(Island).Append("\n");
            sb.Append("  Village: ").Append(Village).Append("\n");
            sb.Append("  Town: ").Append(Town).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CityDistrict: ").Append(CityDistrict).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateDistrict: ").Append(StateDistrict).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HouseNumber == input.HouseNumber ||
                    (this.HouseNumber != null &&
                    this.HouseNumber.Equals(input.HouseNumber))
                ) && 
                (
                    this.Road == input.Road ||
                    (this.Road != null &&
                    this.Road.Equals(input.Road))
                ) && 
                (
                    this.Residential == input.Residential ||
                    (this.Residential != null &&
                    this.Residential.Equals(input.Residential))
                ) && 
                (
                    this.Borough == input.Borough ||
                    (this.Borough != null &&
                    this.Borough.Equals(input.Borough))
                ) && 
                (
                    this.Neighbourhood == input.Neighbourhood ||
                    (this.Neighbourhood != null &&
                    this.Neighbourhood.Equals(input.Neighbourhood))
                ) && 
                (
                    this.Quarter == input.Quarter ||
                    (this.Quarter != null &&
                    this.Quarter.Equals(input.Quarter))
                ) && 
                (
                    this.Hamlet == input.Hamlet ||
                    (this.Hamlet != null &&
                    this.Hamlet.Equals(input.Hamlet))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.Island == input.Island ||
                    (this.Island != null &&
                    this.Island.Equals(input.Island))
                ) && 
                (
                    this.Village == input.Village ||
                    (this.Village != null &&
                    this.Village.Equals(input.Village))
                ) && 
                (
                    this.Town == input.Town ||
                    (this.Town != null &&
                    this.Town.Equals(input.Town))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CityDistrict == input.CityDistrict ||
                    (this.CityDistrict != null &&
                    this.CityDistrict.Equals(input.CityDistrict))
                ) && 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StateDistrict == input.StateDistrict ||
                    (this.StateDistrict != null &&
                    this.StateDistrict.Equals(input.StateDistrict))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.StateCode == input.StateCode ||
                    (this.StateCode != null &&
                    this.StateCode.Equals(input.StateCode))
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
                if (this.HouseNumber != null)
                    hashCode = hashCode * 59 + this.HouseNumber.GetHashCode();
                if (this.Road != null)
                    hashCode = hashCode * 59 + this.Road.GetHashCode();
                if (this.Residential != null)
                    hashCode = hashCode * 59 + this.Residential.GetHashCode();
                if (this.Borough != null)
                    hashCode = hashCode * 59 + this.Borough.GetHashCode();
                if (this.Neighbourhood != null)
                    hashCode = hashCode * 59 + this.Neighbourhood.GetHashCode();
                if (this.Quarter != null)
                    hashCode = hashCode * 59 + this.Quarter.GetHashCode();
                if (this.Hamlet != null)
                    hashCode = hashCode * 59 + this.Hamlet.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.Island != null)
                    hashCode = hashCode * 59 + this.Island.GetHashCode();
                if (this.Village != null)
                    hashCode = hashCode * 59 + this.Village.GetHashCode();
                if (this.Town != null)
                    hashCode = hashCode * 59 + this.Town.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.CityDistrict != null)
                    hashCode = hashCode * 59 + this.CityDistrict.GetHashCode();
                if (this.County != null)
                    hashCode = hashCode * 59 + this.County.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StateDistrict != null)
                    hashCode = hashCode * 59 + this.StateDistrict.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.StateCode != null)
                    hashCode = hashCode * 59 + this.StateCode.GetHashCode();
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
