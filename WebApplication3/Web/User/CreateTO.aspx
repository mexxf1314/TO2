<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateTO.aspx.cs" Inherits="WebApplication3.Web.User.CreateTO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>创建社团</title>
    <link href="../../Content/style.css" rel="stylesheet" />
</head>
<body>

<div class="register-container">
	<h1>创建社团</h1>
	
	<div class="connect">
		<p>连接你我他.</p>
	</div>
	
	<form id="form1" method="post"  runat="server">
		<div>
            <asp:TextBox ID="teamname" runat="server" placeholder="输入社团名"></asp:TextBox>
		</div>
		<div>
            <asp:TextBox  ID="cologename" runat="server" placeholder="所在大学"></asp:TextBox>
		</div>
		<div>
            <asp:TextBox   ID="cologenumber" runat="server" placeholder="输入你的学号"></asp:TextBox>
		</div>
		<div>
            <asp:TextBox  TextMode="Phone" ID="phone" runat="server" placeholder="输入电话号码"></asp:TextBox>
		</div>
		<div>
                <asp:TextBox   ID="teaminstraction" runat="server" placeholder="社团介绍"></asp:TextBox>
		</div>
        <asp:Button ID="submit" runat="server" Text="创建" Width="300" OnClick="submit_Click" />

	</form>
    <a href="My_TO.aspx">
		<button type="button" class="register-tis">我的社团</button>
	</a>

</div>

</body>
<script src="http://www.jq22.com/jquery/1.11.1/jquery.min.js"></script>
<script src="../../Scripts/common.js"></script>
<!--背景图片自动更换-->
<script src="../../Scripts/supersized.3.2.7.min.js"></script>
<script src="../../Scripts/supersized-init.js"></script>
<!--表单验证-->
<script src="../../Scripts/jquery.validate.min.js"></script>
</html>
