#include<bits/stdc++.h>
using namespace std;

const int map_size = 101;
int map_vector[map_size][map_size], map_visited[map_size][map_size];

int M, N, K, ny, nx;
int dy[4] = {-1, 0, 1, 0};
int dx[4] = {0, 1, 0, -1};
vector<int> map_width;
int cnt = 0;;

void DFS(int y, int x){
    if (map_visited[y][x]) return;
    map_visited[y][x] = 1;
    map_width[cnt]++;

    for (int i = 0 ; i < 4; i ++){
        ny = y + dy[i];
        nx = x + dx[i];
        if (ny < 0 || nx < 0 || ny >= M || nx >= N) continue;
        if (map_vector[ny][nx] == 0 && !map_visited[ny][nx]){
            DFS(ny, nx);
        }
    }
    
    return;
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> M >> N >> K;
    for (int i = 0; i < K; i++){
        int t_sy, t_sx, t_ey, t_ex;
        cin >> t_sx >> t_sy >> t_ex >> t_ey;
        for (int j = t_sy; j < t_ey; j++){
            for (int k = t_sx; k < t_ex; k++){
                map_vector[j][k] = 1;
            }
        }
    }

    for (int i = 0; i < M; i++){
        for (int j = 0; j < N; j++){
            if (map_vector[i][j] == 0 && !map_visited[i][j]){
                map_width.push_back(0);
                DFS(i, j);
                cnt++;
            }
        }
    }
    sort(map_width.begin(), map_width.end());

    cout << cnt << "\n";
    for (int it : map_width){
        cout << it << " ";
    }

    return 0;
}