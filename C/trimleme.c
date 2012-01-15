#include <stdio.h>
#include <string.h>

void sil(char s[]) {
	char k[50];
	int i, j , state = 1;
	for (i = 0, j = 0; i < (strlen(s)); i++) {
		if ((s[i] == ' ') && (state == 1)) {
			k[j++] = s[i];
			state = 0;
		}else if (state == 1)
			k[j++] = s[i];
		
		else if ((s[i] != ' ') && (state == 0)){
			k[j++] = s[i]; state = 1;
		}
	}
	k[j] = '\0';
	strcpy(s, k);
}
int main(void) {
	char s[] = "      mesut  naber             hey  yo";
	sil(s);
	//~ strcpy(s, k);
	printf("%s",s);
	return 0;
}
			
