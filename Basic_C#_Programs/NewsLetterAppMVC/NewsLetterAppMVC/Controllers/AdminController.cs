﻿using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signups = db.SignUps;
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);

                }
                return View(signupVms);
            }
        }
    }
}