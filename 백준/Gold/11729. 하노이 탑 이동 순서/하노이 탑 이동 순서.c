#include <stdio.h>

void recursive_hanoi(int N, char from, char to, char via){
    if (N == 1)
        printf("%c %c\n", from, to);
    else{
        recursive_hanoi(N-1, from, via, to);
        printf("%c %c\n", from, to);
        recursive_hanoi(N-1, via, to, from);
    }
}

int main(void) {
    int N;
    int res;
    scanf("%d", &N);
    printf("%d\n", (1<<N) - 1);
    recursive_hanoi(N, '1', '3', '2');
}