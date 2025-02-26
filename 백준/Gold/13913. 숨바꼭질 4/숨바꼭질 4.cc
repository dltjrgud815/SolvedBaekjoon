#include<bits/stdc++.h>
using namespace std;

int N, K;
const int MAX = 100000;
int dist[100001], ways[100001];
int prev_path[100001];

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> N >> K;

    for (int i = 0; i <= MAX; i++){
        dist[i] = -1;
        ways[i] = 0;
        prev_path[i] = -1;
    }

    queue<int> q;
    q.push(N);
    dist[N] = 0;
    ways[N] = 1;

    while(q.size()){
        int x = q.front();
        q.pop();

        for(int next : {x-1, x+1, x*2}){
            if (next < 0 || next > MAX) continue;

            if (dist[next] == -1){
                dist[next] = dist[x] + 1;
                ways[next] = ways[x];
                prev_path[next] = x;
                q.push(next);
            }
            else if (dist[next] == dist[x] + 1){
                ways[next] += ways[x];
            }
        }
    }

    cout << dist[K] << "\n";
    vector<int> p;

    for (int i = K; i != -1; i = prev_path[i]){
        p.push_back(i);
    }

    reverse(p.begin(), p.end());

    for (int i : p){
        cout << i << " ";
    }

    cout << "\n";

    return 0;
}