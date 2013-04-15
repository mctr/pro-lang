package com;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class Client_access_count
 */
@WebServlet("/Client_access_count")
public class Client_access_count extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Client_access_count() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		String CountString = CookieUtilities.getCookieValue(request, "sayi", "1");
		int count = 1;
		try {
			count =Integer.parseInt(CountString);
		} catch(NumberFormatException nfe) { }
		
		LongLivedCookie c = new LongLivedCookie("sayi", String.valueOf(count + 1));
		response.addCookie(c);
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		String title = "Kac kez tiklandi";
		String head = "<!DOCTYPE>";
		out.println(head +
					"<HTML>" +
					"<HEAD><TITLE>" + title + "</TITLE></HEAD>" +
					"<BODY BGCOLOR=\"#F1F2F3\">" +
					"<CENTER>" +
					"<H1>" + title + "</H1>" +
					"<H2>Bu Sayfa bu browser tarafindan " +
					count + "  kez acilmistir..</H2>" +
					"</CENTER></BODY></HTML>"
				);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
