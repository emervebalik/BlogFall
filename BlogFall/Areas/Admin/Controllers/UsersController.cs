using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogFall.Areas.Admin.Controllers
{
    public class UsersController : AdminBaseController
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }
    }
}