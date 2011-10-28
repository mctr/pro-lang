#include <stdio.h>
int
main()
{
	int vize, final, not;
	printf("vize sinaviniz:");
	scanf("%d", &vize);
	printf("final sinaviniz:");
	scanf("%d", &final);
	not = 0.4 * vize + 0.6 * final;
	if (final < 50){
		printf("final notunuz 50'den yüksek olmalı malesef kaldiniz...");
	} else if (not >= 60) { 
		printf("Tebrikler bu dersi gectiniz...");
	} else {
		printf("Malesef kaldiniz...");
	}
	return 0;
}
