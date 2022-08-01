using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace AspNetProject1
{


    public partial class WebForm1 : System.Web.UI.Page
    {
        private static void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Script.Services.ScriptMethod()]
        [WebMethod]
        public static string AuthenticateUSer(string username, string password)
        {
            var dt = new Opperations().Authentication(username, password);
            if (dt.Rows.Count ==1)
            {
                string user = (string)dt.Rows[0][0];
                HttpContext.Current.Session["user"] =user;
                string type =(string) dt.Rows[0][5];
                if (type == "admin")
                {
                    HttpContext.Current.Session["type"] = "admin";
                    return "admin";
                }
                if (type == "accountant")
                {
                    HttpContext.Current.Session["type"] = "accountant";
                    return "accountant";
                }
            }

            return "not authenticated";
        }
    }
}