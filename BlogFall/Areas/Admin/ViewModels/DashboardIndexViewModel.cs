﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogFall.Areas.Admin.ViewModels
{
    public class DashboardIndexViewModel
    {
        public int CategoryCount { get; set; }
        public int PostCount { get; set; }
        public int userCount { get; set; }
        public int CommentCount { get; set; }
       

    }
}