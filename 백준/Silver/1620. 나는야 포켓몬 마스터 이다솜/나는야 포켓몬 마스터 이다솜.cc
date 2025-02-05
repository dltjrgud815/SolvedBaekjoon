#include <bits/stdc++.h>
using namespace std;

map<string, int> mp1;
map<int, string> mp2;
int N, M;

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    cin >> N; cin >> M;
    for (int i = 1; i <= N; i++){
        string temp;
        cin >> temp;
        mp1.insert({temp, i});
        mp2.insert({i, temp});
    }

    for (int i = 0; i < M; i++){
        string temp;
        cin >> temp;
        int isNum = atoi(temp.c_str());
        if (isNum > 0)
            cout << mp2[isNum] << "\n";
        else
            cout << mp1[temp] << "\n";
    }
    return 0;
}