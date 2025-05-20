using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvccc.Models
{
	public class Hospital
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}