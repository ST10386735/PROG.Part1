using Microsoft.AspNetCore.Mvc;

namespace PROG.POE.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string AdditionalNotes { get; set; }
        public string DocumentPath { get; set; }
        public string Status { get; set; }
        public int ClaimID { get; internal set; }
        public string Description { get; internal set; }
        public int Amount { get; internal set; }
        public DateTime SubmissionDate { get; internal set; }
        public int LecturerID { get; internal set; }
        public string LecturerName { get; set; }
        public Lecturer? Lecturer { get; internal set; }
    }
}
