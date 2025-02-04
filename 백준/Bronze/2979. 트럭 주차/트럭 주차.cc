#include <bits/stdc++.h>
using namespace std;

int fee[4] = {0, };
int time_arr[101] = {0,};

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    cin >> fee[1] >> fee[2] >> fee[3];
    for (int i = 0; i < 3; i++){
        int start, end;
        cin >> start >> end;
        for (int j = start; j < end; j++){
            time_arr[j]++;
        }
    }
    int res = 0;
    for (int i : time_arr) {
        res += fee[i] * i;
    }
    cout << res;
}