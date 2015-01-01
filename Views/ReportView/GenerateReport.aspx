<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>GenerateReport</title>
</head>
<body>
    <div>
        <% using (Html.BeginForm())
           { %>
           <p>Param 1 : </p><input type="text" name="param1"/>
            <br/>
           <p>Param 2 : </p><input type="number" name="param2"/>
            <br/>
        <button type="submit">Submit!</button>
        <% } %>
        <% if (ViewBag.ShowIFrame)
           { %>
        <iframe src='<%= Url.Content("~/OldSkoolAspx/ReportViewer.aspx") %>' width="100%" height="450px"></iframe>
        <% } %>
    </div>
</body>
</html>
