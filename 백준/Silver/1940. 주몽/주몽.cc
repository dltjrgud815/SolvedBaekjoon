#include <bits/stdc++.h>
using namespace std;

int N, M;
int num[10000004] = {0,};
int res = 0;

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> N;
    cin >> M;

    for (int i = 0; i < N; i++){
        int temp;
        cin >> temp;
        num[temp] ++;
    }

    for (int i = 1; i <= M/2; i++){
        if (i == M-i)
            continue;
        int min_val = min(num[i], num[M - i]);
        res += min_val;
    }

    cout << res;
    return 0;
}