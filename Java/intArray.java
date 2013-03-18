import java.lang.reflect.Array;
import javax.swing.*;
import java.util.Arrays;
 
public class gel {
  
	public static void diziYarat(int sayilar[], int boyut) {
		String mesaj = "Sayı Listesi\n";
		for(int i=0; i < sayilar.length; i++)
			sayilar[i] = Integer.parseInt(JOptionPane.showInputDialog(null, i+". ismi giriniz"));
		for(int i = 0; i < sayilar.length; i++) {
			if(sayilar[i] != -1)
				mesaj += "\n"+i+" --> "+sayilar[i];
		}
		JOptionPane.showMessageDialog(null, mesaj);
	}
	public static void k_b_sirala(int[] dizi) {
		Arrays.sort(dizi);
		String mesaj = "Büyükten küçüge sıralanmış dizi\n";
		for(int i = 0; i < dizi.length; i++) {
			if(dizi[i] != -1)
				mesaj += "\n"+i+" --> "+dizi[i];
		}
		JOptionPane.showMessageDialog(null, mesaj);
	}
	public static void b_k_siralama(int[] sayi) {
		Arrays.sort(sayi);
		String mesaj = "Küçükten büyüge sıralanmış dizi\n";
		for(int i = sayi.length - 1; i > 0; i--) {
				mesaj += "\n"+i+" --> "+sayi[i];
		}
		JOptionPane.showMessageDialog(null, mesaj);
	}
	
	public static void en_buyuk_kucuk(int[] dizi) {
		Arrays.sort(dizi);
		String mesaj = "en büyük ve en küçük eleman\n";
		mesaj += "\nEn büyük eleman ==>"+dizi[dizi.length - 1];
		mesaj += "\nEn küçük eleman ==>"+dizi[0];
		JOptionPane.showMessageDialog(null, mesaj);
	}
	
	public static void main(String arg[]){
		int sayilar[] = new int[10];
		diziYarat(sayilar,10);
		k_b_sirala(sayilar);
		b_k_siralama(sayilar);
		en_buyuk_kucuk(sayilar);
	}
}
