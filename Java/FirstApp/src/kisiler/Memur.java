package kisiler;

public class Memur extends Kisi {
	private int M_SicilNo;
	String Birim;
	public void Memur_Tanýmla(int M_SicilNo, String Birim){
		this.M_SicilNo = M_SicilNo;
		this.Birim = Birim;
	}
	public int getMSicilNo() {
		return M_SicilNo;
	}
	public String getBirim() {
		return Birim;
	}
	public String Evrak_getir(){
		return "Memur evrak getirir...";
	}
	public String Evrak_gotur(){
		return "Memur evrak götürür...";
	}

}
