using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class display : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label label = (Label)PreviousPage.FindControl("Label1");
        Label1.Text = label.Text;
    }
}