#include <stdio.h>
int main(void)
{
	int c,toplam = 0;
	for ( ; ; ){
		c = getchar();
		if (c == EOF) break;
		else if ((97 <= c) && (c<=122))
			toplam += 1;
	}
	printf("\ntoplam : %d",toplam);
	return 0;

}
