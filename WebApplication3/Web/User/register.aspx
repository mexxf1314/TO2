<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication3.Web.User.Addcount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>注册</title>
    <link href="../../Content/style.css" rel="stylesheet" />
</head>
<body>

<div class="register-container">
	<h1>注册</h1>
	
	<div class="connect">
		<p>连接你我他.</p>
	</div>
	
	<form id="form1" method="post"  runat="server">
		<div>
            
            <asp:TextBox ID="username" runat="server" placeholder="输入用户名"></asp:TextBox>
		</div>
        	<div>
            
            <asp:TextBox ID="school" runat="server" placeholder="输入学校"></asp:TextBox>
		</div>
		<div>
            <asp:TextBox  TextMode="Password" ID="password" runat="server" placeholder="再次输入密码"></asp:TextBox>
<%--			<input type="password" name="password" class="password" placeholder="输入密码" oncontextmenu="return false" onpaste="return false" />--%>
		</div>
		<div>
            <asp:TextBox  TextMode="Password" ID="apassword" runat="server" placeholder="再次输入密码"></asp:TextBox>
<%--			<input type="password" name="confirm_password" class="confirm_password" placeholder="再次输入密码" oncontextmenu="return false" onpaste="return false" />--%>
		</div>
		<div>
            <asp:TextBox  TextMode="Phone" ID="phone" runat="server" placeholder="输入电话号码"></asp:TextBox>
<%--			<input type="text" name="phone_number" class="phone_number" placeholder="输入手机号码" autocomplete="off" id="number"/>--%>
		</div>
		<div>
                <asp:TextBox  TextMode="Email" ID="email" runat="server" placeholder="输入邮箱"></asp:TextBox>
<%--			<input type="email" name="email" class="email" placeholder="输入邮箱地址" oncontextmenu="return false" onpaste="return false" />--%>
		</div>
        <asp:Button ID="submit" runat="server" Text="注 册" Width="300" OnClick="submit_Click" />

	</form>
	<a href="login.aspx">
		<button type="button" class="register-tis">已经有账号？</button>
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
