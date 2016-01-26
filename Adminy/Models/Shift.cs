using System;
using System.ComponentModel.DataAnnotations;

namespace Adminy
{
    public class Shift
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Please enter a valid date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please enter a valid time")]
        public string Start { get; set; }
    }
}