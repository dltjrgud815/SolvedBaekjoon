#include<bits/stdc++.h>
using namespace std;

int R, C, ny, nx, cnt;
int res = -1;
int map_vector[21][21], alphab[26];
int dy[4] = {-1, 0, 1, 0};
int dx[4] = {0, 1, 0, -1};

void dfs(int y, int x, int cnt){
    res = max(res, cnt);
    for (int i = 0; i < 4; i++){
        ny = y + dy[i];
        nx = x + dx[i];
        if (ny < 0 || nx < 0 || ny >= R || nx >= C) continue;
        int next = map_vector[ny][nx] - 'A';
        if (alphab[next] == 0) {
            alphab[next] = 1;
            dfs(ny, nx, cnt + 1);
            alphab[next] = 0;
        }
    }
    return;
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    cin >> R >> C;
    for (int i = 0; i < R; i++){
        string temp;
        cin >> temp;
        for (int j = 0; j < C; j++){
            map_vector[i][j] = temp[j];
        }
    }
    alphab[map_vector[0][0] - 'A'] = 1;
    dfs(0, 0, 1);

    cout << res << "\n";

    return 0;
}