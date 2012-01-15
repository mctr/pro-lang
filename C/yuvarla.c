#include <stdio.h>
int yuvarla(float a) {
	printf("aşagi yuvarlanmış hali : %d", (int)a);
	
	printf("\nyukari yuvarlanmış hali : %d", (int)(a + 1));
	
	if ((a - (int)a) < 0.5)
		printf("\nyukari yuvarlanmış hali : %d", (int)a);
	
	else if ((a - (int)a) > 0.5)
		printf("\nen yakina yuvarlanmış hali : %d", (int)(a + 1));
}
int main(void) {
	yuvarla(12.657);
	return 0;
}
