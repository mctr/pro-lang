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
 * Servlet implementation class Registration_servlet
 */
@WebServlet("/RegistrationServlet")
public class RegistrationServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
    
	private boolean match(String foo) {
		return ((foo == null) || (foo.trim().equals("")));
	}
    /**
     * @see HttpServlet#HttpServlet()
     */
    public RegistrationServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
		
		response.setContentType("text/html");
		boolean state = false;
		String firstname = request.getParameter("firstname");
		if (match(firstname)) {
			firstname = "ilk ismini neydi?";
			state = true;
		}
		String lastname = request.getParameter("lastname");
		if (match(lastname)) {
			lastname = "son ismin neydi?";
			state = true;
		}
		String email = request.getParameter("email");
		if (match(email)) {
			lastname = "e-mail'in neydi?";
			state = true;
		}
		Cookie a = new LongLivedCookie("firstname", firstname);
		response.addCookie(a);
		Cookie b = new LongLivedCookie("lastname", lastname);
		response.addCookie(b);
		Cookie c = new LongLivedCookie("email", email);
		response.addCookie(c);
		
		String form_adresi = "servlet/RegistrationForm";
		if (state) {
			response.sendRedirect(form_adresi);
		} else {
			PrintWriter out = response.getWriter();
			String doctype = "<!DOCTYPE>\n";
			out.println(doctype +
						"<HTML>" +
						"<HEAD><TITLE>" + "Kaydettiginiz icin tesekkurler.." + "</TITLE></HEAD>" +
						"<BODY BGCOLOR=\"#E4F201\">" +
						"<CENTER>" +
						"<H1>" + "Kaydettiginiz icin tesekkurler.." + "</H1>" +
						"<UL>" +
						"<BR><B>First Name</B>: " + firstname +
						"<BR><B>Last Name</B>: " + lastname +
						"<BR><B>Email</B>: " + email +
						"</UL>" +
						"</CENTER></BODY></HTML>"
					);
		}
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
