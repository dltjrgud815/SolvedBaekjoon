#include <stdio.h>
#include <math.h>

int main(void) {
    int A = 0, B = 0;
    scanf("%d %d", &A, &B);
    int cA = 0, cB = 0;
    for (int i = 2; i >= 0; i--) {
        int tempA = A % 10;
        int tempB = B % 10;
        cA += pow(10, i) * tempA;
        cB += pow(10, i) * tempB;
        A /= 10;
        B /= 10;
    }

    printf("%d\n", cA > cB ? cA : cB);
    return 0;
}