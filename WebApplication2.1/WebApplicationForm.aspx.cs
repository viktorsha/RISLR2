using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2._1
{
    public partial class WebApplicationForm : System.Web.UI.Page
    {
        WebService1 ws = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = inputField.Text;
                string result = ws.ReturnXml(filename);
                TextBox1.Text = result;
            }
            catch(Exception e1)
            {
                TextBox1.Text = e1.Message;
            }
        }
    }
}