#include <stdio.h>

void fill_rectangle(int (*rt)[100], int x, int y);
int solution(int (*rt)[100]);

int main(void) {
    int count = 0;
    int rectangle[100][100] = {0};

    scanf("%d", &count);
    for (int i = 0; i < count; i++) {
        int x, y;
        (void)scanf("%d %d", &x, &y);
        fill_rectangle(rectangle, x, y);
    }

    printf("%d", solution(rectangle));
    return 0;
}

int solution(int (*rt)[100]) {
    int black_count = 0;
    for (int i = 0; i < 100; i++) {
        for (int j = 0; j < 100; j++) {
            black_count += rt[i][j];
        }
    }
    return black_count;
}

void fill_rectangle(int (*rt)[100], int x, int y) {
    int i, j;
    for (i = x; i < x + 10; i++) {
        for (j = y; j < y + 10; j++) {
            if (rt[i][j] == 1) continue;

            rt[i][j] = 1;
        }
    }
}