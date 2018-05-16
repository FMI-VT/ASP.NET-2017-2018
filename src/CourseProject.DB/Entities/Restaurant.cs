namespace CourseProject.DB.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Restaurant : BaseEntity
    {
        [Required, StringLength(50)]
        [Index("IX_RestaurantNameUnique", IsUnique = true)]
        public string Name { get; set; }

        [Required]
        public int SeatsNumber { get; set; }

        [Required, StringLength(50)]
        public string MenuType { get; set; }

        [Required, StringLength(20)]
        public string WorkingHours { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public bool SuitableForKids { get; set; }

        [Required]
        public int LocationId { get; set; }

        [Required, ForeignKey("LocationId")]
        public virtual Location Location { get; set; }

        [Required]
        public virtual ICollection<Image> Images { get; set; }
    }
}
