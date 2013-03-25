package kisiler;

public class Ogrenci extends Kisi{
	int OgrenciNo;
	String Bolum;
	int Sinifi;
	
	public void Ogrenci_Tanýmla(int OgrenciNo, String Bolum, int Sinifi) {
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
		return "Ögrenci dedigin derse girer..";
	}
	public String  kantine_gider(){
		return "Ögrenci dedigin kantine gidip çay içer..";
	}

}
