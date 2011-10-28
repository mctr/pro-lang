#include <stdio.h>
int main(void)
{
	int c, toplam = 0, gecici = 0;
	for ( ; ; ){
		c = getchar();
		if (c == EOF) {
			if (gecici != '\n')
				toplam += 1;
			break;
		}else if (c == '\n')
			toplam += 1;
	gecici = c;
	}
	printf("\ntoplam: %d\n", toplam);
	return 0;
}

