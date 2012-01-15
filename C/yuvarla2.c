#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#define MAXLINE 10000


void reverse(char *s) {
	int c, i, j;
	for (i = 0, j = strlen(s) - 1; j > i; i++, j--)
		c = *(s + i), *(s + i) = *(s + j), *(s + j) = c;
}

char *
int2str(int n)
{
	char *s = malloc(100);
	int i = 0;
	do {
		s[i++] = n % 10 + '0'; /* get next digit */
	} 
	while ((n /= 10) > 0);
	reverse(s);
	return s;
	//~ *(sensibility) = sens + 48;
	//~ *(sensibility + 1) = '\0';
}
void
float_show(float number, int sens)
{
	char format[MAXLINE];
	
	// string join 
	strcat(format, "%.");
	strcat(format, int2str(sens));
	strcat(format, "f\n");
	// show
	printf(format, number);
}

int
main()
{
	float_show(2.632556884, 3);
	//~ printf("%s", int2str(22333));
	return 0;
}
