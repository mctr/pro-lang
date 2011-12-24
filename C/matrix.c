#include <stdio.h>
#include <stdlib.h>
int *Matris(int satir, int sutun) {
	int *mtr;
	mtr = (int *)calloc((satir * sutun) + 2, sizeof(int));
	mtr[0] = satir;  // satir sayici
	mtr[1] = sutun;  // sutun sayici
	return mtr;
}

void Ekle(int *Matris, int sat, int sut, int deger) {
	int indeks;
	sat--,sut--;
	indeks = 2 + Matris[1] * sat + sut;
	Matris[indeks] = deger;
}

void Sifirla(int *Matris,int sat, int sut) {
	int indeks;
	sat--,sut--;
	indeks = 2 + Matris[1] * sat + sut;
	Matris[indeks] = 0;
}

int Eleman(int *Matris, int sat, int sut) {
	int indeks;
	sat--,sut--;
	indeks = 2 + Matris[1] * sat + sut;
	return Matris[indeks];
}

void Yazdir(int *Matris) {
	int sat_say = Matris[0];
	int sut_say = Matris[1];
	int i, j;
	printf("\nMATRIS :\n\n");
	for (i = 0;i < sat_say;i++){
		for (j = 0;j <sut_say;j++){
			printf("%3d",Matris[2 + i * sut_say + j]);
		}
	printf("\n");
	}
}

int main(void) {
	int *mymatris;
	mymatris = Matris(3, 5);
	Ekle(mymatris, 3, 5, 18);
	Ekle(mymatris, 2, 2, -7);
	Ekle(mymatris, 3, 3, 13);
	Yazdir(mymatris);
	Sifirla(mymatris, 2, 2);
	Yazdir(mymatris);
	printf("\n3.satir 3.sutundaki eleman : %d", Eleman(mymatris, 3, 3));
	getchar();
}
