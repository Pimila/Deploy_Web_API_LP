using System;
using System.ComponentModel.DataAnnotations;

namespace Deploy_Web_API_LP.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        [Required]
        [MaxLength(100)]
        public string AddressLine1 { get; set; }

        [MaxLength(100)]
        public string AddressLine2 { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(50)]
        public string StateProvince { get; set; }

        [Required]
        [MaxLength(50)]
        public string CountryRegion { get; set; }

        [Required]
        [MaxLength(15)]
        public string PostalCode { get; set; }

        [Required]
        public Guid rowguid { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }
    }
}
