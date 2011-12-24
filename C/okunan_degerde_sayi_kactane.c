#include <stdio.h>
int main(void)
{
	int c,toplam = 0;
	for ( ; ; ){
		c = getchar();
		if (c == EOF) break;
		else if ((48 <= c) && (c<=57))
			toplam += 1;
	}
	printf("\ntoplam : %d",toplam);
	return 0;
}
