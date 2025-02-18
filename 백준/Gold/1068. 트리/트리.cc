#include<bits/stdc++.h>
using namespace std;

const int max_val = 51;

int N;
int del;
int trees[max_val][max_val];
int visited[max_val];
map<int, int> parent_info;
int cnt = 0;

void remove_node(int del){
    int parent = parent_info[del];
    if (parent == -1){
        fill(&trees[0][0], &trees[0][0] + max_val * max_val, 0);
    }else{
        trees[parent][del] = 0;
        trees[del][parent] = 0;
    }
    
}

void dfs(int here){
    if (visited[here]) return;
    visited[here] = 1;
    bool isLeef = true;
    for (int i = 0; i < N; i++){
        if (trees[here][i] == 1 && !visited[i]){
            isLeef = false;
            dfs(i);
        }
    }
    if (isLeef) cnt++;
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    cin >> N;
    for (int i = 0; i < N; i++){
        int parent;
        cin >> parent;
        parent_info.insert({i, parent});
        if (parent == -1){
            trees[i][i] = parent;
        } else {
            trees[parent][i] = 1;
            trees[i][parent] = 1;
        }
    }
    cin >> del;
    remove_node(del);
    for (int i = 0; i < N; i++){
        if (trees[i][i] == -1)
            dfs(i);
    }

    cout << cnt << "\n";
    return 0;
}
