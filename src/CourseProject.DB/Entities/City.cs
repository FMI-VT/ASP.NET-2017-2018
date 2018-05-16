namespace CourseProject.DB.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class City : BaseEntity
    {
        [Required, StringLength(20)]
        [Index("IX_CityNameUnique", IsUnique = true)]
        public string Name { get; set; }

        [Required, StringLength(20)]
        public string MunicipalityName { get; set; }

        [Required, StringLength(20)]
        public string DistrictName { get; set; }

        [Required, StringLength(20)]
        public string CountryName { get; set; }

        [Required]
        public virtual ICollection<Location> Locations { get; set; }
    }
}
