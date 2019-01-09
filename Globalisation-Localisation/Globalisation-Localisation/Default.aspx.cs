using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Threading;

namespace Globalisation_Localisation
{
    public partial class Default : System.Web.UI.Page
    {
        protected override void InitializeCulture()
        {
            //base.InitializeCulture();
            string language = "en-us";

            //Detect User's Language.
            if (Request.UserLanguages != null)
            {
                //Set the Language.
                language = Request.UserLanguages[0];
            }

            //Check if PostBack is caused by Language DropDownList.
            if (Request.Form["__EVENTTARGET"] != null && Request.Form["__EVENTTARGET"].Contains("ddlLanguages"))
            {
                //Set the Language.
                language = Request.Form[Request.Form["__EVENTTARGET"]];
            }

            //Set the Culture.
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}