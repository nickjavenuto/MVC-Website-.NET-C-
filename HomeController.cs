using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleSPCWebApplication.DAL;
using SampleSPCWebApplication.ViewModels;  

namespace SampleSPCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();
        #region Index
        public ActionResult Index()
        {
            return View();
        }
        #endregion
        #region About
        public ActionResult About()
        {
            IQueryable<EnrollmentDateGroup> data = from student in db.Students
                                                   group student by student.EnrollmentDate into dateGroup
                                                   select new EnrollmentDateGroup()
                                                   {
                                                       EnrollmentDate = dateGroup.Key,
                                                       StudentCount = dateGroup.Count()
                                                   };
            return View(data.ToList());
        }
        #endregion
        protected override void Dispose(bool disposing)
		{
            db.Dispose(); 
			base.Dispose(disposing);
		}
        #region Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #endregion  
    }
}