﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GetPostMethodsExample
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("page load....");
            if(Request.Form["FirstName"] =="ilyas")
            {
                Response.Write("we have got ilyas as input");
            }
        }
    }
}