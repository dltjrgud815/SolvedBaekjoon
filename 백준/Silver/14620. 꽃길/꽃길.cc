#include <bits/stdc++.h>
using namespace std;

const int max_map = 10;
const int seeds = 3;

int m[max_map][max_map];
int visited[max_map][max_map];
vector<pair<int, int>> v;
int N, ny, nx, a, b;
const int dy[4] = {-1, 0, 1, 0};
const int dx[4] = {0, 1, 0, -1};
int res_min = INT_MAX;

void go(int cnt, int sum){
    if (cnt == seeds){
        res_min = min(res_min, sum);
        return;
    }

    for (int y = 0; y < N; y++){
        for (int x = 0; x < N; x++){
            bool isSeedOK = true;
            for (int i = 0; i < 4; i++){
                ny = dy[i] + y;
                nx = dx[i] + x;
                if (ny < 0 || nx < 0 || ny >= N || nx >= N || visited[ny][nx])
                    isSeedOK = false;
            }
            if (!isSeedOK) continue;
            int temp_sum = 0;
            temp_sum += m[y][x];
            visited[y][x] = 1;
            for (int i = 0; i < 4; i++){
                ny = dy[i] + y;
                nx = dx[i] + x;
                temp_sum += m[ny][nx];
                visited[ny][nx] = 1;
            }
            go(cnt+1, sum + temp_sum);
            visited[y][x] = 0;
            for (int i = 0; i < 4; i++){
                ny = dy[i] + y;
                nx = dx[i] + x;
                visited[ny][nx] = 0;
            }
        }
    }
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    cin >> N;
    for (int i = 0; i < N; i++){
        for (int j = 0; j < N; j++){
            cin >> m[i][j];
        }
    }
    go(0, 0);
    cout << res_min << "\n";
    return 0;
}