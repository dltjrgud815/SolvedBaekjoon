#include <stdio.h>

long long gcd(long long A, long long B){
    if(B == 0){
        return A;
    } else{
        return gcd(B, A % B);
    }
}

int main(void) {
    long long A, B;
    long long GCD;
    scanf("%lld %lld", &A, &B);
    GCD = gcd(A, B);
    for (int i = 0; i < 10000000 && i < GCD ;i++){
        printf("1");
    }

    return 0;
}