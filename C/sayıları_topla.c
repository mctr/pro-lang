#include <stdio.h>
int main(void)
{
	int c ,t = 0;
	c = getchar();
	for ( ; ; ) {
		c = getchar();
		if ( c == EOF) break;
		else if (('0' <= c) && (c <= '9'))
			t += c-48;
	}
	printf("\n%d",t);
	return 0;
}
