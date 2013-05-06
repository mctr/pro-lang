<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Hız Hesaplama</title>
</head>
<body>
<%@ page errorPage="/WEB-INF/hizhatasi.jsp" %>
<TABLE BORDER=5 ALIGN="CENTER">
<TR><TH>
Computing Speed</TABLE>
<%!
	private double toDouble(String value) {
		return(Double.parseDouble(value));
	}
%>
<%
	double furlongs = toDouble(request.getParameter("furlongs"));
	double fortnights = toDouble(request.getParameter("fortnights"));
	double speed = furlongs / fortnights;
%>
<UL>
<LI>Distance: <%= furlongs %> furlongs.
<LI>Time: <%= fortnights %> fortnights.
<LI>Speed: <%= speed %> furlongs per fortnight.
</UL>
</body>
</html>