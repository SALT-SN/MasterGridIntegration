<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowTestResult.aspx.cs" Inherits="WebPortalAdmin.ShowTestResult" %>

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
                <asp:BoundField DataField="uid" HeaderText="uid" SortExpression="uid" />
                <asp:BoundField DataField="qid" HeaderText="qid" SortExpression="qid" />
                <asp:BoundField DataField="score" HeaderText="score" SortExpression="score" />
                <asp:BoundField DataField="sid" HeaderText="sid" SortExpression="sid" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:learnSystemDevConnectionString %>" SelectCommand="SELECT uid, qid, score, date AS sid FROM TestResult"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
