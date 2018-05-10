namespace CourseProject.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    abstract public class BaseViewModel
    {
        #region Properties
        [Required]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}")]
        [Display(Name = "Създаден на")]
        public DateTime CreatedTime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}")]
        [Display(Name = "Обновен на")]
        public DateTime UpdatedTime { get; set; }
        #endregion
    }
}