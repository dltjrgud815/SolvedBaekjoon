#include<bits/stdc++.h>
using namespace std;

const int map_max_size = 9;
int N, M, ny, nx, res = 0;
int origin_map[map_max_size][map_max_size], cpy_map[map_max_size][map_max_size];
int visited[map_max_size][map_max_size];
vector<pair<int, int>> start_point;
int dy[4] = {-1, 0, 1, 0};
int dx[4] = {0, 1, 0, -1};

void DFS(int y, int x){
    if(visited[y][x]) return;
    visited[y][x] = 1;

    for(int i = 0; i < 4; i++){
        ny = dy[i] + y;
        nx = dx[i] + x;
        if (ny < 0 || nx < 0 || ny >= N || nx >= M || cpy_map[ny][nx] == 1) continue;
        if (cpy_map[ny][nx] == 0 && !visited[ny][nx]){
            cpy_map[ny][nx] = 2;
            DFS(ny, nx);
        }
    }
}

void Cal_width(){
    int cnt = 0;
    for (int i = 0; i < N; i++){
        for (int j = 0; j < M; j++){
            if(cpy_map[i][j] == 0) cnt++;
        }
    }
    if(res < cnt) res = cnt;
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> N >> M;

    for (int i = 0; i < N; i++){
        for (int j = 0; j < M; j++){
            cin >> origin_map[i][j];
            if (origin_map[i][j] == 2)
                start_point.push_back({i, j});
        }
    }

    for (int i = 0; i < N * M; i++){
        if(origin_map[i/M][i%M] == 2 || origin_map[i/M][i%M] == 1) continue;
        for (int j = i+1; j < N * M; j++){
            if(origin_map[j/M][j%M] == 2 || origin_map[j/M][j%M] == 1) continue;
            for (int k = j+1; k < N * M; k++){
                if(origin_map[k/M][k%M] == 2 || origin_map[k/M][k%M] == 1) continue;
                memcpy(cpy_map, origin_map, sizeof(origin_map));
                cpy_map[i/M][i%M] = 1;
                cpy_map[j/M][j%M] = 1;
                cpy_map[k/M][k%M] = 1;

                for (int t = 0; t < start_point.size(); t++){
                    DFS(start_point[t].first, start_point[t].second);
                }

                Cal_width();
                fill(&visited[0][0], &visited[0][0]+map_max_size*map_max_size, 0);
            }
        }
    }

    cout << res << "\n";

    return 0;
}