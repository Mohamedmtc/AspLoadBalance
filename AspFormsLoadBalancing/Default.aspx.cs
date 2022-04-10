using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspFormsLoadBalancing
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if((System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                Session["SharedValue"] = System.Web.HttpContext.Current.User.Identity.Name + DateTime.Now.ToString();
            }
            else
            {
                Session["SharedValue"] = Request.LogonUserIdentity.Name + DateTime.Now.ToString();
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(Session["SharedValue"]!=null)
            Label1.Text="Session Value : " + Session["SharedValue"].ToString();
        }
    }
}