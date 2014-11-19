namespace AsoiafWikiDb.Controllers
{
    using System.Web.Mvc;

    using AsoiafWikiDb.Models;

    public class AdminController : Controller
    {
        public ViewResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Index(string password)
        {
            Repository.Instance.Refresh();

            return this.View();
        }
    }
}
