#include <bits/stdc++.h>
using namespace std;

const int map_size = 101;
int map_vector[map_size][map_size], map_visited[map_size][map_size];
int N, ny, nx, max_height, max_res;
int res = 0;
int cur_height;
int dy[4] = {-1, 0, 1, 0};
int dx[4] = {0, 1, 0, -1};


void DFS(int y, int x){
    if (map_visited[y][x]) return;
    map_visited[y][x] = 1;
    for (int i = 0; i < 4; i++){
        ny = dy[i] + y;
        nx = dx[i] + x;
        if (ny < 0 || nx < 0 || ny >= N || nx >= N) continue;
        if (map_vector[ny][nx] > cur_height && !map_visited[ny][nx]){
            DFS(ny, nx);
        }
    }
    return;
}

int main(){
    cin >> N;
    for (int i = 0; i < N; i++){
        for (int j = 0; j < N; j++){
            cin >> map_vector[i][j];
            max_height = max(max_height, map_vector[i][j]);
        }
    }
    for (cur_height = 0; cur_height <= max_height; cur_height++){
        for (int i = 0; i < N; i++){
            for (int j = 0; j < N; j++){
                if (map_vector[i][j] > cur_height && !map_visited[i][j]){
                    res++; DFS(i, j);
                }
            }
        }
        max_res = max(max_res, res);
        res = 0;
        fill(&map_visited[0][0], &map_visited[0][0] + map_size * map_size, 0);
    }
    
    cout << max_res << "\n";

    return 0;
}