#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct tags {
	char *tag;
	struct tags *next;
};

typedef struct tags tags;

tags *etiket = NULL;
char depo[100];

void push(char *data) { 	//"etikete" push ediyoruz.
	tags *new;

	new = (tags *)malloc(sizeof(tags));
	new -> tag = strdup(data);	// tag degiskenine direk atama yapilamadigi için strdup fonk. kullanilir.
	new -> next = etiket;
	etiket = new;
}

void pop(void) { 	//etiketi pop ediyoruz(siliyoruz).
	tags *current;
	current = etiket;
	etiket = etiket -> next;
	free(current);

}

int isEmpty(void) {
	return (etiket != NULL);
}

void par_checker(void) {			//taglarin kontrol edildigi yer
	int i = 0, j;
	char tag_dizisi[10];			//taglari tutacak bir dizi olusturduk.
	char dizi[20];

	for (i = 0; depo[i] != '\0'; i++){

		if (depo[i] == '<') { 				//tag baslangici
			if (depo[i + 1] != '/') {		//acma tagi geldiyse
				j = 0;
				i++;
				while(depo[i] != '>')		//'>' gelene kadar ilerle ve her harfi tag_dizisi' ne at.
					tag_dizisi[j++] = depo[i++];

				tag_dizisi[j] = '\0'; 		//tag_dizisi' nin sonunu belirttik.
				push(tag_dizisi);

			}
			if (depo[i + 1] == '/') {		// kapama etiketi geldiyse
				if(!isEmpty()) {		// stack bossa ve kapama geldiyse
					printf("etiketlerin siralamasi hatalidir.\n");
					return;
				}
				j = 0;
				i += 2;
				while(depo[i] != '>')		//'>' gelene kadar kapama tagini olusturuyoruz.
					tag_dizisi[j++] = depo[i++];

				tag_dizisi[j] = '\0';
				if(strcmp(tag_dizisi, etiket -> tag) != 0) {		// farkli acma kapama varsa
					printf("etiketlerin siralamasi hatalidir.\n");
					return;
				}
				pop();
			}

		}

	}
	if(isEmpty())
		printf("etiketlerin siralamasi hatalidir.\n");	// kontrol bitmesine ragmen "etiket" bos degilse
	else
		printf("etiketler hatasiz siralanmistir.\n");	// "etiket" bossa

}

void bellegi_geri_ver(void) {		// "etiket" degiskeninin isi bittiginde onu yok etme
	tags *current, *yedek;
	current = etiket;
	while (current) {
		yedek = current -> next;
		free(current);
		current = yedek;
	}
}

int main(void) {
	FILE *fp; 			//dosyayi tutacak bir pointer tanimliyoruz.
	char dosya_adi[20]; 		//html taglarini tutacak bir dizi tanimliyoruz.
	int i = 0;

	printf("dosya adini giriniz(ör : ornek.txt): ");
	gets(dosya_adi);

	fp = fopen(dosya_adi, "r"); 	//dosyayi acmayi deniyoruz.

	if (!fp) { 	 		//dosya acilmadiysa hata mesajimizi verip programdan cikiyoruz.
		printf("dosyanın varlıgından emin olun.\n");
		return 0;
	}

	do {
		fscanf(fp, "%c", &depo[i++]); 	// bu dongu ile dosyadan okudugumuzu depo dizisine attik.
	} while (!feof(fp));
	depo[i] = '\0';

	fclose(fp);

	par_checker();	 	// parchecker denetimi basliyor...
	bellegi_geri_ver();

	return 0;
}
