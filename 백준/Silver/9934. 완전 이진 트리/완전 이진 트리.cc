#include<bits/stdc++.h>
using namespace std;

int K;
int nodes[1030];
vector<int> tree[11];

void go(int s, int e, int depth){
    if (s > e) return;
    if (s == e){
        tree[depth].push_back(nodes[s]);
        return;
    } 
    
    int mid = (s + e) / 2;
    tree[depth].push_back(nodes[mid]);
    go (s, mid - 1, depth + 1);
    go (mid + 1, e, depth + 1);
    return;
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> K;
    int _end = (int)pow(2, K) - 1;
    for (int i = 0; i < _end; i++){
        cin >> nodes[i];
    }
    go (0, _end, 1);

    for (int i = 1; i <= K; i++){
        for (int it : tree[i]){
            cout << it << " ";
        }
        
        cout << "\n";
    }

    return 0;
}