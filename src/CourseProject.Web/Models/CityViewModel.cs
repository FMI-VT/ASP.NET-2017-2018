namespace CourseProject.Web.Models
{
    using CourseProject.DB.Entities;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CityViewModel : BaseViewModel
    {
        #region Properties
        [Required]
        [Display(Name = "Име")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Името трябва да съдържа между 3 и 20 символа!")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Община")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Името трябва да съдържа между 3 и 20 символа!")]
        public string MunicipalityName { get; set; }

        [Required]
        [Display(Name = "Област")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Името трябва да съдържа между 3 и 20 символа!")]
        public string DistrictName { get; set; }

        [Required]
        [Display(Name = "Държава")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Името трябва да съдържа между 3 и 20 символа!")]
        public string CountryName { get; set; }
        #endregion

        #region Constructors
        public CityViewModel(City e)
        {
            Id = e.Id;
            Name = e.Name;
            MunicipalityName = e.MunicipalityName;
            DistrictName = e.DistrictName;
            CountryName = e.CountryName;
            CreatedTime = e.CreatedTime;
            UpdatedTime = e.UpdatedTime;
        }
        #endregion
    }
}