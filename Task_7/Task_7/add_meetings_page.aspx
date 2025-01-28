<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_meetings_page.aspx.cs" Inherits="Task_7.add_meetings_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Schedual Meetings</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="ms-2">
            <h4 style="margin-bottom: 20px">Add A Book</h4>
            <label>Room ID</label>
            <asp:TextBox ID="roomId" runat="server" Width="99%" />
            <br />
            <br />
            <label>Room Name</label>
            <asp:TextBox ID="roomName" runat="server" Width="99%" />
            <br />
            <br />
            <label>Room Location</label>
            <asp:TextBox ID="roomLocation" runat="server" Width="99%" />
            <br />
            <br />
            <label>Room Capacity</label>
            <asp:TextBox ID="roomCapacity" runat="server" Width="99%" />
            <br />
            <br />
            <asp:Button runat="server" ID="addMeeting" Text="Add Book" OnClick="addMeeting_Click" />
            <asp:Label runat="server" ID="massege" Visible="false" Style="color: red; font-size: 12px"></asp:Label>
            <asp:Label runat="server" ID="success_massege" Visible="false" Style="color: green; font-size: 12px"></asp:Label>
        </div>
    </form>
</body>
</html>
