<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication3.Web.User.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../../Content/style.css" rel="stylesheet" />
</head>
<body>

<div class="login-container">
	<h1>登陆</h1>
	
	<div class="connect">
		<p>让青春和我们一起(｡･∀･)ﾉﾞ嗨！</p>
	</div>
	
	<form action="" method="post" id="loginForm" runat="server">
		<div>
            <asp:TextBox ID="Username" runat="server" placeholder="电话号码" autocomplete="off"></asp:TextBox>
			
		</div>
		<div>
            <asp:TextBox ID="Password" runat="server" placeholder="密码" ></asp:TextBox>

		</div>

        <asp:Button ID="submit" runat="server" Text="登 陆" Width="300" OnClick="submit_Click" />
	</form>

	<a href="register.aspx">
		<button type="button" class="register-tis">还有没有账号？</button>
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
