#include <stdio.h>
#define MAP_MAX 25
int map[MAP_MAX][MAP_MAX];
int visit[MAP_MAX][MAP_MAX] = {0};
int danji[MAP_MAX * MAP_MAX] = {0};
int N = 0;
int cnt = 0;
int danji_cnt = 0;

void print_data(void) {
    printf("%d\n", danji_cnt);
    for (int i = 0; i < danji_cnt; i++) {
        printf("%d\n", danji[i]);
    }
}

void input_data(void) {
    char temp[MAP_MAX + 1];
    (void)scanf("%d", &N);
    for (int i = 0; i < N; i++) {
        (void)scanf("%s", temp);
        for (int j = 0; j < N; j++) {
            map[i][j] = temp[j] - '0';
        }
    }
}

void find_danji(int r, int c) {
    if (r < 0 || r >= N || c < 0 || c >= N) return;
    if (map[r][c] != 1 || visit[r][c] == 1) return;

    cnt++;
    visit[r][c] = 1;

    find_danji(r-1, c);
    find_danji(r+1, c);
    find_danji(r, c-1);
    find_danji(r, c+1);
}


void solve(void) {
    int r, c;
    for (r = 0; r < N; r++) {
        for (c = 0; c < N; c++) {
            if (map[r][c] != 1 || visit[r][c] == 1) continue;
            cnt = 0;
            find_danji(r, c);
            danji[danji_cnt++] = cnt;
        }
    }
}

void sort_data(void) {
    int i, j, temp;
    for (i = 0; i < danji_cnt - 1; i++) {
        for (j = i + 1; j < danji_cnt; j++) {
            if (danji[i] > danji[j]) {
                temp = danji[i];
                danji[i] = danji[j];
                danji[j] = temp;
            }
        }
    }
}

int main(void) {
    input_data();
    solve();
    sort_data();
    print_data();
}