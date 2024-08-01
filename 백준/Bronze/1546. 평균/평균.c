#include <stdio.h>

int main(void) {
    int N = 0;
    int M = 0;
    double total = 0;
    (void)scanf("%d", &N);
    for (int i = 0 ;i < N; i++) {
        int score = 0;
        (void)scanf("%d", &score);
        if (M < score) {
            M = score;
        }
        total += score;
    }

    printf("%lf", total / M * 100 / N);
}