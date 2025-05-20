using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvccc.Models
{
	public class Doctor
	{
        public int id { get; set; }
        public String doktorce { get; set; }
        public int hospitalid { get; set; }
        public Hospital hospital { get; set; }
        public virtual ICollection<Patient> PatientDoctors { get; set; }
        public string test { get; set; }
        public object Patients { get; internal set; }
    }
}
