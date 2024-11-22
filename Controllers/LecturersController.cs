using Microsoft.AspNetCore.Mvc;
using PROG.POE.Data;
using System.Linq;
namespace PROG.POE.Controllers
{


    public class LecturersController : Controller
    {
        private readonly InMemoryDataStore _dataStore;

        public LecturersController(InMemoryDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public IActionResult Index()
        {
            var lecturers = _dataStore.Lecturers.ToList();
            return View(lecturers);
        }
    }
}
