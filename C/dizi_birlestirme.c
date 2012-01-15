#include<stdio.h>
#include<string.h>
int main(void) {
	char a[] = "2134214";
	char b[] = "12312";
	int i;
	strcat(a, b);
	for (i = 0; i < 12; i++)
	{
		printf("%c ",a[i]);
	}
	return 0;	
}
