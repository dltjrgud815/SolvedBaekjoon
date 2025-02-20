#include <bits/stdc++.h>
using namespace std;

int R, C;
int m[1001][1001];
int visit[1001][1001];
vector<pair<int, int>> f_pos;
int sy, sx, ny, nx;
int dy[4] = {-1, 0, 1, 0};
int dx[4] = {0, 1, 0, -1};
int res = 0;

void f_bfs(int y, int x){
    queue<pair<int, int>> q;
    visit[y][x] = 1;
    m[y][x] = 0;
    q.push({y, x});
    while(q.size()){
        tie(y, x) = q.front(); q.pop();
        for (int i = 0; i < 4; i++){
            ny = dy[i] + y;
            nx = dx[i] + x;
            if (ny < 0 || nx < 0 || ny >= R || nx >= C) continue;
            if (visit[ny][nx]) continue;
            if (m[ny][nx] == -3) continue;
            visit[ny][nx] = visit[y][x] + 1;
            m[ny][nx] = min(m[ny][nx], visit[ny][nx]-1);
            q.push({ny, nx});
        }
    }
}

void j_bfs(int y, int x){
    queue<pair<int, int>> q;
    visit[y][x] = 1;
    q.push({y, x});
    while(q.size()){
        tie(y, x) = q.front(); q.pop();
        if (y == R-1 || x == C-1 || y == 0 || x == 0){
            res = visit[y][x];
            return;
        }
        for (int i = 0; i < 4; i++){
            ny = dy[i] + y;
            nx = dx[i] + x;
            if (ny < 0 || nx < 0 || ny >= R || nx >= C) continue;
            if (visit[ny][nx]) continue;
            if (m[ny][nx] == -3 || m[ny][nx] == 0) continue;
            if (m[ny][nx] <= visit[y][x]) continue;
            visit[ny][nx] = visit[y][x] + 1;
            q.push({ny, nx});
        }
    }
}

int main(){
    cin >> R >> C;
    fill(&m[0][0], &m[0][0] + 1001*1001, 2000);
    for (int i = 0; i < R; i++){
        for (int j = 0; j < C; j++){
            char c;
            scanf(" %c", &c);
            switch(c){
                case '#':
                    m[i][j] = -3;
                    break;
                case 'J':
                    sy = i;
                    sx = j;
                    break;
                case 'F':
                    f_pos.push_back({i, j});
                    break;
            }
        }
    }

    for (int i = 0; i < f_pos.size(); i++){
        fill(&visit[0][0], &visit[0][0] + 1001*1001, 0);
        f_bfs(f_pos[i].first, f_pos[i].second);
    }
    fill(&visit[0][0], &visit[0][0] + 1001*1001, 0);
    j_bfs(sy, sx);

    if (res != 0) cout << res << "\n";
    else cout << "IMPOSSIBLE" << "\n";
    
    return 0;
}