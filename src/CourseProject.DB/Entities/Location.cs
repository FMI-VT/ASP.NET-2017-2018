namespace CourseProject.DB.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Location : BaseEntity
    {
        [Required, StringLength(8), DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Required, StringLength(20)]
        public string StreetName { get; set; }

        [Required, StringLength(20)]
        public string StreetNum { get; set; }

        [StringLength(50)]
        public string Extra { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required, ForeignKey("CityId")]
        public virtual City City { get; }

        [Required]
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
