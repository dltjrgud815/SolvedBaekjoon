#include <bits/stdc++.h>
using namespace std;

int N, K;
vector<int> temperatures;
int max_res = INT_MIN;
int sum_arr[100001] = {0,};

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    cin >> N; cin >> K;

    for (int i = 1 ; i <= N; i++){
        int temperature;
        cin >> temperature;
        sum_arr[i] = sum_arr[i - 1] + temperature;
    }

    for (int i = K; i <= N; i++){
        max_res = max(max_res, sum_arr[i] - sum_arr[i - K]);
    }

    cout << max_res;
    return 0;
}