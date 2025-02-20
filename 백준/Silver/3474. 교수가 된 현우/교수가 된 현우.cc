#include<bits/stdc++.h>
using namespace std;

int N;
vector<int> res;

void CalZeroCount(int num){
    int cnt = 0;
    int a = 5;
    while(a <= num){
        cnt += (num / a);
        a *= 5;
    }
    res.push_back(cnt);
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> N;
    for (int i = 0; i < N; i++){
        int input;
        cin >> input;
        CalZeroCount(input);
    }

    for(int i : res) cout << i << "\n";

    return 0;
}