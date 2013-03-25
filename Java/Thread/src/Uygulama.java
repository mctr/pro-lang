
public class Uygulama {

	public static void main(String[] args) {
		Yap y1 = new Yap("Mesut", 2);
	    Yap y2 = new Yap("Foo Bar", 3); 
	    Yap y3 = new Yap("Hoppalaa", 3);

	    y1.start(); 
	    y2.start(); 
	    y3.start(); 
		

	}

}

class Yap extends Thread 
{ 
   private String isim = "";
   private int dondur = 0;
   public Yap(String isim, int dondur)
   {
        this.dondur = dondur;
       this.isim = isim;
   }
   public void run() 
   {
       for (int i=0; i<dondur; i++) 
      {
         System.out.println(i +"." + this.isim + "yazdýrýldý");
      }
   }
}