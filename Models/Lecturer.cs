﻿using Microsoft.AspNetCore.Mvc;

namespace PROG.POE.Models
{
    public class Lecturer
    {
        public int LecturerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal HourlyRate { get; set; }
    }
}
