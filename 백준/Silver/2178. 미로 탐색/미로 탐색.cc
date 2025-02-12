#include<bits/stdc++.h>
using namespace std;

const int map_size = 104;
int N, M, ny, nx;
int map_vector[map_size][map_size], map_visited[map_size][map_size];

int dy[4] = {-1, 0, 1, 0};
int dx[4] = {0, 1, 0, -1};

void BFS(int y, int x){
    queue<pair<int, int>> q;
    map_visited[y][x] = 1;
    q.push({y, x});
    while(q.size()){
        tie(y, x) = q.front(); q.pop();
        for (int i = 0; i < 4; i++){
            int ny = dy[i] + y;
            int nx = dx[i] + x;
            if (ny < 0 || nx < 0 || ny >= N || nx >= M || map_vector[ny][nx] == 0) continue;
            if (map_visited[ny][nx]) continue;
            map_visited[ny][nx] = map_visited[y][x] + 1;
            q.push({ny, nx});
        }
    }
}

int main(){
    cin >> N >> M;
    for (int i = 0; i < N; i++){
        char c;
        scanf("%c", &c);
        for (int j = 0; j < M; j++){
            scanf("%c", &c);
            map_vector[i][j] = c - '0';
        }
    }

    BFS(0, 0);
    cout << map_visited[N - 1][M - 1] << "\n";
}