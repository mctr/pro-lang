package foo;

import java.util.*;
import java.math.BigInteger;

public class PrimeList implements Runnable {
	private ArrayList primesFound;
	private int numPrimes, numDigits;

	public PrimeList(int numPrimes, int numDigits,boolean runInBackground) {
		primesFound = new ArrayList(numPrimes);
		this.numPrimes = numPrimes;
		this.numDigits = numDigits;
		if (runInBackground) {
			Thread t = new Thread(this);

			t.setPriority(Thread.MIN_PRIORITY);
			t.start();
		} else {
				run();
		}
}

	public void run() {
	BigInteger start = Primes.random(numDigits);
	for(int i=0; i<numPrimes; i++) {
		start = Primes.nextPrime(start);
		synchronized(this) {
			primesFound.add(start);
		}
	}
}
	public synchronized boolean isDone() {
		return(primesFound.size() == numPrimes);
	}
	public synchronized ArrayList getPrimes() {
		if (isDone())
			return(primesFound);
		else
			return((ArrayList)primesFound.clone());
	}
	public int numDigits() {
		return(numDigits);
	}
	public int numPrimes() {
		return(numPrimes);
	}
	public synchronized int numCalculatedPrimes() {
		return(primesFound.size());
	}

}