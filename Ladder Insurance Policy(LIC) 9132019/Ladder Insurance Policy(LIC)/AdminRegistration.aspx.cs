using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClaimsDataLayer;
using ClaimsBusinessLayer;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void rdMale_CheckedChanged(object sender, EventArgs e)
    {
        if(rdMale.Checked==true)
        {
            rdFemale.Checked = false;
        }
    }

    protected void rdFemale_CheckedChanged(object sender, EventArgs e)
    {
        if(rdFemale.Checked==true)
        {
            rdMale.Checked = false;
        }
    }

    protected void btnAdminSignup_Click(object sender, EventArgs e)
    {
        if(rdMale.Checked == false && rdFemale.Checked == false)
        {
            Gender.Text = "*gender is mandatory";
        }
        Admin admin = new Admin();
        admin.FirstName = txtFirstName.Text;
        admin.LastName = txtLastName.Text;
        admin.Age = int.Parse(txtAge.Text);
        admin.Dob = DateTime.Parse(txtDob.Text);
        if(rdMale.Checked==true)
        {
            admin.Gender = "Male";
        }
        else if(rdFemale.Checked==true)
        {
            admin.Gender = "Female";
        }
        admin.ContactNumber = Int64.Parse(txtContactNumber.Text);
        admin.AltContactNumber = Int64.Parse(txtAltContactNumber.Text);
        admin.EmailId = txtEmail.Text;
        admin.Password = txtPassword.Text;
        admin.Active = "Processing";
        AdminDao adminDao = new AdminDao();
       
        int num = adminDao.RegisterAdmin(admin);
        if (num == 1)
        {
            Response.Write("<script>alert('Registered Sucessfully');</script>");
            Response.Redirect("#");
        }
        else
        {
            Response.Write("<script>alert('Not Registered');</script>");
            Response.Redirect("AdminRegistration.aspx");
        }

    }
}