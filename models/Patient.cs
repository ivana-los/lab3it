using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvccc.Models
{
	public class Patient
	{
        
        public int id { get; set; }
        [Required(ErrorMessage = "Името е задолжително")]
        public String Ime { get; set; }
        [Display(Name = "Код на пациентот")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Кодот мора да биде точно 5 цифри")]
        public int code { get; set; }
        public String gender { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }

    }
}