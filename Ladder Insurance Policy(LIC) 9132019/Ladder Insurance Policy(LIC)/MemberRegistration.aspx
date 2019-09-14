<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MemberRegistration.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

.top-nav {
  background-color: SteelBlue;
  overflow: hidden;
}

        .auto-style8 {
            text-align: left;
            padding: 8px;
            width: 222px;
        }
        .auto-style9 {
            text-align: center;
            height: 39px;
            width: 250px;
        }
        .auto-style10 {
            text-align: left;
            height: 39px;
            padding: 8px;
            width: 222px;
        }
        .auto-style11 {
            height: 39px;
        }
        .auto-style12 {
            color: #FF0000;
        }
        .auto-style13 {
            text-align: center;
            width: 250px;
        }
        .auto-style14 {
            width: 250px;
        }
        .auto-style15 {
            text-align: center;
            width: 250px;
            height: 52px;
        }
        .auto-style16 {
            text-align: left;
            padding: 8px;
            width: 222px;
            height: 52px;
        }
        .auto-style17 {
            height: 52px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <center>
        <div class="auto-style3">

      <!--content here-->



            <br />
            <table class="slide_show">
                <tr>
                    <td class="auto-style13">First Name</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="FirstName" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldFirstName" runat="server" ControlToValidate="FirstName" ErrorMessage="* FirstName is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Last Name</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="LastName" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldLastName" runat="server" ControlToValidate="LastName" ErrorMessage="* LastName is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Age</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="Age" runat="server" CssClass="textbox"></asp:TextBox>
                        <br />
                        <asp:RangeValidator ID="AgeValidator" runat="server" ErrorMessage="*Enter the Valid Age Above 18 years" ForeColor="Red" MaximumValue="100" MinimumValue="18" ControlToValidate="Age" Type="Integer"></asp:RangeValidator>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldAge" runat="server" ControlToValidate="Age" ErrorMessage="* Age is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Gender</td>
                    <td class="auto-style10">
                        <asp:RadioButton ID="RadioButtonMale" runat="server" Text="Male" OnCheckedChanged="RadioButtonMale_CheckedChanged" groupname="Gender" AutoPostBack="True"/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButtonFemale" runat="server" Text="Female" OnCheckedChanged="RadioButtonFemale_CheckedChanged" AutoPostBack="True" GroupName="Gender" />
                    </td>
                    <td class="auto-style11">
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style12"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Date Of Birth</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="DateOfBirth" runat="server" TextMode="Date" CssClass="textbox"></asp:TextBox>
                        <br />
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldAge1" runat="server" ControlToValidate="DateOfBirth" ErrorMessage="* Date Of Birth is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Contact Number</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="ContactNumber" runat="server" AutoPostBack="True" CssClass="textbox" TextMode="Number"></asp:TextBox>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="ContactNumber" ErrorMessage="* Should be from 0 to 9 10digit" ForeColor="Red" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldContactNumber" runat="server" ControlToValidate="ContactNumber" ErrorMessage="* ContactNumber is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Alt Contact Number</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="AltContactNumber" runat="server" CssClass="textbox" TextMode="Number"></asp:TextBox>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="AltContactNumber" ErrorMessage="* Should be from 0 to 9 10digit" ForeColor="Red" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldAltContactNumber" runat="server" ControlToValidate="AltContactNumber" ErrorMessage="* Alt Contact Number is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Email ID</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="EmailId" runat="server" CssClass="textbox" TextMode="Email"></asp:TextBox>
                        <br />
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldEmailId" runat="server" ControlToValidate="EmailId" ErrorMessage="* Email Id is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">Password</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="textbox"></asp:TextBox>
                        <br />
                        
                    </td>
                    <td class="auto-style17">
                        <asp:RequiredFieldValidator ID="RequiredFieldPassword" runat="server" ControlToValidate="Password" ErrorMessage="* Password is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="Password" ErrorMessage="*password should be minimum 8 characters with atleast one alphabet, number and special character " ForeColor="Red" ValidationExpression="[a-zA-Z0-9'@&amp;#.\s]{8,}"></asp:RegularExpressionValidator></td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">Re Type Password</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="ReTypePassword" runat="server" TextMode="Password" CssClass="textbox"></asp:TextBox>
                        <br />
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Password" ControlToValidate="ReTypePassword" ErrorMessage="*Password Had Not Matched" ForeColor="Red"></asp:CompareValidator>
                        <br />
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Password" ErrorMessage="* Password is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style14">Address Line 1</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="AddressLine1" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldAddressLine1" runat="server" ControlToValidate="AddressLine1" ErrorMessage="* Address Line1 is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">Address Line 2</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="AddressLine2" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldAddressLine2" runat="server" ControlToValidate="AddressLine2" ErrorMessage="* Address Line 2  is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">State</td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="StateList" runat="server" Height="16px" Width="149px" AutoPostBack="True" OnSelectedIndexChanged="StateList_SelectedIndexChanged1">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:CustomValidator ID="CityValidator" runat="server" ControlToValidate="StateList" ErrorMessage="*City is Mandatory" ForeColor="Red"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">City</td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="CityList" runat="server" Height="16px" Width="148px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldState" runat="server" ControlToValidate="CityList" ErrorMessage="*State is Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">ZipCode</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="ZipCode" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldZipCode" runat="server" ControlToValidate="ZipCode" ErrorMessage="* Zip Code is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <br />
            <asp:CheckBox ID="Terms" runat="server" AutoPostBack="True"  Text="Given details are correct upto my knowledge" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Button ID="Button1" runat="server"  Text="Submit" OnClick="Button1_Click" CssClass="register-button" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="register-button" />
        </div>
    </center>
    <p>
    </p>
</asp:Content>

