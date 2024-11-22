using Microsoft.AspNetCore.Mvc;
using PROG.POE.Models;

namespace PROG.POE.Controllers
{

    public class ClaimsController : Controller
    {
        private static List<Claim> claims = new List<Claim>();
        private static int claimIdCounter = 1;

        // GET: /Claims/SubmitClaim
        public IActionResult SubmitClaim()
        {
            return View();
        }

        // POST: /Claims/SubmitClaim
        [HttpPost]
        public IActionResult SubmitClaim(Claim claim)
        {
            claim.Id = claimIdCounter++;
            claim.Status = "Pending";
            claims.Add(claim);
            ViewBag.Message = "Claim submitted successfully!";
            return View();
        }

        // GET: /Claims/VerifyClaims
        public IActionResult VerifyClaims()
        {
            // Filter to show only pending claims for verification
            var pendingClaims = claims.FindAll(c => c.Status == "Pending");
            return View(pendingClaims);
        }

        // POST: /Claims/ApproveClaim
        [HttpPost]
        public IActionResult ApproveClaim(int id)
        {
            var claim = claims.Find(c => c.Id == id);
            if (claim != null)
            {
                claim.Status = "Approved";
            }
            return RedirectToAction("VerifyClaims");
        }

        // POST: /Claims/RejectClaim
        [HttpPost]
        public IActionResult RejectClaim(int id)
        {
            var claim = claims.Find(c => c.Id == id);
            if (claim != null)
            {
                claim.Status = "Rejected";
            }
            return RedirectToAction("VerifyClaims");
        }

        // GET: /Claims/ClaimStatus
        public IActionResult ClaimStatus()
        {
            return View(claims);
        }

        // GET: /Claims/LecturerClaim
        public IActionResult LecturerClaim()
        {
            return View();
        }

        // POST: /Claims/LecturerClaim
        [HttpPost]
        public IActionResult LecturerClaim(Claim claim)
        {
            if (ModelState.IsValid)
            {
                claim.Id = claimIdCounter++;
                claims.Add(claim);
                return RedirectToAction("ClaimStatus"); // Redirect to a page showing claim status
            }
            return View(claim); // Return the view with the current claim data if validation fails
        }

       
    }
}

