using PROG.POE.Models;

namespace PROG.POE.Data
{
    

    public class InMemoryDataStore
    {
        public List<Lecturer> Lecturers { get; set; } = new List<Lecturer>();
        public List<Claim> Claims { get; set; } = new List<Claim>();

        public InMemoryDataStore()
        {
            // Seed some initial data
            Lecturers.Add(new Lecturer { LecturerID = 1, Name = "John Doe", Email = "john@example.com", HourlyRate = 50 });
            Lecturers.Add(new Lecturer { LecturerID = 2, Name = "Jane Smith", Email = "jane@example.com", HourlyRate = 60 });

            Claims.Add(new Claim { ClaimID = 1, Description = "Test claim", Amount = 100, SubmissionDate = DateTime.Now, Status = "Pending", LecturerID = 1, Lecturer = Lecturers.FirstOrDefault(l => l.LecturerID == 1) });
            Claims.Add(new Claim { ClaimID = 2, Description = "Test claim 2", Amount = 200, SubmissionDate = DateTime.Now, Status = "Pending", LecturerID = 2, Lecturer = Lecturers.FirstOrDefault(l => l.LecturerID == 2) });
        }
    }
}
