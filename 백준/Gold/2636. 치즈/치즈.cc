#include<bits/stdc++.h>
using namespace std;

int N, M, ny, nx;
vector<int> res;
int map_arr[101][101];
int map_visited[101][101];
int cnt, cnt2;
int dy[4] = {-1, 0, 1, 0};
int dx[4] = {0, 1, 0, -1};
vector<pair<int, int>> v;

void DFS(int y, int x){
    map_visited[y][x] = 1;
    if (map_arr[y][x]){
        v.push_back({y, x});
        return;
    }

    for (int i = 0; i < 4; i++){
        ny = dy[i] + y;
        nx = dx[i] + x;
        if (ny < 0 || nx < 0 || ny >= N || nx >= M || map_visited[ny][nx]) continue;
        DFS(ny, nx); 
    }
    return;
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> N >> M;
    for (int i = 0; i < N; i++){
        for(int j = 0; j < M; j++){
            cin >> map_arr[i][j];
        }
    }

    while(true){
        fill(&map_visited[0][0], &map_visited[0][0] + 101*101, 0);
        v.clear();

        DFS(0, 0); 
        for (pair<int, int> cheese : v){
            map_arr[cheese.first][cheese.second] = 0;
        }
        cnt2 = v.size();
        int flag = 0;
        for (int i = 0; i < N; i++){
            for (int j = 0; j < M; j++){
                if (map_arr[i][j] > 0)
                    flag = 1;
            }
        }

        cnt++;

        if (!flag){
            break;
        }
    }
    
    cout << cnt << "\n" << cnt2 << endl;

    return 0;

}
