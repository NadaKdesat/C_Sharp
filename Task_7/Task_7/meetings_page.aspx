<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="meetings_page.aspx.cs" Inherits="Task_7.meetings_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>Room Meetings page</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="ms-2">
            <h4 style="text-align:center; margin-bottom: 20px;">All Room Meetings</h4>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">Room ID</th>
                        <th scope="col">Room Name</th>
                        <th scope="col">Room Location</th>
                        <th scope="col">Room Capacity</th>
                    </tr>
                </thead>
                <tbody runat="server" id="meetingsData">
                    
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
