#include <stdio.h>
#include <string.h>

int main(void) {
    int T = 0;
    char S[1000][21];
    int R[1000] = {0};
    scanf("%d", &T);
    for (int i = 0 ; i < T; i++) {
        scanf("%d %s", &R[i], S[i]);
    }

    for (int i = 0; i < T; i++) {
        for (int j = 0 ; j < strlen(S[i]); j++) {
            for (int k = 0; k < R[i]; k++) {
                printf("%c", S[i][j]);
            }
        }
        printf("\n");
    }
}