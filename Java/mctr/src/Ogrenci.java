
public class Ogrenci extends Kisi {
	int OgrenciNo;
	String Bolum;
	String Sinifi;
	
	public void Ogrenci_Tan�mla(int OgrenciNo, String Bolum, String Sinifi) {
		this.OgrenciNo = OgrenciNo;
		this.Bolum = Bolum;
		this.Sinifi = Sinifi;		
	}
	public static void derse_gir(String string){
		System.out.println("�grenci derse girer..");
	}
	public static void kantine_gider(String string){
		System.out.println("�grenci kantine gider..");
	}

}
