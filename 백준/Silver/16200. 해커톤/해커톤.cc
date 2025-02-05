#include <bits/stdc++.h>
using namespace std;

int N;
vector<int> x_num;
int res = 0;

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> N;
    for(int i = 0; i < N; i++){
        int temp;
        cin >> temp; x_num.push_back(temp);
    }

    sort(x_num.begin(), x_num.end());
    int s = 0;
    while(1){
        res ++;
        s += x_num[s];
        if (s >= N)
            break;
    }

    cout << res;
    return 0;
}