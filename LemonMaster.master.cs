using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LemonMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] != null){}
        else
            Response.Redirect("~/view/Login.aspx");

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session["user_id"] = null;
        Session["nombre"] = null;

        DAO_User user = new DAO_User();
        EUsuario datos = new EUsuario();
        datos.Session = Session.SessionID;
        user.cerrarSession(datos);

        Response.Redirect("~/view/Login.aspx");
    }
    protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
}
