<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 76%;
            height: 361px;
           margin:auto;
        }
        .auto-style7 {
            width: 84px;
        }
        .auto-style8 {
            width: 130px;
        }
    .auto-style9 {
        text-decoration: underline;
        color: #0066FF;
    }
    .auto-style10 {
        color: #FF0000;
    }
    .auto-style11 {
        color: #FF3300;
        font-size:medium;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="user_login" >
        <h1 class="login_head">User Login</h1>

        <br />
        <table class="auto-style6">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtUserName" CssClass="textbox" runat="server" Width="232px" placeholder="Username..." Height="27px"></asp:TextBox>
                    <br />
                    <br />
                    
                </td>
                
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUserName" CssClass="auto-style11" ErrorMessage="UserName Required!"></asp:RequiredFieldValidator>
                    
                </td>
                
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtPassword" CssClass="textbox" runat="server" Width="234px" Height="27px" placeholder="Password..."></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword" CssClass="auto-style10" ErrorMessage="Password Required!"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLink2" runat="server" Width="128%" CssClass="auto-style9" NavigateUrl="~/Home.aspx">Forget Password</asp:HyperLink>
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
                    <asp:HyperLink ID="HyperLink1" runat="server" Width="128%" CssClass="auto-style9" NavigateUrl="~/MemberRegistration.aspx">New Use Register Here!!!</asp:HyperLink>
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

