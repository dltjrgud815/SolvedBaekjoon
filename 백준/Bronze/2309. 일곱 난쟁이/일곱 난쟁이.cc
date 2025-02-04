#include <bits/stdc++.h>
using namespace std;

vector<int> low;

int main(){
    for (int i = 0; i < 9; i++){
        int temp;
        cin >> temp;
        low.push_back(temp);
    }

    int first_sum = accumulate(low.begin(), low.end(), 0);
    for (int i = 0; i < 7; i++){
        for (int j = i + 1; j < 9; j++){
            int sum = first_sum - low[i] - low[j];
            if (sum == 100){
                low.erase(low.begin() + j);
                low.erase(low.begin() + i);
                goto EXIT;
            }
        }
    }

EXIT:   
    sort(low.begin(), low.end());
    for(auto it : low) cout << it << "\n";
    return 0;
}