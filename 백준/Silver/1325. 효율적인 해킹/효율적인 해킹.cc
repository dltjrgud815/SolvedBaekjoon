#include<bits/stdc++.h>
using namespace std;

const int max_N_size = 10001;
int N, M;
vector<int> adj[max_N_size];
int visited[max_N_size];
map<int, int> temp;
vector<int> res;
int cnt = 0;
int max_val = 0;

void DFS(int here){
    if (visited[here]) return;
    visited[here] = 1;
    cnt++;
    for (int it : adj[here]){
        if (visited[it] == 0){
            DFS(it);
        }
    }
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> N >> M;

    for (int i = 0; i < M; i++){
        int A, B;
        cin >> A >> B;
        adj[B].push_back(A);
    }

    for(int i = 1; i <= N; i++){
        cnt = 0;
        DFS(i);
        temp.insert({i, cnt});
        fill(visited, visited + max_N_size, 0);
    }

    for(auto it : temp){
        if (max_val < it.second){
            res.clear();
            max_val = it.second;
            res.push_back(it.first);
        }
        else if (max_val == it.second){
            res.push_back(it.first);
        }
    } 

    for(int it : res){
        cout << it << " ";
    }

    return 0;
}