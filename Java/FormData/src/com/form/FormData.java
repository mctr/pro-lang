package com.form;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class FormData
 */
@WebServlet("/FormData")
public class FormData extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public FormData() {
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
		PrintWriter out = response.getWriter();
		out.println("<!DOCTYPE html>\n" +
				"<html>\n" +
				"<head><title>Form Goruntulemee Sayfasi</title></head>\n" +
				"<body bgcolor=\"#f1f2e2\">\n<h1>Ogrenci </h1>");

		out.println("<TABLE BORDER=1 ALIGN=CENTER >\n" +
				"<TR BGCOLOR=\"#f1f2f2\">\n" +
				"<TH>Parameter Name<TH>Parameter Value(s)"+
				"<TR><TH>Ogrenci No<TD></b>"+request.getParameter("okulno") + "\n"+
				"<TR><TH> Ad <TD>"+request.getParameter("ad") + "\n"+
				"<TR><TH> Soyad <TD>"+request.getParameter("soyad") + "\n"+
				"<TR><TH> Sinifi <TD>"+request.getParameter("check") + "\n"+
				"<TR><TH> Bolum <TD>"+request.getParameter("bolum") + "\n"+
				"<TR><TH> Mesaj  <TD>"+request.getParameter("mesajiniz") + "\n<TABLE>");
		
		out.println("</body></html>");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
