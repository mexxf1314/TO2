<%@ Page Title="" Language="C#" MasterPageFile="~/Web/User/Site1.Master" AutoEventWireup="true" CodeBehind="School_TO.aspx.cs" Inherits="WebApplication3.Web.User.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
         <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- //Custom Theme files -->
        <link href="../../Content/chocolat.css" rel="stylesheet" />
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
    <link href="../../Content/meaue.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.1.1.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>

<!-- start-smoth-scrolling-->
    <script src="../../Scripts/move-top.js"></script>
    <script src="../../Scripts/easing.js"></script>
<script type="text/javascript">
		jQuery(document).ready(function($) {
			$(".scroll").click(function(event){		
				event.preventDefault();
		
		$('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
			});
		});
</script>
<!--//end-smoth-scrolling-->
        	<!--services-->
	<div class="services">
		<div class="container">
			<h3 class="title">本校社团</h3>

			<div class="row services-info">	
                <%-- 用户自己创建的社团 --%>
                <%
                    foreach (WebApplication3.Model.Team_Organizations prod in  School_Organizations()) {
                        Response.Write("<a href='"+prod.TO_Image+"'>");
                        Response.Write("<div class='col-sm-6 col-md-4 services-grids'>");
                        Response.Write("<div class='thumbnail'>");
                        Response.Write("<div class='moments-bottom'>");
                        Response.Write("<img src='../../images/Imuser/img12.jpg' class='img-responsive zoom-img ' />");
                        Response.Write("</div>");
                        Response.Write("<div class='caption services-caption'>");
                        Response.Write("<h4><a href='single.html'>"+prod.TO_Name+"</a></h4>");
                        Response.Write("<p>Cras justo odioda pibus facilisis dignissimos voluptatem accusantium</p>	");
                        Response.Write("</div></div></div>");
                    };
                     %>
				<div class="clearfix"> </div>
			</div>

			<!--light-box-js -->
				<script src="js/jquery.chocolat.js"></script>
				<!--light-box-files -->
				<script type="text/javascript">
				$(function() {
					$('.moments-bottom a').Chocolat();
				});
				</script> 
			<!--//end-gallery js-->
		</div>
	</div>	
	<!--contact-->
    </div>
</asp:Content>
