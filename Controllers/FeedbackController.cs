using Prac7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prac7.Controllers
{
    public class FeedbackController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] =
                    "Thank you! Your feedback has been submitted successfully.";

                return RedirectToAction("Index");
            }

            return View(feedback);
        }
    }
}