package com;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import foo.*;
//import com.sun.xml.internal.bind.v2.schemagen.xmlschema.List;

/**
 * Servlet implementation class NumberGeneration
 */
@WebServlet("/NumberGeneration")
public class NumberGeneration extends HttpServlet {
	private ArrayList primeListCollection = new ArrayList();
	private int maxPrimeLists = 30;

	public void doGet(HttpServletRequest request,HttpServletResponse response)throws ServletException, IOException {
	int numPrimes =	ServletUtilities.getIntParameter(request,"numPrimes", 50);
	int numDigits =	ServletUtilities.getIntParameter(request,"numDigits", 120);
	PrimeList primeList =findPrimeList(primeListCollection, numPrimes, numDigits);

	if (primeList == null) {
	primeList = new PrimeList(numPrimes, numDigits, true);

	synchronized(primeListCollection) {
	if (primeListCollection.size() >= maxPrimeLists)
	primeListCollection.remove(0);
	primeListCollection.add(primeList);
	}
	}
	ArrayList currentPrimes = primeList.getPrimes();
	int numCurrentPrimes = currentPrimes.size();
	int numPrimesRemaining = (numPrimes - numCurrentPrimes);
	boolean isLastResult = (numPrimesRemaining == 0);
	if (!isLastResult) {
		response.setIntHeader("Refresh", 5);
	}
	response.setContentType("text/html");
	PrintWriter out = response.getWriter();
	String title = "Some " + numDigits + "-Digit Prime Numbers";
	out.println(ServletUtilities.headWithTitle(title) +
				"<BODY BGCOLOR=\"#FDF5E6\">\n" +
				"<H2 ALIGN=CENTER>" + title + "</H2>\n" +
				"<H3>Primes found with " + numDigits +
				" or more digits: " + numCurrentPrimes +
				".</H3>");
	if (isLastResult)
		out.println("<B>Done searching.</B>");
	else
		out.println("<B>Still looking for " + numPrimesRemaining +
					" more<BLINK>...</BLINK></B>");
	out.println("<OL>");
	for(int i=0; i<numCurrentPrimes; i++) {
		out.println(" <LI>" + currentPrimes.get(i));
	}
	out.println("</OL>");
	out.println("</BODY></HTML>");
	}

private PrimeList findPrimeList(ArrayList primeListCollection,int numPrimes,int numDigits) {
	for(int i=0; i<primeListCollection.size(); i++) {
		PrimeList primes =(PrimeList)primeListCollection.get(i);
	synchronized(primeListCollection) {

		if ((numPrimes == primes.numPrimes()) &&(numDigits == primes.numDigits()))
	return(primes);
	}
	return(null);
	}
	return null;
 }
}
