package kisiler;

public class Ogrenci extends Kisi{
	int OgrenciNo;
	String Bolum;
	int Sinifi;
	
	public void Ogrenci_Tan�mla(int OgrenciNo, String Bolum, int Sinifi) {
		this.OgrenciNo = OgrenciNo;
		this.Bolum = Bolum;
		this.Sinifi = Sinifi;		
	}
	public int getOgrenciNosu() {
		return OgrenciNo;
	}
	public String getBolum() {
		return Bolum;
	}
	public int getsinif() {
		return Sinifi;
	}
	public String derse_gir(){
		return "�grenci dedigin derse girer..";
	}
	public String  kantine_gider(){
		return "�grenci dedigin kantine gidip �ay i�er..";
	}

}
