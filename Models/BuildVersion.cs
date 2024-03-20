using System;
using System.ComponentModel.DataAnnotations;

namespace Deploy_Web_API_LP.Models
{
    public class BuildVersion
    {
        [Key]
        public int SystemInformationID { get; set; }

        [Required]
        [MaxLength(50)]
        public string DatabaseVersion { get; set; }

        [Required]
        public DateTime VersionDate { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }
    }
}
