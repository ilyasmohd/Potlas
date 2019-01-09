using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tracing_Example
{
    public partial class Default : System.Web.UI.Page
    {
        //https://odetocode.com/articles/242.aspx
        // https://www.c-sharpcorner.com/UploadFile/225740/introduction-to-tracing/
        //https://www.codeproject.com/Articles/82290/%2FArticles%2F82290%2FStep-by-Step-Guide-to-Trace-the-ASP-NET-Applicatio
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Write("my trace entry");
        }
    }
}