#include <stdio.h>
int 
main() 
{
	int i, sonuc = 1, sayi;
	printf("faktöriyel alacaginiz sayiyi giriniz:");
	scanf("%d", &sayi);
	for (i = 1; i < sayi + 1; i++){
		sonuc *= i;
	}
	printf("\n%d", sonuc);
	return 0;
}
