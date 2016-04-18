using System;
using System.ComponentModel.DataAnnotations;

namespace Adminy
{
    public class Shift
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a valid date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Please enter a valid time")]
        public TimeSpan Start { get; set; }

        [Required(ErrorMessage = "Please enter a valid time")]
        public TimeSpan End { get; set; }
    }
}