#include<bits/stdc++.h>
using namespace std;

int R, C, K;
char a[6][6];
int visited[6][6];
const int dy[] = {-1, 0, 1, 0};
const int dx[] = {0, 1, 0, -1};

vector<char> v;
int res = 0;
void print(){
    for(int i : v) cout << i << " ";
    cout << "\n";
}

void go(int y, int x){
    if (v.size() > K) return;
    if(y == 0 && x == C-1 && v.size() == K){
        res++;
        return;
    }
    for (int i = 0; i < 4; i++){
        int ny = dy[i] + y;
        int nx = dx[i] + x;
        if (ny < 0 || nx < 0 || ny >= R || nx >= C || a[ny][nx] == 'T') continue;
        if(visited[ny][nx]) continue;
        visited[ny][nx] = 1;
        v.push_back(a[ny][nx]);
        go(ny, nx);
        visited[ny][nx] = 0;
        v.pop_back();
    }
}

int main(){
    cin >> R >> C >> K;
    for (int i = 0; i < R; i++){
        for (int j = 0; j < C; j++){
            scanf(" %c", &a[i][j]);
        }
    }

    visited[R-1][0] = 1;
    v.push_back(a[R-1][0]);
    go(R-1, 0);

    cout << res << "\n";
    return 0;
}