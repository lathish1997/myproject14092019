<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminRegistration.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style7 {
            width: 410px;
        }
        .auto-style8 {
            width: 410px;
            text-align: center;
        }
        .auto-style9 {
            width: 494px;
            height: 23px;
            text-align: right;
        }
        .auto-style10 {
            width: 410px;
            height: 23px;
        }
        .auto-style11 {
            height: 23px;
        }
        .auto-style13 {
            font-size: xx-large;
        }
        .auto-style14 {
            width: 494px;
            text-align: right;
        }
        .auto-style15 {
            width: 410px;
            height: 23px;
            text-align: center;
        }
    .auto-style16 {
        text-align: justify;
    }
        .auto-style17 {
            width: 494px;
        }
        .auto-style18 {
            text-align: center;
        }
        .auto-style19 {
            height: 23px;
            text-align: center;
        }
    .auto-style20 {
        width: 494px;
        text-align: right;
        height: 25px;
    }
    .auto-style21 {
        width: 410px;
        text-align: center;
        height: 25px;
    }
    .auto-style22 {
        height: 25px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="reg_content">
       <div class="auto-style16">
           <span class="auto-style13">
           <br />
           <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Admin Registration</span><br />
           <br />
           <br />
           <br />
       </div>
    <table class="slide_show">
        <tr>
            <td class="auto-style14">First Name </td>
            <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtFirstName" placeholder="First Name" runat="server" CssClass="textbox" Width="235px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style18">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtFirstName">First Name Cannot be empty</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">Last Name</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtLastName" placeholder="Last Name" runat="server" CssClass="textbox" Width="235px"></asp:TextBox>
            </td>
            <td class="auto-style18">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="RequiredFieldValidator">Last Name Cannot Be empty</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">Age</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtAge" placeholder="Age" runat="server" CssClass="textbox" Width="235px"></asp:TextBox>
            </td>
            <td class="auto-style18">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAge" ErrorMessage="RequiredFieldValidator">Age Cannot be empty</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style8">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="RegularExpressionValidator" ValidationExpression="[0-9]{1,}">Age should be a number</asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">Date Of Birth</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtDob" runat="server" CssClass="textbox" TextMode="Date" Width="235px"></asp:TextBox>
            </td>
            <td class="auto-style18">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtDob" ErrorMessage="RequiredFieldValidator">Dob cannot be empty</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">Gender</td>
            <td class="auto-style8">
                <asp:RadioButton ID="rdMale" runat="server" AutoPostBack="True" Text="Male" OnCheckedChanged="rdMale_CheckedChanged" />
                <asp:RadioButton ID="rdFemale" runat="server" AutoPostBack="True" Text="Female" OnCheckedChanged="rdFemale_CheckedChanged" />
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Gender" runat="server"></asp:Label>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;Contact Number</td>
            <td class="auto-style15">
                <asp:TextBox ID="txtContactNumber" placeholder="Alternate Contact Number" runat="server" CssClass="textbox" TextMode="Number" Width="235px"></asp:TextBox>
            </td>
            <td class="auto-style19">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtContactNumber" ErrorMessage="RequiredFieldValidator">Contact Number cannot be empty</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style15">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtContactNumber" ErrorMessage="RegularExpressionValidator" ValidationExpression="[0-9]{10}">Contact should be 10 digit number</asp:RegularExpressionValidator>
            </td>
            <td class="auto-style11">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">Email Id</td>
            <td class="auto-style15">
                <asp:TextBox ID="txtEmail" placeholder="Email Id" runat="server" CssClass="textbox" Width="235px"></asp:TextBox>
            </td>
            <td class="auto-style19">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ErrorMessage="RequiredFieldValidator">Email Id cannot be empty</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style15">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="RegularExpressionValidator" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$">Incorrect email format</asp:RegularExpressionValidator>
            </td>
            <td class="auto-style11">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">Alternate Contact Number</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtAltContactNumber" placeholder="Contact Number" runat="server" TextMode="Number" CssClass="textbox" Width="235px"></asp:TextBox>
            </td>
            <td class="auto-style18">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">Password</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtPassword" placeholder="Password" runat="server" TextMode="Password" CssClass="textbox" Width="235px"></asp:TextBox>
            </td>
            <td class="auto-style18">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPassword" ErrorMessage="RequiredFieldValidator">Password cannot be empty</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style8">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtPassword" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z0-9'@&amp;#.\s]{8,}$">password should be minimum 8 characters with atleast one alphabet, number and special character</asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">Confirm Password</td>
            <td class="auto-style21">
                <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="textbox" TextMode="Password" Width="235px"></asp:TextBox>
            </td>
            <td class="auto-style22"></td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style8">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="CompareValidator">Password Mismatch</asp:CompareValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style8">
                <asp:Button ID="btnAdminSignup" runat="server" Text="Register" CssClass="register-button" OnClick="btnAdminSignup_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
       </div>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

