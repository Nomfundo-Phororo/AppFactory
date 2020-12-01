using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppFactoryTrial
{
    public partial class ViewUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InvolvingDB involvingDB = new InvolvingDB();
           



            involvingDB.GetAllfromDB(ref Person);

        }

    }
}