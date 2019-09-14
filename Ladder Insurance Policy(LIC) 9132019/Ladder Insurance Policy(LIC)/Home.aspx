<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <div class="slide_show" >
       <asp:Image CssClass="mySlides" ID="Image1" runat="server" ImageUrl="~/Image/slide1.jpg" />
       <asp:Image CssClass="mySlides" ID="Image2" runat="server" ImageUrl="~/Image/slide2.jpg" />
       <asp:Image CssClass="mySlides" ID="Image3" runat="server" ImageUrl="~/Image/slide3.jpg" />
       <asp:Image  CssClass="mySlides" ID="Image4" runat="server" ImageUrl="~/Image/slide4.jpg" />
</div>

   <%-- style="max-width:500px"--%>
 
    <div class="body_container">

        <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl="~/Login.aspx">

            <div class="plan_content">
         <h1>Plan 1</h1>
         <p> this paragraph contain description of plan </p>
         <h3>Coverage</h3>
         
     </div>

        </asp:HyperLink>
     


     <div class="plan_content">
         <h1>Plan 2</h1>
         <p> this paragraph contain description of plan </p>
         <h3>Coverage</h3>
         
     </div>
 </div>

    
<script src="script/Script.js"></script>


</asp:Content>

