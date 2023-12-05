<%@ Page Title="Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <br />
    <br />

    <style>
       
        h2{
            font-size:33px;
        }

        header .btn {

           margin-right: 8px;
           box-shadow: 0px 2px 5px 1px #000000;
        }

        div .btn{
            color: black
        }

        div .txtbox:hover {

            color: darkgreen
        }

       
    </style>

    <header>


    </header>


    <asp:TextBox ID="TextBox1" runat="server" style="width:148px; font-size:20px; height: 45px; box-shadow: 0px 1px 3px 1px #000000;"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="delete" runat="server" Text="DEL" OnClick="delete_Click" class="btn" style="font-size:10px; padding-left:6px; width:34px; height:34px; text-align:center; background-color:lightpink" />
    <asp:Button ID="geteilt" runat="server" Text="/" OnClick="geteilt_Click" class="btn" style="width:34px; background-color:antiquewhite"/>
    <asp:Button ID="mal" runat="server" Text="*" OnClick="mal_Click" class="btn" style="width:34px; background-color:antiquewhite"/>
    <asp:Button ID="minus" runat="server" Text="-" OnClick="minus_Click" class="btn" style="width:34px; background-color:antiquewhite"/>
    <br />
     <br />
    <asp:Button ID="btn7" runat="server" Text="7" OnClick="btn7_Click" class="btn"/>
    <asp:Button ID="btn8" runat="server" Text="8" OnClick="btn8_Click" class="btn"/>
    <asp:Button ID="btn9" runat="server" Text="9" OnClick="btn9_Click" class="btn"/>
    <asp:Button ID="plus" runat="server" Text="+" OnClick="plus_Click" class="btn" style="background-color:antiquewhite"/>
    <br />
     <br />
    <asp:Button ID="btn4" runat="server" Text="4" OnClick="btn4_Click" class="btn"/>
    <asp:Button ID="btn5" runat="server" Text="5" OnClick="btn5_Click" class="btn"/>
    <asp:Button ID="btn6" runat="server" Text="6" OnClick="btn6_Click" class="btn"/>
    <asp:Button ID="backslash" runat="server" Text="back" OnClick="backslash_Click" class="btn" style="width:34px; padding-left:6px; font-size:10px; height:34px; background-color: lightpink;"/>
    <br />
     <br />
    <asp:Button ID="btn1" runat="server" Text="1" OnClick="btn1_Click" class="btn"/>
    <asp:Button ID="btn2" runat="server" Text="2" OnClick="btn2_Click" class="btn"/>
    <asp:Button ID="btn3" runat="server" Text="3" OnClick="btn3_Click" class="btn"/>
    <asp:Button ID="enter" runat="server" Text="=" OnClick="enter_Click" class="btn" style="background-color:lightblue"/>
    <br />
     <br />
    <asp:Button ID="btn0" runat="server" Text="0" OnClick="btn0_Click" class="btn" style="width: 110px"/>
    <asp:Button ID="punkt" runat="server" Text="." OnClick="punkt_Click" class="btn" style="width:34px"/>
  

</asp:Content>
