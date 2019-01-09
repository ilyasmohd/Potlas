using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching_Example
{
    public partial class CachingExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
            Cache["myCacheObject"] = "EmployeeID";
            //Label1.Text = Cache["myCacheObject"].ToString();

//Caching is a technique where we can store frequently used data, and web pages are stored temporarily on the local hard 
//disk for later retrieval. This technique improves the access time when multiple users access a web site simultaneously, 
//or a single user accesses a web site multiple times.Caching for web applications can occur on the client(browser caching), 
//on a server between the client and the web server, (proxy caching / reverse proxy caching), and on the 
//web server itself(page caching or data caching)

        }
    }
}