using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HoddleBackend
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.HeadersTableAdapter dtHeader = new DataSetTableAdapters.HeadersTableAdapter();
            RepeaterHeader.DataSource = dtHeader.GetHeadersData();
            RepeaterHeader.DataBind();

            DataSetTableAdapters.ContactsTableAdapter dtContact = new DataSetTableAdapters.ContactsTableAdapter();
            RepeaterContact.DataSource = dtContact.GetContactsData();
            RepeaterContact.DataBind();

            DataSetTableAdapters.IconsTableAdapter dtIcon = new DataSetTableAdapters.IconsTableAdapter();
            RepeaterIcon.DataSource = dtIcon.GetIconsData();
            RepeaterIcon.DataBind();
        }
    }
}