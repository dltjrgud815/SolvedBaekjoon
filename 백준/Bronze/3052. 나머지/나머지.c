#include <stdio.h>
#include <stdbool.h>

void sol(bool* arr, int num);
int main(void) {
    bool mod[1001] = {false};
    for (int i = 0; i < 10; i++) {
        int num = 0;
        scanf("%d", &num);
        sol(mod, num);
    }

    int res = 0;
    for (int i = 0; i < 1001; ++i) {
        if (mod[i]) res++;
    }

    printf("%d", res);
}

void sol(bool* arr, int num) {
    *(arr + (num%42)) = true;
}