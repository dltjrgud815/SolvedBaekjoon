#include <stdio.h>

int gcd(int A, int B){
    if(B == 0){
        return A;
    } else{
        return gcd(B, A % B);
    }
}

int main(void) {
    int A, B;
    int GCD, LCM;
    scanf("%d %d", &A, &B);
    GCD = gcd(A, B);
    LCM = A * B / GCD;
    printf("%d\n", GCD);
    printf("%d\n", LCM);

    return 0;
}