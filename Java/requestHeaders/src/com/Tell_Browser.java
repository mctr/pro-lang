package com;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class Tell_Browser
 */
@WebServlet("/Tell_Browser")
public class Tell_Browser extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Tell_Browser() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		String title, message;
		// Assume for simplicity that Firefox and IE are
		// the only two browsers.
		String userAgent = request.getHeader("User-Agent");
		if ((userAgent != null) && (userAgent.contains("MSIE"))) {
			title = "Made in Windows..";
			message = "öZGÜR mü zannediyorsun kendini" +
					" o zaman henüz unix ile tanismamissin..!";
		}else if ((userAgent != null) && (userAgent.contains("Android"))) {
			title = "Android , Made in UNIX";
			message = "Android kullanicisisin..!";
		}
		else {
			title = "Made in Firefox..";
			message = "Özgürlük bu olsa gerek..";
		}
		out.println("<!DOCTYPE html>\n" +
				"<HTML>\n" +
				"<HEAD><TITLE>" + "Application" + "</TITLE></HEAD>\n" +
				"<BODY BGCOLOR=\"#FDF5E6\">\n" +
				"<H1>" + title + "</H1>" +
				"<H1>" + message + "</H1>" +
				"</BODY></HTML>");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
