#include<stdio.h>
void fonk(void) {
	printf("merhaba\n");
	//~ getchar();
}

void yaptir(void(*ptr1)(void)) {
	printf("yaptir:");
	ptr1();
}

int main(void) {
	yaptir(fonk);
	//~ fonk();
	return 0;
}
