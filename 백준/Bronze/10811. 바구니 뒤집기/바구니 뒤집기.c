#include <stdio.h>
#include <math.h>

void swap(int* a, int* b);
void range_swap(int* arr, int startIdx, int endIdx);

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
        range_swap(basket, i, j);
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

void range_swap(int* arr, int startIdx, int endIdx) {
    int arange = endIdx - startIdx;
    if (arange == 0) {
        return;
    }

    do {
        swap(arr + startIdx, arr + endIdx);
        startIdx++;
        endIdx--;
    } while (endIdx - startIdx != -1 && endIdx - startIdx != 0);
}