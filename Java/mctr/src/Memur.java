
public class Memur extends Hoca {
	private int M_SicilNo;
	String Birim;
	public void Memur_Tan�mla(int M_SicilNo, String Birim){
		this.M_SicilNo = M_SicilNo;
		this.Birim = Birim;
	}
	public static void Evrak_getir(String string){
		System.out.println("Memur evrak getirir...");
	}
	public static void Evrak_gotur(String string){
		System.out.println("Memur evrak g�t�r�r...");
	}
	

}
