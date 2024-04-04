using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_FORM
{
    public partial class Patient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string FName = TxtLname.Text;
            string Mname = TxtMname.Text;
            string Lname = TxtLname.Text;
            string Dob = dob.Value.ToString();
            string Gender = ddlgender.SelectedItem.Text;
            string Mobile = txtmobile.Text;   

            string Year = ddlyear.SelectedItem.Text;
            string Country = ddlcountry.SelectedItem.Text;
            string State = ddlstate.SelectedItem.Text;
            string City = ddlcity.SelectedItem.Text;

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            TxtLname.Text = string.Empty;
            TxtMname.Text = string.Empty;
            TxtLname.Text = string.Empty;
            dob.Value = string.Empty;

        }
    }
}