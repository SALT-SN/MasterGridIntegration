<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowLM.aspx.cs" Inherits="WebPortalAdmin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="lmid" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" />
                <asp:BoundField DataField="lmid" HeaderText="lmid" SortExpression="lmid" InsertVisible="False" ReadOnly="True" />
                <asp:BoundField DataField="lmname" HeaderText="lmname" SortExpression="lmname" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:learnSystemDevConnectionString %>" SelectCommand="SELECT Category.cname, LM.lmid, LM.lmname FROM Category INNER JOIN LM ON Category.cid = LM.cid"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
