<%@ Page Title="" Language="C#" MasterPageFile="~/Web/User/Site2.Master" AutoEventWireup="true" CodeBehind="My_TO.aspx.cs" Inherits="WebApplication3.Web.User.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

	<!--services-->
	<div class="services">
		<div class="container">
			<h3 class="title">我创建</h3>
			<div class="row services-info">	
                <%-- 用户自己创建的社团 --%>
                <%
                    foreach (WebApplication3.Model.Team_Organizations prod in  myTeam_Organizations()) {
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
 
			<%-- 用户自己创建的社团 --%>
	
				<div class="clearfix"> </div>
			</div>
            <div style="width:100%">
                <hr style="color:blueviolet; width:100% "  />
            </div>
            <%-- lyg --%>
            <h3 class="title">我加入</h3>
            			<div class="row services-info">			
				                <%
                    foreach (WebApplication3.Model.Team_Organizations prod in  JoinTeam_Organizations()) {
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
            <%-- lyg --%>
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
