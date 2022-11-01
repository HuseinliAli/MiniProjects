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
            DataSetHoddleTableAdapters.HeadersTableAdapter dtHeader = new DataSetHoddleTableAdapters.HeadersTableAdapter();
            RepeaterHeader.DataSource = dtHeader.GetHeadersData();
            RepeaterHeader.DataBind();


            DataSetHoddleTableAdapters.ContactsTableAdapter dtContact = new DataSetHoddleTableAdapters.ContactsTableAdapter();
            RepeaterContact.DataSource = dtContact.GetContactsData();
            RepeaterContact.DataBind();


            DataSetHoddleTableAdapters.PostsTableAdapter dtPost = new DataSetHoddleTableAdapters.PostsTableAdapter();
            RepeaterPost.DataSource = dtPost.GetPostsData();
            RepeaterPost.DataBind();

            DataSetHoddleTableAdapters.IconsTableAdapter dtIcon = new DataSetHoddleTableAdapters.IconsTableAdapter();
            RepeaterIcon.DataSource = dtIcon.GetIconsData();
            RepeaterIcon.DataBind();

            
        }
    }
}