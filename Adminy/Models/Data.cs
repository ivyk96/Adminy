using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Adminy
{
    public class Data
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Please enter a valid date")]
        [DisplayName("Date ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:tt}")]
        public DateTime Date { get; set; }

        //public DateTime Start { get; set; }
        //public DateTime End { get; set; }
        //public float Salary { get; set; }
        //public float Payment { get; set; }
    }
}