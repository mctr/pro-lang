package com;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.*;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 * Servlet implementation class istekFormu_servlet
 */
@WebServlet("/istekFormu_servlet")
public class istekFormu_servlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public istekFormu_servlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		HttpSession session =request.getSession();
		ArrayList<String> liste =(ArrayList)session.getAttribute("liste");
		if (liste == null) {
			liste = new ArrayList<>();
			session.setAttribute("liste", liste);
		}	
		String yeniistek = request.getParameter("Yeniistek");
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		String title = "isteklerr...";
		String docType = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.1 " + "Transitional//EN\">\n";
		out.println(docType +
					"<HTML>\n" +
					"<HEAD><TITLE>" + title + "</TITLE></HEAD>\n" +
					"<BODY BGCOLOR=\"#FDF5E6\">\n" +
					"<H1>" + title + "</H1>");
		synchronized(liste) {
			if (yeniistek != null) {
				liste.add(yeniistek);
			}
			if (liste.size() == 0) {
				out.println("<I>istek yok</I>");
			} else {
				out.println("<UL>");
			for(int i=0; i<liste.size(); i++) {
				out.println("<LI>" + (String)liste.get(i));
			}
			out.println("</UL>");
			}
		}
		
		out.println("</BODY></HTML>");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
