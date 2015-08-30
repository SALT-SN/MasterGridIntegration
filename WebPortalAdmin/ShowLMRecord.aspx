<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowLMRecord.aspx.cs" Inherits="WebPortalAdmin.ShowLMRecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="lmid" HeaderText="lmid" SortExpression="lmid" />
                <asp:BoundField DataField="sid" HeaderText="sid" SortExpression="sid" />
                <asp:BoundField DataField="gid" HeaderText="gid" SortExpression="gid" />
                <asp:BoundField DataField="uid" HeaderText="uid" SortExpression="uid" />
                <asp:BoundField DataField="recdate" HeaderText="recdate" SortExpression="recdate" />
                <asp:BoundField DataField="ifsucceed" HeaderText="ifsucceed" SortExpression="ifsucceed" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:learnSystemDevConnectionString %>" SelectCommand="SELECT lmid, sid, gid, uid, recdate, ifsucceed FROM LMRecord"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
