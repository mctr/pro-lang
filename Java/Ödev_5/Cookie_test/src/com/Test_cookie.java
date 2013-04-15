package com;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class Test_cookie
 */
@WebServlet("/Test_cookie")
public class Test_cookie extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Test_cookie() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		for (int i=0 ; i < 3; i++) {
			Cookie cookie = new Cookie("deneme" + i, "valuee" + i);
			cookie.setMaxAge(3600);
			response.addCookie(cookie);
			cookie = new Cookie("foo" + i, "bar" + i);
			cookie.setMaxAge(3600);
			response.addCookie(cookie);
		}
		
		PrintWriter out = response.getWriter();
		Cookie[] cookies = request.getCookies();
		out.println("<!DOCTYPE html>" +
					"<HTML>" +
					"<HEAD><TITLE>" + "Welcome" + "</TITLE></HEAD>" +
					"<BODY BGCOLOR=\"#FDF5E6\">" + 
					"<CENTER>" +
					"<TABLE BORDER=2 ALIGN=CENTER >\n" +
					"<TR BGCOLOR=\"#f1f2f2\">\n" +
					"<H1>" + "TABLOMUZ" + "</H1>" + "<BR>" +
					"<TH>C.Name<TH>C.Deger"
					);
		if (cookies == null) {
			out.println("<TR><TH COLSPAN = 2>Cookie yok");
		} else {
			for (Cookie cookie: cookies) {
				out.println(
							"<TR><TH>" + cookie.getName() + "<TD>" + cookie.getValue()
						);
			}
		}
		out.println("</TABLE></BODY></HTML>");
		
			 
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
