#include<bits/stdc++.h>
using namespace std;

int N;
int visited[61][61][61];
int dmg[3] = {9, 3, 1};
int scv[3];
struct SCV{
    int a, b, c;
};

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> N;
    for (int i = 0; i < N; i++){
        cin >> scv[i];
    }

    queue<SCV> q;
    q.push({scv[0], scv[1], scv[2]});
    visited[scv[0]][scv[1]][scv[2]] = 1;

    while(q.size()){
        int a = q.front().a;
        int b = q.front().b;
        int c = q.front().c;
        q.pop();
        if (visited[0][0][0]) break;

        do{
            int a_t, b_t, c_t;
            a_t = max(0, a - dmg[0]);
            b_t = max(0, b - dmg[1]);
            c_t = max(0, c - dmg[2]);
            if (visited[a_t][b_t][c_t]) continue;
            q.push({a_t, b_t, c_t});
            visited[a_t][b_t][c_t] = visited[a][b][c] + 1;
        }while (prev_permutation(dmg, dmg + N));
    }

    cout << visited[0][0][0] - 1 << "\n";

    return 0;
}