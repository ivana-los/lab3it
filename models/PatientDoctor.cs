﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvccc.Models
{
	public class PatientDoctor
	{

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}