package com;
import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class registration_form_servlet
 */
@WebServlet("/RegistrationForm")
public class RegistrationForm extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public RegistrationForm() {
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
		String actionURL = "/servlet/RegistrationServlet";
		String firstname = CookieUtilities.getCookieValue(request, "firstname", "");
		String lastname = CookieUtilities.getCookieValue(request, "lastname", "");
		String email = CookieUtilities.getCookieValue(request, "email", "");
		
		String doctype = "<!DOCTYPE>\n";
		String title = "Lutfen KAYDET";
		out.println(doctype +
				"<HTML>" +
				"<HEAD><TITLE>" + "FORMM" + "</TITLE></HEAD>" +
				"<BODY BGCOLOR=\"#F2E4B7\">" +
				"<CENTER>" +
				"<H1>" + title + "</H1>" +
				"<FORM ACTION=\"" + actionURL + "\" >\n" +
				"First Name:\n" +
				"<INPUT TYPE=\"TEXT\" NAME=\"firstname\" " +
				"VALUE=\"" + firstname + "\"><BR>\n" +
				"last Name:\n" +
				"<INPUT TYPE=\"TEXT\" NAME=\"lastname\" " +
				"VALUE=\"" + lastname + "\"><BR>\n" +
				"Email:\n" +
				"<INPUT TYPE=\"TEXT\" NAME=\"email\" " +
				"VALUE=\"" + email + "\"><P>\n" +
				"<INPUT TYPE=\"SUBMIT\" VALUE=\"Kaydet\">\n" +
				"</FORM></CENTER></BODY></HTML>"
				);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
