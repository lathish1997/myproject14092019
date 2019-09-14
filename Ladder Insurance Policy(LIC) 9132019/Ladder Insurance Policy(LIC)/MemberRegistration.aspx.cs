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
        if(!IsPostBack)
        {
            List<string> state = new List<string>();
            state.Add("Select-State");
            state.Add("Andhra Pradesh");
            state.Add("Tamilnadu");
            state.Add("Telengana");
            state.Add("Karnataka");
            StateList.DataSource = state;
            StateList.DataBind();
        }
    }

    protected void RadioButtonMale_CheckedChanged(object sender, EventArgs e)
    {
        if(RadioButtonMale.Checked==true)
        {
            RadioButtonFemale.Checked = false;
        }
    }

    protected void RadioButtonFemale_CheckedChanged(object sender, EventArgs e)
    {
        if(RadioButtonFemale.Checked==true)
        {
            RadioButtonMale.Checked = false;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(RadioButtonMale.Checked==false && RadioButtonFemale.Checked==false)
        {
            Label1.Text = "*Gender is Mandetory";
        }
        if(Terms.Checked==true)
        {
            Label2.Text = "*Agree the terms ";
        }
        Member member = new Member();
        member.FirstName = FirstName.Text;
        member.LastName = LastName.Text;
        member.Age = int.Parse(Age.Text);
            if (RadioButtonMale.Checked == true)
        {
            RadioButtonFemale.Checked = false;
            member.Gender =  "male";
        }
        else
        {
            RadioButtonFemale.Checked = true;
            member.Gender = "female";
        }
        member.Dob = DateTime.Parse(DateOfBirth.Text);
        member.ContactNumber = int.Parse(ContactNumber.Text);
        member.AltContactNumber = int.Parse(AltContactNumber.Text);
        member.EmailId = EmailId.Text;
        member.Password = Password.Text;
        member.AddressLine1 = AddressLine1.Text;
        member.AddressLine2 = AddressLine2.Text;
        member.State = StateList.SelectedItem.Text;
        member.City = CityList.SelectedItem.Text;
        member.ZipCode = ZipCode.Text;
        member.Active = "Processing";
        MemberDao register = new MemberDao();
        int num = register.RegisterMember(member);
        if(num==1)
        {
            Response.Write("<script>alert('Registered Sucessfully');</script>");
            Response.Redirect("#");
        }
        else
        {
            Response.Write("<script>alert('Not Registered');</script>");
            Response.Redirect("MemberRegistration.aspx");
        }
        

    }

    


    protected void StateList_SelectedIndexChanged1(object sender, EventArgs e)
    {

        List<string> city = new List<string>();

        if (StateList.SelectedItem.Text == "Andhra Pradesh")
        {
            city.Add("Nellore");
            city.Add("Tirupathi");
            city.Add("Srikalahasthi");
            city.Add("Gundur");
            city.Add("Vijayawada");
            city.Add("Vizag");
            city.Add("Srikakulam");
            city.Add("Chitoor");
            city.Add("Renigunta");
            city.Sort();
            CityList.DataSource = city;
            CityList.DataBind();
            city.Clear();
        }
        else if (StateList.SelectedItem.Text == "Tamilnadu")
        {
            city.Add("Chennai");
            city.Add("Coimbatore");
            city.Add("Madurai");
            city.Add("Tiruchirapalli");
            city.Add("Tiruppur");
            city.Add("Salem");
            city.Add("Erode");
            city.Add("Tirunelveli");
            city.Add("karavaipettai");
            city.Sort();
            CityList.DataSource = city;
            CityList.DataBind();
            city.Clear();
        }
        else if (StateList.SelectedItem.Text == "Telengana")
        {
            city.Add("Hyderabad");
            city.Add("Warangal");
            city.Add("Adilabad");
            city.Add("Karimnagar");
            city.Add("Khammam");
            city.Add("Nalgonda");
            city.Add("Nizamabad");
            city.Sort();
            CityList.DataSource = city;
            CityList.DataBind();
            city.Clear();
        }
        else if (StateList.SelectedItem.Text == "Karnataka")
        {
            city.Add("Mangalore");
            city.Add("Bangalore");
            city.Add("Belgaum");
            city.Add("Mysore");
            city.Add("Bijapur");
            city.Add("Bellary");
            city.Add("Devanagare");
            city.Add("Shimoga");
            city.Add("Gulburga");
            city.Sort();
            CityList.DataSource = city;
            CityList.DataBind();
            city.Clear();
        }
    }
}