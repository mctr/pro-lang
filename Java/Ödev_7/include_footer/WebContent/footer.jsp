<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>

<%@ page import="java.util.Date" %>
<%!
private int accessCount = 0;
private Date accessDate = new Date();
private String accessHost = "<I>No previous access</I>";
%>
<P>
<HR>
 &copy; 2013
Author :<A HREF="http//mctr.github.com/">Mesut Çittir</A>.
Giriş sayısı <%= ++accessCount %>
<% accessDate = new Date(); %><%= accessDate %>