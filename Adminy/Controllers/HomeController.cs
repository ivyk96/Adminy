using System.Web.Mvc;

namespace Adminy
{
    public class HomeController : Controller
    {
        private AdminyContext _db = new AdminyContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Shift data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }

            _db.Shift.Add(data);
            _db.SaveChanges();

            return RedirectToAction("Overview");
        }

        public ActionResult Overview()
        {
            var Data = _db.Shift;
            return View(Data);
        }
    }
}