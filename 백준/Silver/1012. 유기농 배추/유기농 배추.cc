#include <bits/stdc++.h>
using namespace std;

const int map_size = 54;
int T, M, N, K, ny, nx;
int map_vector[map_size][map_size], map_visited[map_size][map_size]; 
int dy[4] = {-1, 0, 1, 0};
int dx[4] = {0, 1, 0, -1};
vector<int> res;

void DFS(int y, int x){
    if (map_visited[y][x]) return;
    map_visited[y][x] = 1;
    for (int i = 0; i < 4; i++){
        ny = y + dy[i];
        nx = x + dx[i];
        if (ny < 0 || nx < 0 || ny >= M || nx >= N) continue;
        if (map_vector[ny][nx] == 1 && !map_visited[ny][nx]){
            DFS(ny, nx);
        }
    }
    return;
}

void clean_map(){
    for (int i = 0; i < M; i++){
        for (int j = 0; j < N; j++){
            map_vector[i][j] = 0;
            map_visited[i][j] = 0;
        }
    }

}

int main(){
    cin >> T;
    
    for (int i = 0; i < T; i++){
        cin >> M >> N >> K;
        int temp_res = 0;
        for (int j = 0; j < K; j++){
            int y, x;
            cin >> y >> x;
            map_vector[y][x] = 1;
        }

        for (int j = 0; j < M; j++){
            for (int k = 0; k < N; k++){
                if (map_vector[j][k] == 1 && !map_visited[j][k]){
                    temp_res++; DFS(j, k);
                }
            }
        }
        res.push_back(temp_res);
        clean_map();
    }

    for (int it : res){
        cout << it << "\n";
    }

    return 0;
}