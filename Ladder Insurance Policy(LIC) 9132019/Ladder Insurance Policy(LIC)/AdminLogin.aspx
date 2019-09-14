<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 342px;
            margin:auto;
            margin-top:30px;
            height: 246px;
        }
        .auto-style7 {
            width: 244px;
        }
        .auto-style8 {
            width: 267px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="user_login" >
        <h1 class="login_head">Admin Login</h1>

        <br />
        <table class="auto-style6">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Text="AdminName"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtUserName" runat="server" Width="232px" placeholder="Username..." Height="27px"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUserName" CssClass="auto-style11" ErrorMessage="UserName Required!" style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtPassword" runat="server" Width="234px" Height="27px" placeholder="Password..."></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword" CssClass="auto-style10" ErrorMessage="Password Required!" style="color: #FF0000"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <em>
                    <asp:HyperLink ID="HyperLink2" runat="server" Width="128%" CssClass="auto-style9" NavigateUrl="~/Home.aspx" style="color: #0066FF">Forget Password</asp:HyperLink>
                    </em>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="Button2" CssClass="login_button" runat="server" Text="Button" />
                </td>
              
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">
                    <em>
                    <asp:HyperLink ID="HyperLink1" runat="server" Width="128%" CssClass="auto-style9" NavigateUrl="~/AdminRegistration.aspx" style="color: #0066FF">New Use Register Here!!!</asp:HyperLink>
                    </em>
                </td>
              
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
              
            </tr>
        </table>

    </div>
</asp:Content>

