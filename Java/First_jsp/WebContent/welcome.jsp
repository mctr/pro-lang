
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Yönlendirilen Sayfa</title>
</head>
<body>
	<% String username = request.getParameter("user_name"); %>
	<% String password = request.getParameter("password"); %>
	<%if ((username).equals("mctr") || (password).equals("12345")) { %>
		<h1 align="center"> Hosgeldin <%= username %></h1>
	<%} else { %>
		<h1 align="center">Hosgeldin Ama seni Tanimiyorum </h1>
	<%} %>
</body>
</html>