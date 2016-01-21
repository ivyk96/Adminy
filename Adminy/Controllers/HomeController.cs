using System.Web.Mvc;

namespace Adminy
{
    public class HomeController : Controller
    {
        private DataContext _db = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Data data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }

            _db.Data.Add(data);
            _db.SaveChanges();

            return RedirectToAction("Overview");
        }

        public ActionResult Overview()
        {
            var Data = _db.Data;
            return View(Data);
        }
    }
}