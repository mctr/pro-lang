package com;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

//import org.apache.catalina.connector.Request;

/**
 * Servlet implementation class First_time_visitor
 */
@WebServlet("/First_time_visitor")
public class First_time_visitor extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public First_time_visitor() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		boolean newbie = true;
		Cookie[] cookies = request.getCookies();
		if (cookies != null) {
			for (Cookie c: cookies) {
				if ((c.getName().equals("mesut")) && (c.getValue().equals("12345"))) {
					newbie = false;
					break;
				}
			}
		}
		
		String title;
		if (newbie) {
			Cookie newcookie = new Cookie("mesut", "12345");
			newcookie.setMaxAge(60*60*24*7);// bir hafta
			response.addCookie(newcookie);
			title = "Hosgeldin Mesut Bu ilk Giris..";
		} else {
			title = "Hosgeldin Mesut Buraya daha önce de girmissin..";
		}
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		out.println("<!DOCTYPE html>" +
					"<HTML>" +
					"<HEAD><TITLE>" + "Welcome ?" + "</TITLE></HEAD>" +
					"<BODY BGCOLOR=\"#FDF5E6\">" + 
					"<CENTER>" +
					"<H1>" + title + "</H1>" +
					"URL ==>" + request.getRequestURL() + "<br>" +
					"<p>" + "PATH ==>" + request.getServletPath() + "<br>" +
					"</CENTER>" +
					"</BODY></HTML>");
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
