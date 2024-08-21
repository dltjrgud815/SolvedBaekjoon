#include <stdio.h>
#include <stdlib.h>

#define MAP_MAX (100 + 2)
int mapM, mapN, mapH;
int map[MAP_MAX][MAP_MAX][MAP_MAX] = {0};
int bad_tomato_cnt = 0;

int dm[] = {-1, 1, 0, 0, 0, 0};
int dn[] = {0, 0, -1, 1, 0, 0};
int dh[] = {0, 0, 0, 0, 1, -1};

typedef struct tomato {
    int m;
    int n;
    int h;
    int day;
}t_tomato;

typedef struct solution {
    int day; // 걸린 시간
    int cnt;
}t_solution;

int rp, wp;
t_solution sol = { 0 };
t_tomato Queue[MAP_MAX * MAP_MAX * MAP_MAX];

t_tomato read_queue(void) {
    return Queue[rp++];
}

void write_queue(int m, int n, int h, int day) {
    map[h][n][m] = 3;
    Queue[wp].m = m;
    Queue[wp].n = n;
    Queue[wp].h = h;
    Queue[wp].day = day;
    wp++;
}

void input_data(void) {
    (void)scanf("%d%d%d", &mapM, &mapN, &mapH);
    for (int i = 1; i <= mapH; i++) {
        for (int j = 1; j <= mapN; j++) {
            for (int k = 1; k <= mapM; k++) {
                (void)scanf("%d", &map[i][j][k]);
                if (map[i][j][k] == 0) {
                    bad_tomato_cnt++;
                    map[i][j][k] = 2;
                }
            }
        }
    }

    if (bad_tomato_cnt == 0) {
        printf("%d\n", 0);
        exit(0);
    }
}

void find_startpoint(void) {
    int sH, sN, sM;

    for (int i = 1; i <= mapH; i++) {
        for (int j = 1; j <= mapN; j++) {
            for (int k = 1; k <= mapM; k++) {
                if (map[i][j][k] != 1) continue;
                for (int b = 0; b < 6; b++) {
                    sH = i + dh[b];
                    sN = j + dn[b];
                    sM = k + dm[b];
                    if (map[sH][sN][sM] != 2) continue;
                    write_queue(sM, sN, sH, 1);
                }
            }
        }
    }
}

void solve(void) {
    find_startpoint();
    t_tomato curr = { 0 };
    int day;
    int i, nH, nN, nM;

    while (rp != wp) {
        curr = read_queue();
        day = curr.day;
        for (i = 0; i < 6; i++) {
            nH = curr.h + dh[i];
            nN = curr.n + dn[i];
            nM = curr.m + dm[i];
            if (map[nH][nN][nM] != 2) continue;
            write_queue(nM, nN, nH, day + 1);
        }
    }

    sol.day = day;
    sol.cnt = bad_tomato_cnt - wp;
}

int main(void) {
    input_data();
    solve();
    if (sol.cnt == 0) {
        printf("%d\n", sol.day);
    }
    else {
        printf("%d\n", -1);
    }
    return 0;
}