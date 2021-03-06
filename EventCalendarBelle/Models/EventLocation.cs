﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Runtime.Serialization;

namespace EventCalendarBelle.Models
{
    [TableName("ec_locations")]
    [PrimaryKey("id", autoIncrement = true)]
    [ExplicitColumns]
    [DataContract(Name = "location", Namespace = "")]
    public class EventLocation
    {
        [Column("id")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        [HiddenInput(DisplayValue = false)]
        [Required]
        [DataMember(Name = "id", IsRequired = true)]
        public int Id { get; set; }

        [Column("lname")]
        [Required]
        [Display(Name = "Location Name")]
        [DataMember(Name = "name", IsRequired = true)]
        public string LocationName { get; set; }

        [Column("street")]
        [Display(Name = "Street")]
        [NullSetting(NullSetting = NullSettings.Null)]
        [DataMember(Name = "street")]
        public string Street { get; set; }

        [Column("zip")]
        [Display(Name = "Zipcode")]
        [NullSetting(NullSetting = NullSettings.Null)]
        [DataMember(Name = "zipCode")]
        public string ZipCode { get; set; }

        [Column("city")]
        [Display(Name = "City")]
        [NullSetting(NullSetting = NullSettings.Null)]
        [DataMember(Name = "city")]
        public string City { get; set; }

        [Column("country")]
        [Display(Name = "Country")]
        [NullSetting(NullSetting = NullSettings.Null)]
        [DataMember(Name = "country")]
        public string Country { get; set; }

        [Column("latitude")]
        [Required]
        [DataMember(Name = "lat", IsRequired = true)]
        public string lat { get; set; }

        [Column("longitude")]
        [Required]
        [DataMember(Name = "lon", IsRequired = true)]
        public string lon { get; set; }
    }
}