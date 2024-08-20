#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdbool.h>

bool isPrime(int num);

int main(void) {
    int N;
    int check_prime = 0;
    int sol = 0;

    (void)scanf("%d", &N);
    for (int i = 0; i < N; i++){
        (void)scanf("%d", &check_prime);
        if (isPrime(check_prime)) sol ++;
    }

    printf("%d\n", sol);

    return 0;
}

bool isPrime(int num){
    if (num == 1) return false;
    for (int i = 2; i < num; i++){
        if (num % i == 0) return false;
    }
    return true;
}