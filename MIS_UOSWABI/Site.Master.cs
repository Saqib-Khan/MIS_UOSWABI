﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace MIS_UOSWABI
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var ctx = new MISUOSWABIContext())
            {
                var student = new Student() { StudentName = "Bill" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}