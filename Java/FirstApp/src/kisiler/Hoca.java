package kisiler;

public class Hoca extends Kisi {
	private int Sicil_No;
	String Bolum;
	public void Hoca_Tanýmla(int Sicil_No, String Bolum){
		this.Sicil_No = Sicil_No;
		this.Bolum = Bolum;
	}
	public int getSicilNo() {
		return Sicil_No;
	}
	public String getBolum() {
		return Bolum;
	}
	
	public String ders_yap(){
		return "Derse girir";
	}
	
	public String Sinav_yap(){
		return "Sýnav yapar";
	}

}
