#include <bits/stdc++.h>
using namespace std;

static const int MAX = 500000;
int visited[2][MAX + 1];
int cnt = 1;
bool isOK = false;

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    int N, K;
    cin >> N >> K;
    if(N == K){cout << 0 << "\n"; return 0;}
    queue<int> q;
    q.push(N);
    visited[0][N] = 1;

    while(!q.empty()){
        K += cnt;

        if (K > MAX){
            break;
        }

        if (visited[cnt%2][K]){
            isOK = true;
            break;
        }
        
        int Qsize = q.size();
        for (int i = 0; i < Qsize; i++){
            int x = q.front(); 
            q.pop();
            for(int next : {x-1, x+1, x*2}){
                if(next < 0 || next > MAX) continue;
                if (visited[cnt % 2][next]) continue;
                visited[cnt % 2][next] = 1;
                if (next == K){
                    isOK = true;
                    break;
                }
                q.push(next);
            }
            if (isOK) break;
        }
        if (isOK) break;
        cnt++;
    }

    if (isOK) cout << cnt << "\n";
    else cout << -1 << "\n";
    
    return 0;
}