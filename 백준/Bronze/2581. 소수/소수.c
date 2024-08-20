#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdbool.h>

#define MAX 10000
bool Primes[MAX + 1];
void init_Primes(void);

int main(void) {
    init_Primes();
    int M, N;
    int sum_prime = 0;
    int min_prime = 10000;
    (void)scanf("%d%d", &M, &N);

    for (int i = M; i <= N; i++){
        if (Primes[i]) {
            sum_prime += i;
            if (min_prime > i)
                min_prime = i;
        }
    }

    if (sum_prime == 0){
        printf("%d\n", -1);
    }
    else{
        printf("%d\n%d", sum_prime, min_prime);
    }

    return 0;
}

void init_Primes(void){
    Primes[0] = Primes[1] = false;

    for (int i = 2; i <= MAX; i++){
        Primes[i] = true;
    }

    for (int i = 2; i <= MAX/2; i++){
        for (int j = 2; j <= MAX / i; j++){
            Primes[i*j] = false;
        }
    }
}