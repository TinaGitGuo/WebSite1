<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationWebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <form id="form1" runat="server">
    <div>
    <input type="text" value="" />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <div>total: 55 ,pages:</div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource3">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:TemplateField>
                    <EditItemTemplate><h1>我喜欢</h1> <% %> </EditItemTemplate>

                </asp:TemplateField>
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="ArticleTypeName" HeaderText="ArticleTypeName" SortExpression="ArticleTypeName" />
                <asp:BoundField DataField="ArticleTypeId" HeaderText="ArticleTypeId" SortExpression="ArticleTypeId" />
                <asp:BoundField DataField="Contents" HeaderText="Contents" SortExpression="Contents" />
                <asp:BoundField DataField="ImagesAddr" HeaderText="ImagesAddr" SortExpression="ImagesAddr" />
                <asp:BoundField DataField="ReadTimes" HeaderText="ReadTimes" SortExpression="ReadTimes" />
                <asp:BoundField DataField="CommentTimes" HeaderText="CommentTimes" SortExpression="CommentTimes" />
                <asp:BoundField DataField="ReleaseTime" HeaderText="ReleaseTime" SortExpression="ReleaseTime" />
                <asp:BoundField DataField="CommentContents" HeaderText="CommentContents" SortExpression="CommentContents" />
                <asp:BoundField DataField="DelFlag" HeaderText="DelFlag" SortExpression="DelFlag" />
                <asp:BoundField DataField="UsersId" HeaderText="UsersId" SortExpression="UsersId" />
                <asp:BoundField DataField="IsRecommend" HeaderText="IsRecommend" SortExpression="IsRecommend" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TinaBlogConnectionString %>" SelectCommand="SELECT * FROM [Articles]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server">
        </asp:EntityDataSource>
    </div>
        <asp:CheckBox ID="CheckBox1" runat="server" />
    </form>
            </ContentTemplate>
        </asp:UpdatePanel>
</body>
</html>
