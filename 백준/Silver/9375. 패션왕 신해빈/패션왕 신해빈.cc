#include <bits/stdc++.h>
using namespace std;

map<string, vector<string>> mp;
int T, N;
vector<int> res;

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    cin >> T; 
    for (int i = 0; i < T; i++){
        cin >> N;
        int sum = 1;
        for (int j = 0; j < N; j++){
            string cloth;
            string type;
            cin >> cloth; cin >> type;
                mp[type].push_back(cloth);
        }
        for(auto it : mp) {
            sum *= (it.second.size() + 1);
        }
        res.push_back(--sum);
        mp.clear();
    }
    for(int it : res) cout << it << "\n";
    return 0;
}