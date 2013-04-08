package com;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.util.*;


/**
 * Servlet implementation class reguestheaders
 */
@WebServlet("/reguestheaders")
public class reguestheaders extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public reguestheaders() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.setCharacterEncoding("UTF-8");
		response.setContentType("text/html");
		String docType = "<!DOCTYPE html>\n";
		PrintWriter out = response.getWriter();
		out.println
		(docType +
		"<HTML>\n" +
		"<HEAD><TITLE>"+ "foo" + "</TITLE></HEAD>\n"+
		"<BODY BGCOLOR=\"#f1f2f3\">\n" +
		"<H1 ALIGN=\"CENTER\">" + "Request Example" + "</H1>\n" +
		"<B>Request Method: </B>" +
		request.getMethod() + "<BR>\n" +
		"<B>Request URI: </B>" +
		request.getRequestURI() + "<BR>\n" +
		"<B>Request Protocol: </B>" +
		request.getProtocol() + "<BR><BR>\n" +
		"<TABLE BORDER=1 ALIGN=\"CENTER\">\n" +
		"<TR BGCOLOR=\"gray\">\n" +
		"<TH>Baþlýk ismi<TH>Baþlýk Degeri");
		Enumeration<String> headerNames =
		request.getHeaderNames();
		while(headerNames.hasMoreElements()) {
		String headerName = headerNames.nextElement();
		out.println("<TR><TD>" + headerName);
		out.println(" <TD>"+request.getHeader(headerName));
		}
		out.println("</TABLE>\n</BODY></HTML>");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
