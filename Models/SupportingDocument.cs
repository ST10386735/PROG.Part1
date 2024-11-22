using Microsoft.AspNetCore.Mvc;

namespace PROG.POE.Models
{
    public class SupportingDocument
    {
        public int DocumentID { get; set; }
        public int ClaimID { get; set; }
        public string DocumentPath { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
