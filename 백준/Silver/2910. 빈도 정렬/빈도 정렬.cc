#include<bits/stdc++.h>
using namespace std;

int N, C;
vector<pair<int, int>> v;
map<int, int[2]> mp;

bool cmp(const pair<int, int> a, const pair<int, int> b){
    if (a.second == b.second){
        return mp[a.first][0] < mp[b.first][0]; 
    }
    return a.second > b.second;
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> N >> C;
    for (int i = 0; i < N; i++){
        int val;
        cin >> val;

        if (mp.find(val) == mp.end()){
            mp[val][0] = i;
            mp[val][1] = 1;
        }else{
            mp[val][1]++;
        }
    }

    for (auto it : mp){
        v.push_back({it.first, it.second[1]});
    }

    sort(v.begin(), v.end(), cmp);

    for (auto it : v){
        for (int i = 0; i < it.second; i++){
            cout << it.first << " ";
        }
    }
   
    return 0;
}