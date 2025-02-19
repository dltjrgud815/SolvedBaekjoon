#include<bits/stdc++.h>
using namespace std;

int N, M, ty, tx;
char map_arr[51][51]; 
int map_visited[51][51];
int dy[4] = {-1, 0, 1, 0};
int dx[4] = {0, 1, 0, -1};
int max_value = -1;

void BFS(int y, int x){
    queue<pair<int, int>> q;
    map_visited[y][x] = 1;
    q.push({y, x});
    while(q.size()){
        tie(ty, tx) = q.front(); q.pop();
        for (int i = 0; i < 4; i++){
            int ny = ty + dy[i];
            int nx = tx + dx[i];
            if (ny < 0 || nx < 0 || ny >= N || nx >= M || map_arr[ny][nx] == 'W') continue;
            if (map_visited[ny][nx]) continue;
            map_visited[ny][nx] = map_visited[ty][tx] + 1;
            q.push({ny, nx});
            max_value = max(max_value, map_visited[ny][nx]); 
        }
    }
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(0); cout.tie(0);
    cin >> N >> M;

    for (int i = 0; i < N; i++){
        for (int j = 0; j < M; j++){
            cin >> map_arr[i][j];
        }
    }

    for (int i = 0; i < N; i++){
        for (int j = 0; j < M; j++){
            if (map_arr[i][j] == 'L'){
                BFS(i, j);         
                fill(&map_visited[0][0], &map_visited[0][0] + 51 * 51, 0);
            }
        }
    }

    cout << max_value - 1 << "\n";

    return 0;
}