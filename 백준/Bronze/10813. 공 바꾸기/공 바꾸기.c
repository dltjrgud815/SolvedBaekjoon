#include <stdio.h>

void swap(int* a, int* b);

int main(void) {
    int basket[101] = {0};

    for (int i = 1 ; i <= 100; i++) {
        basket[i] = i;
    }

    int N, M;
    scanf("%d %d", &N, &M);
    for (int k = 0; k < M; k++) {
        int i, j;
        scanf("%d %d", &i, &j);
        swap(basket + i, basket + j);
    }

    for (int i = 1; i <= N; i++) {
        printf("%d ", basket[i]);
    }
    return 0;
}

void swap(int* a, int* b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}