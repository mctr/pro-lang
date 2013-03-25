package mctr;

import kisiler.*;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class ilkservlet
 */
@WebServlet("/ilkservlet")
public class ilkservlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ilkservlet() {
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
		out.println("<!DOCTYPE html><html><head>" +
						"<style>" +
						"body {background : #f1e2f3;}" +
						"div {float:center; width:500px; margin: 10 px auto; padding:15px 25px; border:2 px solid #e1e1f2; background:white;}" +
						"</style>" +
						"</head></body>");
		
		// Ögrenci iþlemleri
		Ogrenci student = new Ogrenci();
		student.Ogrenci_Tanýmla(10060318, "Bilgisayar Mühendisligi", 3);
		out.println("<div> Öðrencimizin");
		out.println("<ul>");
		out.println(
							"<li>Öðrenci Nosu : " + student.getOgrenciNosu() + "</li>" +
							"<li>Bölümü : " + student.getBolum() + "</li>" +
							"<li>Sýnýfý : " + student.getsinif() + "</li></ul>" +
							student.derse_gir() + "</br>" +
							student.kantine_gider()
							);
		out.println("</div>");
		
		//Hoca iþlemleri
		Hoca teacher = new Hoca();
		teacher.Hoca_Tanýmla(123456, "Matematik");
		out.println("<div> Hocamýzýn");
		out.println("<ul>");
		out.println(
							"<li>H.Sicil Nosu :" + teacher.getSicilNo() + "</li>" +
							"<li>H.Bölümü :" + teacher.getBolum() + "</li>" + "</ul>" +
							teacher.ders_yap() + "</br>" +
							teacher.Sinav_yap()		
					);
		out.println("</div>");
		
		//Memur iþlemleri
		Memur officer = new Memur();
		officer.Memur_Tanýmla(125478, "Özel kalem");
		out.println("<div> Memurumuzun");
		out.println("<ul>");
		out.println(
							"<li>M.Sicil Nosu :" + officer.getMSicilNo() + "</li>" +
							"<li>M.Birimi :" + officer.getBirim() + "</li>" + "</ul>" +
							officer.Evrak_getir() + "</br>" +
							officer.Evrak_gotur()
					);
		out.println("</div>");
}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
